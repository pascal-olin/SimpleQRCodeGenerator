namespace SimpleQRCodeGenerator
{
    partial class SercoQRCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SercoQRCodeGenerator));
            this.SourceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.wifiSSID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wifiPassword = new System.Windows.Forms.TextBox();
            this.listOfSSIDs = new System.Windows.Forms.ListBox();
            this.getSSIDs = new System.Windows.Forms.Button();
            this.listOFPasswords = new System.Windows.Forms.ListBox();
            this.listOfAuths = new System.Windows.Forms.ListBox();
            this.wifiAuth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveToSettings = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceText
            // 
            this.SourceText.Location = new System.Drawing.Point(127, 65);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(612, 26);
            this.SourceText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter ANY Text/URL below and press Generate ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 94);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate QRCode and  then click on the image to save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fit Code to Size (smaller)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wifiSSID
            // 
            this.wifiSSID.Location = new System.Drawing.Point(127, 138);
            this.wifiSSID.Name = "wifiSSID";
            this.wifiSSID.Size = new System.Drawing.Size(285, 26);
            this.wifiSSID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wifi  SSID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wifi  Password";
            // 
            // wifiPassword
            // 
            this.wifiPassword.Location = new System.Drawing.Point(127, 170);
            this.wifiPassword.Name = "wifiPassword";
            this.wifiPassword.Size = new System.Drawing.Size(285, 26);
            this.wifiPassword.TabIndex = 7;
            // 
            // listOfSSIDs
            // 
            this.listOfSSIDs.FormattingEnabled = true;
            this.listOfSSIDs.ItemHeight = 20;
            this.listOfSSIDs.Location = new System.Drawing.Point(776, 138);
            this.listOfSSIDs.Name = "listOfSSIDs";
            this.listOfSSIDs.Size = new System.Drawing.Size(247, 424);
            this.listOfSSIDs.TabIndex = 10;
            this.listOfSSIDs.Click += new System.EventHandler(this.listOfSSIDs_Click);
            this.listOfSSIDs.SelectedIndexChanged += new System.EventHandler(this.listOfSSIDs_SelectedIndexChanged);
            this.listOfSSIDs.DoubleClick += new System.EventHandler(this.listOfSSIDs_DoubleClick);
            // 
            // getSSIDs
            // 
            this.getSSIDs.Location = new System.Drawing.Point(776, 102);
            this.getSSIDs.Name = "getSSIDs";
            this.getSSIDs.Size = new System.Drawing.Size(247, 30);
            this.getSSIDs.TabIndex = 11;
            this.getSSIDs.Text = "Get and store known networks";
            this.getSSIDs.UseVisualStyleBackColor = true;
            this.getSSIDs.Click += new System.EventHandler(this.getSSIDs_Click);
            // 
            // listOFPasswords
            // 
            this.listOFPasswords.FormattingEnabled = true;
            this.listOFPasswords.ItemHeight = 20;
            this.listOFPasswords.Location = new System.Drawing.Point(868, 396);
            this.listOFPasswords.Name = "listOFPasswords";
            this.listOFPasswords.Size = new System.Drawing.Size(247, 324);
            this.listOFPasswords.TabIndex = 12;
            this.listOFPasswords.Visible = false;
            // 
            // listOfAuths
            // 
            this.listOfAuths.FormattingEnabled = true;
            this.listOfAuths.ItemHeight = 20;
            this.listOfAuths.Location = new System.Drawing.Point(831, 318);
            this.listOfAuths.Name = "listOfAuths";
            this.listOfAuths.Size = new System.Drawing.Size(247, 324);
            this.listOfAuths.TabIndex = 13;
            this.listOfAuths.Visible = false;
            // 
            // wifiAuth
            // 
            this.wifiAuth.Location = new System.Drawing.Point(440, 167);
            this.wifiAuth.Name = "wifiAuth";
            this.wifiAuth.Size = new System.Drawing.Size(120, 26);
            this.wifiAuth.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Auth(WPA,WPA2,WEP)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Or select a SSID to publish as QR code in the list and press Generate";
            // 
            // saveToSettings
            // 
            this.saveToSettings.Location = new System.Drawing.Point(776, 568);
            this.saveToSettings.Name = "saveToSettings";
            this.saveToSettings.Size = new System.Drawing.Size(247, 30);
            this.saveToSettings.TabIndex = 17;
            this.saveToSettings.Text = "Save ALL SSIDs to Settings";
            this.saveToSettings.UseVisualStyleBackColor = true;
            this.saveToSettings.Click += new System.EventHandler(this.saveToSettings_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(776, 595);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Empty Settings of ALL SSIDs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Double click to remove one entry->";
            // 
            // SercoQRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 637);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveToSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wifiAuth);
            this.Controls.Add(this.listOfAuths);
            this.Controls.Add(this.listOFPasswords);
            this.Controls.Add(this.getSSIDs);
            this.Controls.Add(this.listOfSSIDs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wifiPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wifiSSID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SercoQRCodeGenerator";
            this.Text = "SercoQRCodeGenerator";
            this.Load += new System.EventHandler(this.SercoQRCodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox wifiSSID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wifiPassword;
        private System.Windows.Forms.ListBox listOfSSIDs;
        private System.Windows.Forms.Button getSSIDs;
        private System.Windows.Forms.ListBox listOFPasswords;
        private System.Windows.Forms.ListBox listOfAuths;
        private System.Windows.Forms.TextBox wifiAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveToSettings;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
    }
}

