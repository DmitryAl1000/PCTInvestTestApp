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
    public partial class MainForm : Form, ISimpleFormComands
    {

        private readonly GetSendFormViewModel _dataContextModel;


        public MainForm()
        {
            _dataContextModel = new GetSendFormViewModel(this);
            InitializeComponent();
            InitBindings();


        }


        private void InitBindings()
        {
            //---------------------------------------------
            //Table, Tаблицы
            //---------------------------------------------
            TakerDataGridView.DataBindings.Add(new Binding("DataSource", _dataContextModel, "TakerDataGridView", false, DataSourceUpdateMode.OnPropertyChanged));
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

            TakerAddButton.DataBindings.Add(new Binding("Command", _dataContextModel, "TakerAddCommand", true));
            SenderAddButton.DataBindings.Add(new Binding("Command", _dataContextModel, "SenderAddCommand", true));
        }


        private void SetupTakerDataGridView(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowDrop = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView.Columns[0].Width = 350;
            dataGridView.Columns[0].HeaderText = "Идентификатор метки";

            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[1].HeaderText = "Количество";
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupTakerDataGridView(TakerDataGridView);
            SetupTakerDataGridView(SenderDataGridView);
        }


        //---------------------------------------------
        // Hot Keys
        //---------------------------------------------

        private void TakerRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TakerAddButton.PerformClick();
        }

        private void SenderRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SenderAddButton.PerformClick();
        }


        //---------------------------------------------
        // Commands
        //---------------------------------------------
        public void showMessege(string str) => MessageBox.Show(str);
        public void showErrorMessege(string str) => MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        public bool IsYesOrNoShowMessge(string str)
        {
            DialogResult result = MessageBox.Show(
                    str,
                    "Вы уверены?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                return true;

            return false;
        }
        public void CloseForm() => this.Close();
    }
}
