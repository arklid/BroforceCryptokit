namespace BroforceCryptokit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.labelBaeckstrom = new System.Windows.Forms.Label();
            this.textBoxSteamID = new System.Windows.Forms.TextBox();
            this.labelSteamID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(133, 51);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(200, 76);
            this.buttonDecrypt.TabIndex = 0;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(133, 133);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(200, 78);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxB.Image")));
            this.pictureBoxB.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxB.InitialImage")));
            this.pictureBoxB.Location = new System.Drawing.Point(12, 26);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(115, 189);
            this.pictureBoxB.TabIndex = 2;
            this.pictureBoxB.TabStop = false;
            this.pictureBoxB.Click += new System.EventHandler(this.pictureBoxB_Click);
            // 
            // labelBaeckstrom
            // 
            this.labelBaeckstrom.AutoSize = true;
            this.labelBaeckstrom.Location = new System.Drawing.Point(179, 224);
            this.labelBaeckstrom.Name = "labelBaeckstrom";
            this.labelBaeckstrom.Size = new System.Drawing.Size(112, 13);
            this.labelBaeckstrom.TabIndex = 3;
            this.labelBaeckstrom.Text = "www.baeckstrom.com";
            // 
            // textBoxSteamID
            // 
            this.textBoxSteamID.Location = new System.Drawing.Point(133, 23);
            this.textBoxSteamID.Name = "textBoxSteamID";
            this.textBoxSteamID.Size = new System.Drawing.Size(200, 20);
            this.textBoxSteamID.TabIndex = 4;
            this.textBoxSteamID.Text = "brololforce";
            // 
            // labelSteamID
            // 
            this.labelSteamID.AutoSize = true;
            this.labelSteamID.Location = new System.Drawing.Point(132, 8);
            this.labelSteamID.Name = "labelSteamID";
            this.labelSteamID.Size = new System.Drawing.Size(51, 13);
            this.labelSteamID.TabIndex = 5;
            this.labelSteamID.Text = "Steam ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 245);
            this.Controls.Add(this.labelSteamID);
            this.Controls.Add(this.textBoxSteamID);
            this.Controls.Add(this.labelBaeckstrom);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonDecrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Broforce Cryptokit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.Label labelBaeckstrom;
        private System.Windows.Forms.TextBox textBoxSteamID;
        private System.Windows.Forms.Label labelSteamID;
    }
}

