using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Excell;
using Lib_Excell;
using Aspose.Cells.Drawing;
using Microsoft.VisualBasic.Logging;
using System.IO;
using System.IO.Pipes;

namespace PCTInvestApp
{
    public class GetSendFormViewModel : INotifyPropertyChanged
    {
        //ссылка на форму
        readonly ISimpleFormComands _activeForm;
        readonly HashSet<string> _dictionaryOfLabels;


        const string ERROR_MESSEGE_HEADER = "Данные коды не добавлены:";

        const string ERROR_MESSEGE_NOT24_SIMBOL = " - не 24 символа";
        const string ERROR_MESSEGE_NOT_HEXCODE = " - не является HexКодом";
        const string ERROR_MESSEGE_NOT_IN_DICTIONARY = " - нет в перечне идентификаторов";


        //---------------------------------------------
        //Table, Tаблицы
        //---------------------------------------------
        private BindingList<ILabel> _takerDataGridView;
        public BindingList<ILabel> TakerDataGridView
        {
            get { return _takerDataGridView; }
            set
            {
                _takerDataGridView = value;
                OnPropertyChanged("TakerDataGridView");
            }
        }

        private BindingList<ILabel> _senderDataGridView;
        public BindingList<ILabel> SenderDataGridView
        {
            get { return _senderDataGridView; }
            set
            {
                _senderDataGridView = value;
                OnPropertyChanged("SenderDataGridView");
            }
        }

        //---------------------------------------------
        //TextFields, Текстовые поля
        //---------------------------------------------

        private string _takerRichTextBox = string.Empty;
        public string TakerRichTextBox
        {
            get { return _takerRichTextBox; }
            set
            {
                _takerRichTextBox = value;
                OnPropertyChanged("TakerRichTextBox");
            }
        }

        private string _senderRichTextBox = string.Empty;
        public string SenderRichTextBox
        {
            get { return _senderRichTextBox; }
            set
            {
                _senderRichTextBox = value;
                OnPropertyChanged("SenderRichTextBox");
            }
        } 


        public GetSendFormViewModel(ISimpleFormComands activeForm, HashSet<string> dictionaryOfLabels )
        {
            this._activeForm = activeForm;
            this._dictionaryOfLabels = dictionaryOfLabels;


            _takerDataGridView = new();
            _senderDataGridView = new();

            DeclareComands();
        }

        //---------------------------------------------
        //Commands, Команды
        //---------------------------------------------
        public ICommand? CleanCommand { get; set; }
        public ICommand? TakerAddCommand  { get; set; }
        public ICommand? SenderAddCommand { get; set; }

        private void DeclareComands()
        {
            CleanCommand = new MainCommand(p =>
            {
                CleanBothForm();
                OnPropertyChanged(nameof(TakerDataGridView));
                OnPropertyChanged(nameof(SenderDataGridView));
            });
            TakerAddCommand = new MainCommand(p =>
            {
                AddToTakerDb();
                OnPropertyChanged(nameof(TakerDataGridView));
                OnPropertyChanged(nameof(SenderDataGridView));
                TakerRichTextBox = string.Empty;
            });
            SenderAddCommand = new MainCommand(p =>
            {

                AddAllFromField(textField: SenderRichTextBox, 
                                dbForAdd: SenderDataGridView,
                                dbForDelete: TakerDataGridView);

                OnPropertyChanged(nameof(TakerDataGridView));
                OnPropertyChanged(nameof(SenderDataGridView));
                SenderRichTextBox = string.Empty;
            });
        }


        /// <summary>
        /// Очистить обе формы
        /// </summary>
        public void CleanBothForm()
        {
            CleanTakerDataGridView();
            CleanSenderDataGridView();
        }

        private void CleanTakerDataGridView() => TakerDataGridView.Clear();
        private void CleanSenderDataGridView() => SenderDataGridView.Clear();

        public void AddToTakerDb()
        {
            AddAllFromField(textField: TakerRichTextBox,
                                dbForAdd: TakerDataGridView,
                                dbForDelete: SenderDataGridView);
        }


        public void AddToSenderDb()
        {
            AddAllFromField(textField: SenderRichTextBox,
                                dbForAdd: SenderDataGridView,
                                dbForDelete: TakerDataGridView);
        }



