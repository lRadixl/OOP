
namespace Lab11_1
{
    partial class Form1
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
            this.reportRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.searchResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.DisplayDataButton = new System.Windows.Forms.Button();
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportRichTextBox2
            // 
            this.reportRichTextBox2.Location = new System.Drawing.Point(187, 151);
            this.reportRichTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.reportRichTextBox2.Name = "reportRichTextBox2";
            this.reportRichTextBox2.Size = new System.Drawing.Size(152, 91);
            this.reportRichTextBox2.TabIndex = 27;
            this.reportRichTextBox2.Text = "";
            // 
            // searchResultsRichTextBox
            // 
            this.searchResultsRichTextBox.Location = new System.Drawing.Point(32, 272);
            this.searchResultsRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultsRichTextBox.Name = "searchResultsRichTextBox";
            this.searchResultsRichTextBox.Size = new System.Drawing.Size(335, 145);
            this.searchResultsRichTextBox.TabIndex = 26;
            this.searchResultsRichTextBox.Text = "";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(248, 247);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(119, 20);
            this.searchTextBox.TabIndex = 25;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(32, 247);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(212, 21);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Пошук по прізвищю";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.Location = new System.Drawing.Point(31, 151);
            this.reportRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.Size = new System.Drawing.Size(137, 91);
            this.reportRichTextBox.TabIndex = 23;
            this.reportRichTextBox.Text = "";
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(31, 127);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(308, 19);
            this.ReportButton.TabIndex = 22;
            this.ReportButton.Text = "Вивести запити";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(169, 93);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.birthDateDateTimePicker.TabIndex = 21;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(155, 69);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(76, 20);
            this.groupTextBox.TabIndex = 20;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(155, 48);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(76, 20);
            this.surnameTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(155, 23);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(386, 23);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(454, 391);
            this.dataGridView.TabIndex = 17;
            // 
            // DisplayDataButton
            // 
            this.DisplayDataButton.Location = new System.Drawing.Point(265, 48);
            this.DisplayDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayDataButton.Name = "DisplayDataButton";
            this.DisplayDataButton.Size = new System.Drawing.Size(102, 37);
            this.DisplayDataButton.TabIndex = 16;
            this.DisplayDataButton.Text = "Вивести таблицю";
            this.DisplayDataButton.UseVisualStyleBackColor = true;
            this.DisplayDataButton.Click += new System.EventHandler(this.DisplayDataButton_Click);
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(265, 19);
            this.InsertDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(102, 27);
            this.InsertDataButton.TabIndex = 15;
            this.InsertDataButton.Text = "Внести дані";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введіть ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введіть прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Введіть назву групи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Оберіть дату народження";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportRichTextBox2);
            this.Controls.Add(this.searchResultsRichTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.reportRichTextBox);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.DisplayDataButton);
            this.Controls.Add(this.InsertDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox reportRichTextBox2;
        private System.Windows.Forms.RichTextBox searchResultsRichTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button DisplayDataButton;
        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

