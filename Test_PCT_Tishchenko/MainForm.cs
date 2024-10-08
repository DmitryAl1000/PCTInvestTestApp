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
            TakerDataGridView.DataBindings.Add(new Binding("DataSource", _dataContextModel, "TakerDataGridView"));
            SenderDataGridView.DataBindings.Add(new Binding("DataSource", _dataContextModel, "SenderDataGridView"));

            //---------------------------------------------
            //TextFields, Текстовые поля
            //---------------------------------------------
            TakerRichTextBox.DataBindings.Add(new Binding("Text", _dataContextModel, "TakerRichTextBox"));
            SenderRichTextBox.DataBindings.Add(new Binding("Text", _dataContextModel, "SenderRichTextBox"));

            //---------------------------------------------
            //Buttons, кнопки
            //---------------------------------------------
            CleanButton.DataBindings.Add(new Binding("Command", _dataContextModel, "CleanCommand", true));
        }


        private void SetupTakerDataGridView(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowDrop = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView.Columns["Id"].Width = 350;
            dataGridView.Columns["Id"].HeaderText = "Идентификатор метки";

            dataGridView.Columns["Count"].Width = 100;
            dataGridView.Columns["Count"].HeaderText = "Количество";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupTakerDataGridView(TakerDataGridView);




        }


    }
}
