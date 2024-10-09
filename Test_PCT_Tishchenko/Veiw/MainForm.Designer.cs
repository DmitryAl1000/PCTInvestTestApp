namespace PCTInvestApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            TakerDataGridView = new DataGridView();
            SenderDataGridView = new DataGridView();
            GetLabel = new Label();
            TakerRichTextBox = new RichTextBox();
            SenderRichTextBox = new RichTextBox();
            GetDiscriptionLabel = new Label();
            label1 = new Label();
            CleanButton = new Button();
            splitContainer1 = new SplitContainer();
            TakerAddButton = new Button();
            SenderAddButton = new Button();
            SendLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)TakerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SenderDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // TakerDataGridView
            // 
            TakerDataGridView.AllowUserToDeleteRows = false;
            TakerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TakerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TakerDataGridView.Location = new Point(4, 216);
            TakerDataGridView.Margin = new Padding(4, 3, 4, 3);
            TakerDataGridView.Name = "TakerDataGridView";
            TakerDataGridView.Size = new Size(368, 294);
            TakerDataGridView.TabIndex = 0;
            // 
            // SenderDataGridView
            // 
            SenderDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SenderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SenderDataGridView.Location = new Point(4, 216);
            SenderDataGridView.Margin = new Padding(4, 3, 4, 3);
            SenderDataGridView.Name = "SenderDataGridView";
            SenderDataGridView.Size = new Size(360, 294);
            SenderDataGridView.TabIndex = 1;
            // 
            // GetLabel
            // 
            GetLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GetLabel.Font = new Font("Microsoft Sans Serif", 16F);
            GetLabel.Location = new Point(4, 182);
            GetLabel.Margin = new Padding(4, 0, 4, 0);
            GetLabel.Name = "GetLabel";
            GetLabel.Size = new Size(368, 30);
            GetLabel.TabIndex = 2;
            GetLabel.Text = "Приём";
            GetLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // TakerRichTextBox
            // 
            TakerRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TakerRichTextBox.Location = new Point(4, 117);
            TakerRichTextBox.Margin = new Padding(4, 3, 4, 3);
            TakerRichTextBox.Name = "TakerRichTextBox";
            TakerRichTextBox.Size = new Size(367, 49);
            TakerRichTextBox.TabIndex = 4;
            TakerRichTextBox.Text = "";
            TakerRichTextBox.KeyDown += TakerRichTextBox_KeyDown;
            // 
            // SenderRichTextBox
            // 
            SenderRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SenderRichTextBox.Location = new Point(4, 117);
            SenderRichTextBox.Margin = new Padding(4, 3, 4, 3);
            SenderRichTextBox.Name = "SenderRichTextBox";
            SenderRichTextBox.Size = new Size(359, 49);
            SenderRichTextBox.TabIndex = 5;
            SenderRichTextBox.Text = "";
            SenderRichTextBox.KeyDown += SenderRichTextBox_KeyDown;
            // 
            // GetDiscriptionLabel
            // 
            GetDiscriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GetDiscriptionLabel.Location = new Point(4, 88);
            GetDiscriptionLabel.Margin = new Padding(4, 0, 4, 0);
            GetDiscriptionLabel.Name = "GetDiscriptionLabel";
            GetDiscriptionLabel.Size = new Size(368, 25);
            GetDiscriptionLabel.TabIndex = 6;
            GetDiscriptionLabel.Text = "Поле ввода данных для приёма";
            GetDiscriptionLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(5, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(361, 22);
            label1.TabIndex = 7;
            label1.Text = "Поле ввода данных для отгрузки";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CleanButton
            // 
            CleanButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CleanButton.Font = new Font("Microsoft Sans Serif", 10F);
            CleanButton.Location = new Point(9, 524);
            CleanButton.Margin = new Padding(4, 3, 4, 3);
            CleanButton.Name = "CleanButton";
            CleanButton.Size = new Size(152, 40);
            CleanButton.TabIndex = 8;
            CleanButton.Text = "Очистить";
            CleanButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(9, 4);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TakerAddButton);
            splitContainer1.Panel1.Controls.Add(TakerDataGridView);
            splitContainer1.Panel1.Controls.Add(GetLabel);
            splitContainer1.Panel1.Controls.Add(TakerRichTextBox);
            splitContainer1.Panel1.Controls.Add(GetDiscriptionLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SenderAddButton);
            splitContainer1.Panel2.Controls.Add(SendLabel);
            splitContainer1.Panel2.Controls.Add(SenderDataGridView);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(SenderRichTextBox);
            splitContainer1.Size = new Size(764, 514);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 9;
            // 
            // TakerAddButton
            // 
            TakerAddButton.Location = new Point(-50, -50);
            TakerAddButton.Name = "TakerAddButton";
            TakerAddButton.Size = new Size(128, 27);
            TakerAddButton.TabIndex = 7;
            TakerAddButton.Text = "добавить в прием";
            TakerAddButton.UseVisualStyleBackColor = true;
            // 
            // SenderAddButton
            // 
            SenderAddButton.Location = new Point(-50, -50);
            SenderAddButton.Name = "SenderAddButton";
            SenderAddButton.Size = new Size(154, 23);
            SenderAddButton.TabIndex = 9;
            SenderAddButton.Text = "Добавить в отгрузку";
            SenderAddButton.UseVisualStyleBackColor = true;
            // 
            // SendLabel
            // 
            SendLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SendLabel.Font = new Font("Microsoft Sans Serif", 14F);
            SendLabel.Location = new Point(4, 185);
            SendLabel.Margin = new Padding(4, 0, 4, 0);
            SendLabel.Name = "SendLabel";
            SendLabel.Size = new Size(359, 28);
            SendLabel.TabIndex = 8;
            SendLabel.Text = "Отгрузка";
            SendLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 588);
            Controls.Add(splitContainer1);
            Controls.Add(CleanButton);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(510, 427);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TakerDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SenderDataGridView).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView TakerDataGridView;
        private System.Windows.Forms.DataGridView SenderDataGridView;
        private System.Windows.Forms.Label GetLabel;
        private System.Windows.Forms.RichTextBox TakerRichTextBox;
        private System.Windows.Forms.RichTextBox SenderRichTextBox;
        private System.Windows.Forms.Label GetDiscriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label SendLabel;
        private Button SenderAddButton;
        public Button TakerAddButton;
    }
}

