using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PCTInvestTestApp
{
    public class GetSendFormViewModel : INotifyPropertyChanged
    {
        //ссылка на форму
        readonly ISimpleFormComands _activeForm;

        const string ERROR_MESSEGE_HEADER = "Данные Идентификаторы не присутствуют в справочнике, или не являются 24хсимвольным HexКодом";



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


        public GetSendFormViewModel(ISimpleFormComands activeForm)
        {
            this._activeForm = activeForm;

            _takerDataGridView = new();
            _senderDataGridView = new();

            DeclareComands();

            RFIDLabel label = new("00000000000000000000FDDF", 10);
            TakerDataGridView.Add(label);
            //подгрузка из экселя
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
                TakerAdd();
                OnPropertyChanged(nameof(TakerDataGridView));
                OnPropertyChanged(nameof(SenderDataGridView));
                TakerRichTextBox = string.Empty;
            });
            SenderAddCommand = new MainCommand(p =>
            {
                SenderAdd();
                OnPropertyChanged(nameof(TakerDataGridView));
                OnPropertyChanged(nameof(SenderDataGridView));
                SenderRichTextBox = string.Empty;
            });
        }


        /// <summary>
        /// Очистить обе формы
        /// </summary>
        private void CleanBothForm()
        {
            CleanTakerDataGridView();
            CleanSenderDataGridView();
        }

        private void CleanTakerDataGridView() => TakerDataGridView.Clear();
        private void CleanSenderDataGridView() => SenderDataGridView.Clear();


        /// <summary>
        /// Добавить в Приёмки, если такой Id есть в Отгрузках удалить его
        /// </summary>
        private void TakerAdd()
        {
            List<string> ErrorList = new();
            foreach (var hexCode in TakerRichTextBox.Split())
            {
                if (IsIt24HexCode(hexCode))
                    AddToFirstDeleteFromSecond(hexCode, TakerDataGridView, SenderDataGridView);
                else
                    if (hexCode != string.Empty)
                          ErrorList.Add(hexCode);
            }
            if (ErrorList.Count > 0)
                ShowErrorMessege(ErrorList);
        }

        private void SenderAdd()
        {
            List<string> ErrorList = new();
            foreach (var hexCode in SenderRichTextBox.Split())
            {
                if (IsIt24HexCode(hexCode))
                    AddToFirstDeleteFromSecond(hexCode, SenderDataGridView, TakerDataGridView);
                else
                    if (hexCode != string.Empty)
                    ErrorList.Add(hexCode);
            }
            if (ErrorList.Count > 0)
                ShowErrorMessege(ErrorList);
        }


        private void AddToFirstDeleteFromSecond(string hexCode, BindingList<ILabel> dbForAdd, BindingList<ILabel> dbForDelete)
        {
            if (IsIdInDataBase(dbForAdd, hexCode))
            {
                AddOneToAnExistingId(dbForAdd, hexCode);
                RemoveOneFromDB(dbForDelete, hexCode);
            }
            else
            {
                var label = new RFIDLabel(hexCode, 1); // 1 - потому что добавляется одна метка(первая), если метки небыло
                dbForAdd.Add(label);
                RemoveOneFromDB(dbForDelete, hexCode);
            }
        }



        private void RemoveOneFromDB(BindingList<ILabel> dataBase, string id)
        {
            RFIDLabel label = new("0",0); //пустая метка для замены, если придется удалять
            foreach (var item in dataBase)
            {
                if (item.Id.ToLower() == id.ToLower())
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

        private void AddOneToAnExistingId(BindingList<ILabel> dataBase, string id)
        {
            foreach (var item in dataBase)
            {
                if (item.Id.ToLower() == id.ToLower())
                {
                    item.Count++;
                    break;
                }
            }
            Reresh(dataBase);
        }

        private void Reresh(BindingList<ILabel> dataBase)
        {
            var label = new RFIDLabel("1", 1);
            dataBase.Add(label);
            dataBase.Remove(label);
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

        private void ShowErrorMessege(List<string> ErrorList)
        {
            string messege = string.Empty;
            if (ErrorList.Count > 0)
            {
                messege += ERROR_MESSEGE_HEADER + "\n";

                for (int i = 0; i < ErrorList.Count; i++)
                {
                    messege += $"{i+1}. " + ErrorList[i] + "\n"; // +1 чтобы счет в списке начиналс с 1 а не с нуля. 
                }  
            }
            _activeForm.showErrorMessege(messege);
        }
        private bool IsIt24HexCode(string line)
        {
            if (!IsIt24Simbol(line))
                return false;
            if (!IsItHexCode(line))
                return false;

            return true;
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
            List<char> binnums = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'];

            foreach (var simbol in line.ToLower())
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
