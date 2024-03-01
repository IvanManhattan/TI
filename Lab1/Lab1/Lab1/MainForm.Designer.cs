namespace Lab1 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelRadioAlgorithm = new System.Windows.Forms.Panel();
            this.radioButtonVigenere = new System.Windows.Forms.RadioButton();
            this.radioButtonPleifer = new System.Windows.Forms.RadioButton();
            this.buttonAction = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.labelChooseAlgorithm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.labelChooseAction = new System.Windows.Forms.Label();
            this.labelMessages = new System.Windows.Forms.Label();
            this.textBoxKeys = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.PanelRadioAlgorithm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 150);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(463, 318);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(300, 150);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(463, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(463, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // PanelRadioAlgorithm
            // 
            this.PanelRadioAlgorithm.Controls.Add(this.radioButtonVigenere);
            this.PanelRadioAlgorithm.Controls.Add(this.radioButtonPleifer);
            this.PanelRadioAlgorithm.Location = new System.Drawing.Point(46, 92);
            this.PanelRadioAlgorithm.Name = "PanelRadioAlgorithm";
            this.PanelRadioAlgorithm.Size = new System.Drawing.Size(200, 100);
            this.PanelRadioAlgorithm.TabIndex = 4;
            // 
            // radioButtonVigenere
            // 
            this.radioButtonVigenere.Location = new System.Drawing.Point(16, 55);
            this.radioButtonVigenere.Name = "radioButtonVigenere";
            this.radioButtonVigenere.Size = new System.Drawing.Size(115, 30);
            this.radioButtonVigenere.TabIndex = 1;
            this.radioButtonVigenere.TabStop = true;
            this.radioButtonVigenere.Text = "Vigenere";
            this.radioButtonVigenere.UseVisualStyleBackColor = true;
            this.radioButtonVigenere.CheckedChanged += new System.EventHandler(this.radioButtonVigenere_CheckedChanged);
            // 
            // radioButtonPleifer
            // 
            this.radioButtonPleifer.Location = new System.Drawing.Point(16, 25);
            this.radioButtonPleifer.Name = "radioButtonPleifer";
            this.radioButtonPleifer.Size = new System.Drawing.Size(115, 24);
            this.radioButtonPleifer.TabIndex = 0;
            this.radioButtonPleifer.TabStop = true;
            this.radioButtonPleifer.Text = "Pleifer";
            this.radioButtonPleifer.UseVisualStyleBackColor = true;
            this.radioButtonPleifer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(46, 395);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(165, 52);
            this.buttonAction.TabIndex = 5;
            this.buttonAction.Text = "Action!";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Location = new System.Drawing.Point(12, 488);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(751, 22);
            this.textBoxMessages.TabIndex = 6;
            // 
            // labelChooseAlgorithm
            // 
            this.labelChooseAlgorithm.Location = new System.Drawing.Point(46, 66);
            this.labelChooseAlgorithm.Name = "labelChooseAlgorithm";
            this.labelChooseAlgorithm.Size = new System.Drawing.Size(165, 23);
            this.labelChooseAlgorithm.TabIndex = 7;
            this.labelChooseAlgorithm.Text = "Choose algorithm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDecrypt);
            this.panel1.Controls.Add(this.radioButtonEncrypt);
            this.panel1.Location = new System.Drawing.Point(46, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.Location = new System.Drawing.Point(16, 52);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(104, 24);
            this.radioButtonDecrypt.TabIndex = 1;
            this.radioButtonDecrypt.TabStop = true;
            this.radioButtonDecrypt.Text = "Decrypt";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.Location = new System.Drawing.Point(16, 17);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.Size = new System.Drawing.Size(104, 24);
            this.radioButtonEncrypt.TabIndex = 0;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Encrypt";
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            // 
            // labelChooseAction
            // 
            this.labelChooseAction.Location = new System.Drawing.Point(46, 219);
            this.labelChooseAction.Name = "labelChooseAction";
            this.labelChooseAction.Size = new System.Drawing.Size(200, 23);
            this.labelChooseAction.TabIndex = 9;
            this.labelChooseAction.Text = "Choose action";
            // 
            // labelMessages
            // 
            this.labelMessages.Location = new System.Drawing.Point(12, 462);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(128, 23);
            this.labelMessages.TabIndex = 10;
            this.labelMessages.Text = "Messages:";
            // 
            // textBoxKeys
            // 
            this.textBoxKeys.Location = new System.Drawing.Point(463, 234);
            this.textBoxKeys.Name = "textBoxKeys";
            this.textBoxKeys.ReadOnly = true;
            this.textBoxKeys.Size = new System.Drawing.Size(300, 22);
            this.textBoxKeys.TabIndex = 11;
            // 
            // labelKey
            // 
            this.labelKey.Location = new System.Drawing.Point(464, 211);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(299, 23);
            this.labelKey.TabIndex = 12;
            this.labelKey.Text = "Key (Vigenere only)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKeys);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.labelChooseAction);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelChooseAlgorithm);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.PanelRadioAlgorithm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Encryptor";
            this.PanelRadioAlgorithm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxKeys;
        private System.Windows.Forms.Label labelKey;

        private System.Windows.Forms.Label labelMessages;

        private System.Windows.Forms.Label labelChooseAction;
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;

        private System.Windows.Forms.Label labelChooseAlgorithm;

        private System.Windows.Forms.TextBox textBoxMessages;

        private System.Windows.Forms.Button buttonAction;

        private System.Windows.Forms.Panel PanelRadioAlgorithm;
        private System.Windows.Forms.RadioButton radioButtonVigenere;

        private System.Windows.Forms.RadioButton radioButtonPleifer;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}