namespace PCTInvestTestApp
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
            this.GetDataGridView = new System.Windows.Forms.DataGridView();
            this.SendDataGridView = new System.Windows.Forms.DataGridView();
            this.GetLabel = new System.Windows.Forms.Label();
            this.GetRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GetDiscriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CleanButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SendLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetDataGridView
            // 
            this.GetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetDataGridView.Location = new System.Drawing.Point(3, 187);
            this.GetDataGridView.Name = "GetDataGridView";
            this.GetDataGridView.Size = new System.Drawing.Size(517, 360);
            this.GetDataGridView.TabIndex = 0;
            // 
            // SendDataGridView
            // 
            this.SendDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SendDataGridView.Location = new System.Drawing.Point(3, 187);
            this.SendDataGridView.Name = "SendDataGridView";
            this.SendDataGridView.Size = new System.Drawing.Size(517, 360);
            this.SendDataGridView.TabIndex = 1;
            // 
            // GetLabel
            // 
            this.GetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.GetLabel.Location = new System.Drawing.Point(3, 158);
            this.GetLabel.Name = "GetLabel";
            this.GetLabel.Size = new System.Drawing.Size(517, 26);
            this.GetLabel.TabIndex = 2;
            this.GetLabel.Text = "Приём";
            this.GetLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GetRichTextBox
            // 
            this.GetRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetRichTextBox.Location = new System.Drawing.Point(3, 101);
            this.GetRichTextBox.Name = "GetRichTextBox";
            this.GetRichTextBox.Size = new System.Drawing.Size(517, 43);
            this.GetRichTextBox.TabIndex = 4;
            this.GetRichTextBox.Text = "";
            // 
            // SendRichTextBox
            // 
            this.SendRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendRichTextBox.Location = new System.Drawing.Point(3, 101);
            this.SendRichTextBox.Name = "SendRichTextBox";
            this.SendRichTextBox.Size = new System.Drawing.Size(517, 43);
            this.SendRichTextBox.TabIndex = 5;
            this.SendRichTextBox.Text = "";
            // 
            // GetDiscriptionLabel
            // 
            this.GetDiscriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDiscriptionLabel.Location = new System.Drawing.Point(3, 76);
            this.GetDiscriptionLabel.Name = "GetDiscriptionLabel";
            this.GetDiscriptionLabel.Size = new System.Drawing.Size(517, 22);
            this.GetDiscriptionLabel.TabIndex = 6;
            this.GetDiscriptionLabel.Text = "Поле ввода данных для приёма";
            this.GetDiscriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(4, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поле ввода данных для отгрузки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CleanButton
            // 
            this.CleanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CleanButton.Location = new System.Drawing.Point(13, 568);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(130, 35);
            this.CleanButton.TabIndex = 8;
            this.CleanButton.Text = "Очистить";
            this.CleanButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GetDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.GetLabel);
            this.splitContainer1.Panel1.Controls.Add(this.GetRichTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.GetDiscriptionLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SendLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SendDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.SendRichTextBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 550);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.TabIndex = 9;
            // 
            // SendLabel
            // 
            this.SendLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SendLabel.Location = new System.Drawing.Point(3, 160);
            this.SendLabel.Name = "SendLabel";
            this.SendLabel.Size = new System.Drawing.Size(517, 24);
            this.SendLabel.TabIndex = 8;
            this.SendLabel.Text = "Отгрузка2";
            this.SendLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 623);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CleanButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GetDataGridView;
        private System.Windows.Forms.DataGridView SendDataGridView;
        private System.Windows.Forms.Label GetLabel;
        private System.Windows.Forms.RichTextBox GetRichTextBox;
        private System.Windows.Forms.RichTextBox SendRichTextBox;
        private System.Windows.Forms.Label GetDiscriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label SendLabel;
    }
}