        /// <summary>
        /// Добавить в одну форму и удалить из другой
        /// </summary>
        /// <param name="textField"></param>
        /// <param name="dbForAdd"></param>
        /// <param name="dbForDelete"></param>
        private void AddAllFromField(string textField, BindingList<ILabel> dbForAdd, BindingList<ILabel> dbForDelete)
        {
            List<string> ErrorList = new();
            foreach (var hexCode in textField.Split())
            {
                if (!IsItCorrectHexCode(hexCode, ErrorList))
                    continue;

                AddOneToDB(dbForAdd, hexCode);
                RemoveOneFromDB(dbForDelete, hexCode);
            }
            if (ErrorList.Count > 0)
                ShowErrorMessege(ErrorList);
        }

        private void RemoveOneFromDB(BindingList<ILabel> dataBase, string id)
        {
            RFIDLabel label = new("0",0); //пустая метка для замены, если придется удалять
            foreach (var item in dataBase)
            {
                if (item.Id.ToUpper() == id.ToUpper())
                {
                    if (item.Count > 1)
                        item.Count--;
                    else
                        label = new(item.Id, item.Count);
                    break;
                }
            }
            dataBase.Remove(label);
            Reresh(dataBase);
        }
        private void AddOneToDB(BindingList<ILabel> dataBase, string hexCode)
        {
            if (IsIdInDataBase(dataBase, hexCode))
            {
                foreach (var item in dataBase)
                {
                    if (item.Id.ToUpper() == hexCode.ToUpper())
                    {
                        item.Count++;
                        break;
                    }
                }
            }
            else
            {
                var label = new RFIDLabel(hexCode, 1); // 1 - потому что добавляется одна метка(первая), если метки небыло
                dataBase.Add(label);
            }
            Reresh(dataBase); 
        }

        private void Reresh(BindingList<ILabel> dataBase)
        {
            var label = new RFIDLabel("1", 1);
            dataBase.Add(label);
            dataBase.Remove(label);
        }
        private void ShowErrorMessege(List<string> ErrorList)
        {
            string messege = string.Empty;
            if (ErrorList.Count > 0)
            {
                messege += ERROR_MESSEGE_HEADER + "\n\n";

                for (int i = 0; i < ErrorList.Count; i++)
                {
                    messege += $"{i + 1}. " + ErrorList[i] + "\n"; // +1 чтобы счет в списке начиналс с 1 а не с нуля. 
                }
            }
            _activeForm.showErrorMessege(messege);
        }

        //---------------------------------------------
        // Checks
        //---------------------------------------------

        private bool IsItCorrectHexCode(string hexCode, List<string> errorList)
        {
            if (string.IsNullOrEmpty(hexCode))
                return false;
            if (!IsIt24Simbol(hexCode))
            {
                errorList.Add(hexCode + ERROR_MESSEGE_NOT24_SIMBOL);
                return false;
            }
                
            if (!IsItHexCode(hexCode))
            {
                errorList.Add(hexCode + ERROR_MESSEGE_NOT_HEXCODE);
                return false;
            }
                
            if (!IsItInDictionary(hexCode))
            {
                errorList.Add(hexCode + ERROR_MESSEGE_NOT_IN_DICTIONARY);
                return false;
            }
            return true;
        }

        private bool IsItInDictionary(string HexCode)
        {
            if (_dictionaryOfLabels.Contains(HexCode))
                return true;
            else
                return false;
        }
        private bool IsIdInDataBase(BindingList<ILabel> dataBase, string id)
        {
            var target = new RFIDLabel(id,0); 
            //0 тут просто так сравнение идет только по id
            //Equals переопределен
            if (dataBase.Contains(target))
                return true;
            else
                return false;
        }
        private bool IsIt24Simbol(string line)
        {
            if (line.Length == 24)
                return true;
            else
                return false;
        }
        private bool IsItHexCode(string line)
        {
            List<char> binnums = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

            foreach (var simbol in line.ToUpper())
            {
                if (!binnums.Contains(simbol))
                    return false;
            }
            return true;
        }


        //---------------------------------------------
        // OnPropertyChanged, synchronization
        //---------------------------------------------
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
