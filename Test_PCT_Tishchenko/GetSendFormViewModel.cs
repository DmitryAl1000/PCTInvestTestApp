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

        private string _takerRichTextBox;
        public string TakerRichTextBox
        {
            get { return _takerRichTextBox; }
            set
            {
                _takerRichTextBox = value;
                OnPropertyChanged("TakerRichTextBox");
            }
        }

        private string _senderRichTextBox;
        public string SenderRichTextBox
        {
            get { return _senderRichTextBox; }
            set
            {
                _senderRichTextBox = value;
                OnPropertyChanged("SenderRichTextBox");
            }
        }


        public GetSendFormViewModel()
        {
            _takerDataGridView = new();
            _senderDataGridView = new();

            DeclareComands();
            //подгрузка из экселя
        }

        // Команды основной формы
        public ICommand CleanCommand { get; set; }








        private void DeclareComands()
        {
            CleanCommand = new MainCommand(p =>
            {
                CleanBothForm();
                OnPropertyChanged(nameof(TakerDataGridView));
                OnPropertyChanged(nameof(SenderDataGridView));
            });




        }

        private void CleanBothForm()
        {
            CleanTakerDataGridView();
            CleanSenderDataGridView();
        }

        private void CleanTakerDataGridView()
        {


        }

        private void CleanSenderDataGridView()
        {


        }






        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
