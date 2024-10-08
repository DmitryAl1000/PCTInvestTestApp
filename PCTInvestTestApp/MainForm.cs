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
    public partial class MainForm : Form
    {

        private readonly GetSendFormViewModel _dataContextModel;


        public MainForm()
        {
            _dataContextModel = new GetSendFormViewModel();
            InitializeComponent();
            InitBindings();
        }


        private void InitBindings()
        {
            //---------------------------------------------
            //Table, Tаблицы
            //---------------------------------------------
            GetDataGridView.DataBindings.Add(new Binding("DataSource", _dataContextModel, "GetDataGridView"));
            SendDataGridView.DataBindings.Add(new Binding("DataSource", _dataContextModel, "SendDataGridView"));

            //---------------------------------------------
            //TextFields, Текстовые поля
            //---------------------------------------------
            GetRichTextBox.DataBindings.Add(new Binding("Text", _dataContextModel, "GetRichTextBox"));
            SendRichTextBox.DataBindings.Add(new Binding("Text", _dataContextModel, "SendRichTextBox"));

            //---------------------------------------------
            //Buttons, кнопки
            //---------------------------------------------
            CleanButton.DataBindings.Add(new Binding("Command", _dataContextModel, "CleanCommand", true));
        }




        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
