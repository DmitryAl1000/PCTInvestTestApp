using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTInvestTestApp
{
    public partial class Form1 : Form
    {

        private readonly GetSendFormViewModel _dataContextModel;


        public Form1()
        {
            _dataContextModel = new GetSendFormViewModel(this);
            InitializeComponent();
        }


        private void InitBindings()
        {
            //
            //Поля для нового продукта
            //
            _dataContextModel.DataBindings.Add(new Binding("Text", _dataContextModel, "TitleNameAddTextBox"));
            ArticleTextBox.DataBindings.Add(new Binding("Text", DataContextModel, "ArticleAddTextBox"));
            ProductIdTextBox.DataBindings.Add(new Binding("Text", DataContextModel, "ProductIdAddTextBox"));
            DescriptionRichTextBox.DataBindings.Add(new Binding("Text", DataContextModel, "DescriptionAddTextBox"));
            //
            //Чекбоксы
            //
            SucseccMessegeCheckBox.DataBindings.Add(new Binding("Checked", DataContextModel, "SucsessMessegeCheckBox"));
            //
            //Поиск
            //
            serchTextBox.DataBindings.Add(new Binding("Text", DataContextModel, "SerchText"));
            //
            //Tаблица
            //
            BlackListDataGrid.DataBindings.Add(new Binding("DataSource", DataContextModel, "ProductsVeiw"));
            SelectedProductLabel.DataBindings.Add(new Binding("Text", DataContextModel, "SelectedIndex", false, DataSourceUpdateMode.OnPropertyChanged));
            //
            //Кнопки
            //
            AddButton.DataBindings.Add(new Binding("Command", DataContextModel, "AddCommand", true));
            DeleteButton.DataBindings.Add(new Binding("Command", DataContextModel, "DeleteCommand", true));
            SerchButton.DataBindings.Add(new Binding("Command", DataContextModel, "FindCommand", true));
            DropSerchButton.DataBindings.Add(new Binding("Command", DataContextModel, "DropSearchCommand", true));
            DropAddButton.DataBindings.Add(new Binding("Command", DataContextModel, "DropAddCommand", true));
            UseBackUpButton.DataBindings.Add(new Binding("Command", DataContextModel, "UseBackUpCommand", true));
            EditButton.DataBindings.Add(new Binding("Command", DataContextModel, "EditFormOpenCommand", true));
        }




        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
