﻿namespace PCTInvestTestApp
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
            TakerDataGridView.Size = new Size(487, 425);
            TakerDataGridView.TabIndex = 0;
            // 
            // SenderDataGridView
            // 
            SenderDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SenderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SenderDataGridView.Location = new Point(4, 216);
            SenderDataGridView.Margin = new Padding(4, 3, 4, 3);
            SenderDataGridView.Name = "SenderDataGridView";
            SenderDataGridView.Size = new Size(486, 425);
            SenderDataGridView.TabIndex = 1;
            // 
            // GetLabel
            // 
            GetLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GetLabel.Font = new Font("Microsoft Sans Serif", 16F);
            GetLabel.Location = new Point(4, 182);
            GetLabel.Margin = new Padding(4, 0, 4, 0);
            GetLabel.Name = "GetLabel";
            GetLabel.Size = new Size(487, 30);
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
            TakerRichTextBox.Size = new Size(486, 49);
            TakerRichTextBox.TabIndex = 4;
            TakerRichTextBox.Text = "";
            // 
            // SenderRichTextBox
            // 
            SenderRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SenderRichTextBox.Location = new Point(4, 117);
            SenderRichTextBox.Margin = new Padding(4, 3, 4, 3);
            SenderRichTextBox.Name = "SenderRichTextBox";
            SenderRichTextBox.Size = new Size(485, 49);
            SenderRichTextBox.TabIndex = 5;
            SenderRichTextBox.Text = "";
            // 
            // GetDiscriptionLabel
            // 
            GetDiscriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GetDiscriptionLabel.Location = new Point(4, 88);
            GetDiscriptionLabel.Margin = new Padding(4, 0, 4, 0);
            GetDiscriptionLabel.Name = "GetDiscriptionLabel";
            GetDiscriptionLabel.Size = new Size(487, 25);
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
            label1.Size = new Size(487, 22);
            label1.TabIndex = 7;
            label1.Text = "Поле ввода данных для отгрузки";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CleanButton
            // 
            CleanButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CleanButton.Font = new Font("Microsoft Sans Serif", 10F);
            CleanButton.Location = new Point(9, 655);
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
            splitContainer1.Panel1.Controls.Add(TakerDataGridView);
            splitContainer1.Panel1.Controls.Add(GetLabel);
            splitContainer1.Panel1.Controls.Add(TakerRichTextBox);
            splitContainer1.Panel1.Controls.Add(GetDiscriptionLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SendLabel);
            splitContainer1.Panel2.Controls.Add(SenderDataGridView);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(SenderRichTextBox);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(999, 645);
            splitContainer1.SplitterDistance = 499;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 9;
            // 
            // SendLabel
            // 
            SendLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SendLabel.Font = new Font("Microsoft Sans Serif", 14F);
            SendLabel.Location = new Point(4, 185);
            SendLabel.Margin = new Padding(4, 0, 4, 0);
            SendLabel.Name = "SendLabel";
            SendLabel.Size = new Size(485, 28);
            SendLabel.TabIndex = 8;
            SendLabel.Text = "Отгрузка";
            SendLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 719);
            Controls.Add(splitContainer1);
            Controls.Add(CleanButton);
            Margin = new Padding(4, 3, 4, 3);
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
    }
}

