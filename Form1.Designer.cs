namespace Cypher
{
    partial class Form1
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decypherCheckBox = new System.Windows.Forms.CheckBox();
            this.originalTextTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.errorTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Enabled = false;
            this.encryptButton.Location = new System.Drawing.Point(174, 81);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(147, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Обработать текст";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // decypherCheckBox
            // 
            this.decypherCheckBox.AutoSize = true;
            this.decypherCheckBox.Location = new System.Drawing.Point(174, 58);
            this.decypherCheckBox.Name = "decypherCheckBox";
            this.decypherCheckBox.Size = new System.Drawing.Size(102, 17);
            this.decypherCheckBox.TabIndex = 1;
            this.decypherCheckBox.Text = "Расшифровать";
            this.decypherCheckBox.UseVisualStyleBackColor = true;
            // 
            // originalTextTextBox
            // 
            this.originalTextTextBox.Location = new System.Drawing.Point(13, 51);
            this.originalTextTextBox.Name = "originalTextTextBox";
            this.originalTextTextBox.Size = new System.Drawing.Size(155, 20);
            this.originalTextTextBox.TabIndex = 2;
            this.originalTextTextBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключ";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(13, 93);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(155, 20);
            this.keyTextBox.TabIndex = 4;
            this.keyTextBox.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(326, 77);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(155, 20);
            this.resultTextBox.TabIndex = 6;
            // 
            // errorTextBox
            // 
            this.errorTextBox.AutoSize = true;
            this.errorTextBox.ForeColor = System.Drawing.Color.Red;
            this.errorTextBox.Location = new System.Drawing.Point(162, 116);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(169, 13);
            this.errorTextBox.TabIndex = 8;
            this.errorTextBox.Text = "Входные данные неправильные";
            this.errorTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 164);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.originalTextTextBox);
            this.Controls.Add(this.decypherCheckBox);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.CheckBox decypherCheckBox;
        private System.Windows.Forms.TextBox originalTextTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label errorTextBox;
    }
}

