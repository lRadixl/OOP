
namespace lab10
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pkzipTextBox = new System.Windows.Forms.TextBox();
            this.snefruTextBox = new System.Windows.Forms.TextBox();
            this.skipjackTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "pkzip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "snefru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "skipjack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введіть текст";
            // 
            // pkzipTextBox
            // 
            this.pkzipTextBox.Location = new System.Drawing.Point(11, 167);
            this.pkzipTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pkzipTextBox.Name = "pkzipTextBox";
            this.pkzipTextBox.Size = new System.Drawing.Size(427, 20);
            this.pkzipTextBox.TabIndex = 13;
            // 
            // snefruTextBox
            // 
            this.snefruTextBox.Location = new System.Drawing.Point(11, 130);
            this.snefruTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.snefruTextBox.Name = "snefruTextBox";
            this.snefruTextBox.Size = new System.Drawing.Size(427, 20);
            this.snefruTextBox.TabIndex = 12;
            // 
            // skipjackTextBox
            // 
            this.skipjackTextBox.Location = new System.Drawing.Point(11, 94);
            this.skipjackTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.skipjackTextBox.Name = "skipjackTextBox";
            this.skipjackTextBox.Size = new System.Drawing.Size(427, 20);
            this.skipjackTextBox.TabIndex = 11;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(11, 26);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(230, 20);
            this.inputTextBox.TabIndex = 10;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(245, 26);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(192, 63);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "ОК";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 209);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pkzipTextBox);
            this.Controls.Add(this.snefruTextBox);
            this.Controls.Add(this.skipjackTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pkzipTextBox;
        private System.Windows.Forms.TextBox snefruTextBox;
        private System.Windows.Forms.TextBox skipjackTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button encryptButton;
    }
}