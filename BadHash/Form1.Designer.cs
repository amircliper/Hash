
namespace BadHash
{
    partial class BadHasher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeCopyBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OutputDecoderTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InputDecodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TestBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Text : ";
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(24, 219);
            this.InputText.Margin = new System.Windows.Forms.Padding(6);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(500, 293);
            this.InputText.TabIndex = 2;
            // 
            // OutputText
            // 
            this.OutputText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.OutputText.Location = new System.Drawing.Point(24, 632);
            this.OutputText.Margin = new System.Windows.Forms.Padding(6);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(500, 293);
            this.OutputText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 572);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output Text : ";
            // 
            // CodeCopyBtn
            // 
            this.CodeCopyBtn.BackColor = System.Drawing.Color.Black;
            this.CodeCopyBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.CodeCopyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodeCopyBtn.Location = new System.Drawing.Point(540, 707);
            this.CodeCopyBtn.Margin = new System.Windows.Forms.Padding(6);
            this.CodeCopyBtn.Name = "CodeCopyBtn";
            this.CodeCopyBtn.Size = new System.Drawing.Size(226, 105);
            this.CodeCopyBtn.TabIndex = 6;
            this.CodeCopyBtn.Text = "Copy";
            this.CodeCopyBtn.UseVisualStyleBackColor = false;
            this.CodeCopyBtn.Click += new System.EventHandler(this.CodeCopyBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1366, 707);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 105);
            this.button1.TabIndex = 13;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1366, 823);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 105);
            this.button2.TabIndex = 12;
            this.button2.Text = "DeCode";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutputDecoderTxt
            // 
            this.OutputDecoderTxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDecoderTxt.Location = new System.Drawing.Point(850, 632);
            this.OutputDecoderTxt.Margin = new System.Windows.Forms.Padding(6);
            this.OutputDecoderTxt.Multiline = true;
            this.OutputDecoderTxt.Name = "OutputDecoderTxt";
            this.OutputDecoderTxt.ReadOnly = true;
            this.OutputDecoderTxt.Size = new System.Drawing.Size(500, 293);
            this.OutputDecoderTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(852, 572);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 55);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output Text : ";
            // 
            // InputDecodeTxt
            // 
            this.InputDecodeTxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.InputDecodeTxt.Location = new System.Drawing.Point(850, 219);
            this.InputDecodeTxt.Margin = new System.Windows.Forms.Padding(6);
            this.InputDecodeTxt.Multiline = true;
            this.InputDecodeTxt.Name = "InputDecodeTxt";
            this.InputDecodeTxt.Size = new System.Drawing.Size(500, 293);
            this.InputDecodeTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 55);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input Text : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(850, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 66);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decoder";
            // 
            // TestBtn
            // 
            this.TestBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.TestBtn.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.TestBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TestBtn.Location = new System.Drawing.Point(540, 322);
            this.TestBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(226, 105);
            this.TestBtn.TabIndex = 14;
            this.TestBtn.Text = "Start";
            this.TestBtn.UseVisualStyleBackColor = false;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1432, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 55);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password : ";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordTxt.Location = new System.Drawing.Point(1442, 280);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(500, 53);
            this.PasswordTxt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(803, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 935);
            this.label8.TabIndex = 17;
            this.label8.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // BadHasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(2050, 977);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OutputDecoderTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputDecodeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CodeCopyBtn);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BadHasher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BadHasher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CodeCopyBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox OutputDecoderTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputDecodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label8;
    }
}

