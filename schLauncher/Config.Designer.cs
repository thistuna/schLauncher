namespace schLauncher
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.labelKiCad = new System.Windows.Forms.Label();
            this.textBoxKiCad = new System.Windows.Forms.TextBox();
            this.labelEagle = new System.Windows.Forms.Label();
            this.textBoxEagle = new System.Windows.Forms.TextBox();
            this.buttonKiCad = new System.Windows.Forms.Button();
            this.buttonEagle = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKiCad
            // 
            this.labelKiCad.AutoSize = true;
            this.labelKiCad.Location = new System.Drawing.Point(13, 13);
            this.labelKiCad.Name = "labelKiCad";
            this.labelKiCad.Size = new System.Drawing.Size(159, 12);
            this.labelKiCad.TabIndex = 0;
            this.labelKiCad.Text = "KiCad Eeschemaの実行ファイル";
            // 
            // textBoxKiCad
            // 
            this.textBoxKiCad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKiCad.Location = new System.Drawing.Point(13, 29);
            this.textBoxKiCad.Name = "textBoxKiCad";
            this.textBoxKiCad.Size = new System.Drawing.Size(438, 19);
            this.textBoxKiCad.TabIndex = 1;
            // 
            // labelEagle
            // 
            this.labelEagle.AutoSize = true;
            this.labelEagle.Location = new System.Drawing.Point(13, 51);
            this.labelEagle.Name = "labelEagle";
            this.labelEagle.Size = new System.Drawing.Size(101, 12);
            this.labelEagle.TabIndex = 2;
            this.labelEagle.Text = "Eagleの実行ファイル";
            // 
            // textBoxEagle
            // 
            this.textBoxEagle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEagle.Location = new System.Drawing.Point(12, 66);
            this.textBoxEagle.Name = "textBoxEagle";
            this.textBoxEagle.Size = new System.Drawing.Size(439, 19);
            this.textBoxEagle.TabIndex = 3;
            // 
            // buttonKiCad
            // 
            this.buttonKiCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKiCad.Location = new System.Drawing.Point(457, 27);
            this.buttonKiCad.Name = "buttonKiCad";
            this.buttonKiCad.Size = new System.Drawing.Size(26, 23);
            this.buttonKiCad.TabIndex = 4;
            this.buttonKiCad.Text = "...";
            this.buttonKiCad.UseVisualStyleBackColor = true;
            this.buttonKiCad.Click += new System.EventHandler(this.buttonKiCad_Click);
            // 
            // buttonEagle
            // 
            this.buttonEagle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEagle.Location = new System.Drawing.Point(457, 64);
            this.buttonEagle.Name = "buttonEagle";
            this.buttonEagle.Size = new System.Drawing.Size(26, 23);
            this.buttonEagle.TabIndex = 5;
            this.buttonEagle.Text = "...";
            this.buttonEagle.UseVisualStyleBackColor = true;
            this.buttonEagle.Click += new System.EventHandler(this.buttonEagle_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(408, 91);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 124);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonEagle);
            this.Controls.Add(this.buttonKiCad);
            this.Controls.Add(this.textBoxEagle);
            this.Controls.Add(this.labelEagle);
            this.Controls.Add(this.textBoxKiCad);
            this.Controls.Add(this.labelKiCad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 163);
            this.MinimumSize = new System.Drawing.Size(16, 163);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKiCad;
        private System.Windows.Forms.TextBox textBoxKiCad;
        private System.Windows.Forms.Label labelEagle;
        private System.Windows.Forms.TextBox textBoxEagle;
        private System.Windows.Forms.Button buttonKiCad;
        private System.Windows.Forms.Button buttonEagle;
        private System.Windows.Forms.Button buttonOK;
    }
}