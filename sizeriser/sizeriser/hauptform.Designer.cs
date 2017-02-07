namespace sizeriser
{
    partial class hauptform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hauptform));
            this.BTN_ChooseImage = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.BTN_ChangeImage = new System.Windows.Forms.Button();
            this.PB_Vorschau = new System.Windows.Forms.PictureBox();
            this.TRB_Width = new System.Windows.Forms.TrackBar();
            this.LB_Bildinfo = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Impressum = new System.Windows.Forms.ToolStripMenuItem();
            this.TRB_Datei = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TRB_Seitenverhaeltnis = new System.Windows.Forms.TrackBar();
            this.TRB_Height = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Width = new System.Windows.Forms.TextBox();
            this.TB_Height = new System.Windows.Forms.TextBox();
            this.label_SuccessAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Vorschau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Width)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Datei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Seitenverhaeltnis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Height)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ChooseImage
            // 
            this.BTN_ChooseImage.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ChooseImage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ChooseImage.Location = new System.Drawing.Point(12, 51);
            this.BTN_ChooseImage.Name = "BTN_ChooseImage";
            this.BTN_ChooseImage.Size = new System.Drawing.Size(118, 37);
            this.BTN_ChooseImage.TabIndex = 0;
            this.BTN_ChooseImage.Text = "Choose Image";
            this.BTN_ChooseImage.UseVisualStyleBackColor = false;
            this.BTN_ChooseImage.Click += new System.EventHandler(this.btnPfad_Click);
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(150, 59);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(425, 22);
            this.tbPath.TabIndex = 1;
            this.tbPath.Visible = false;
            // 
            // BTN_ChangeImage
            // 
            this.BTN_ChangeImage.BackColor = System.Drawing.Color.Gainsboro;
            this.BTN_ChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ChangeImage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ChangeImage.Location = new System.Drawing.Point(12, 409);
            this.BTN_ChangeImage.Name = "BTN_ChangeImage";
            this.BTN_ChangeImage.Size = new System.Drawing.Size(118, 37);
            this.BTN_ChangeImage.TabIndex = 2;
            this.BTN_ChangeImage.Text = "Change Image";
            this.BTN_ChangeImage.UseVisualStyleBackColor = false;
            this.BTN_ChangeImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // PB_Vorschau
            // 
            this.PB_Vorschau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Vorschau.Location = new System.Drawing.Point(12, 94);
            this.PB_Vorschau.Name = "PB_Vorschau";
            this.PB_Vorschau.Size = new System.Drawing.Size(400, 225);
            this.PB_Vorschau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Vorschau.TabIndex = 3;
            this.PB_Vorschau.TabStop = false;
            // 
            // TRB_Width
            // 
            this.TRB_Width.Location = new System.Drawing.Point(12, 325);
            this.TRB_Width.Maximum = 19;
            this.TRB_Width.Name = "TRB_Width";
            this.TRB_Width.Size = new System.Drawing.Size(278, 45);
            this.TRB_Width.TabIndex = 4;
            this.TRB_Width.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRB_Width.ValueChanged += new System.EventHandler(this.breite_value_changed);
            // 
            // LB_Bildinfo
            // 
            this.LB_Bildinfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LB_Bildinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Bildinfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Bildinfo.FormattingEnabled = true;
            this.LB_Bildinfo.ItemHeight = 16;
            this.LB_Bildinfo.Location = new System.Drawing.Point(415, 94);
            this.LB_Bildinfo.Margin = new System.Windows.Forms.Padding(0);
            this.LB_Bildinfo.Name = "LB_Bildinfo";
            this.LB_Bildinfo.Size = new System.Drawing.Size(160, 66);
            this.LB_Bildinfo.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Help,
            this.TSMI_Impressum});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(691, 28);
            this.menuStrip.TabIndex = 6;
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(54, 24);
            this.TSMI_Help.Text = "Help";
            this.TSMI_Help.Click += new System.EventHandler(this.TSMI_Help_Click);
            // 
            // TSMI_Impressum
            // 
            this.TSMI_Impressum.Name = "TSMI_Impressum";
            this.TSMI_Impressum.Size = new System.Drawing.Size(66, 24);
            this.TSMI_Impressum.Text = "About";
            this.TSMI_Impressum.Click += new System.EventHandler(this.TSMI_Impressum_Click);
            // 
            // TRB_Datei
            // 
            this.TRB_Datei.Location = new System.Drawing.Point(415, 172);
            this.TRB_Datei.Maximum = 1;
            this.TRB_Datei.Name = "TRB_Datei";
            this.TRB_Datei.Size = new System.Drawing.Size(160, 45);
            this.TRB_Datei.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Create Copy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Use Original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Keep   aspect ratio   Change";
            // 
            // TRB_Seitenverhaeltnis
            // 
            this.TRB_Seitenverhaeltnis.Location = new System.Drawing.Point(415, 230);
            this.TRB_Seitenverhaeltnis.Maximum = 1;
            this.TRB_Seitenverhaeltnis.Name = "TRB_Seitenverhaeltnis";
            this.TRB_Seitenverhaeltnis.Size = new System.Drawing.Size(160, 45);
            this.TRB_Seitenverhaeltnis.TabIndex = 11;
            // 
            // TRB_Height
            // 
            this.TRB_Height.Location = new System.Drawing.Point(296, 325);
            this.TRB_Height.Maximum = 19;
            this.TRB_Height.Name = "TRB_Height";
            this.TRB_Height.Size = new System.Drawing.Size(279, 45);
            this.TRB_Height.TabIndex = 14;
            this.TRB_Height.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRB_Height.ValueChanged += new System.EventHandler(this.hoehe_value_changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "New width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "New height";
            // 
            // TB_Width
            // 
            this.TB_Width.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Width.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Width.Location = new System.Drawing.Point(196, 366);
            this.TB_Width.Name = "TB_Width";
            this.TB_Width.Size = new System.Drawing.Size(94, 22);
            this.TB_Width.TabIndex = 17;
            this.TB_Width.KeyUp += new System.Windows.Forms.KeyEventHandler(this.breite_changed_manuell);
            // 
            // TB_Height
            // 
            this.TB_Height.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Height.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Height.Location = new System.Drawing.Point(481, 366);
            this.TB_Height.Name = "TB_Height";
            this.TB_Height.Size = new System.Drawing.Size(94, 22);
            this.TB_Height.TabIndex = 18;
            this.TB_Height.KeyUp += new System.Windows.Forms.KeyEventHandler(this.height_change_manuell);
            // 
            // label_SuccessAlert
            // 
            this.label_SuccessAlert.AutoSize = true;
            this.label_SuccessAlert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuccessAlert.Location = new System.Drawing.Point(164, 419);
            this.label_SuccessAlert.Name = "label_SuccessAlert";
            this.label_SuccessAlert.Size = new System.Drawing.Size(0, 17);
            this.label_SuccessAlert.TabIndex = 19;
            // 
            // hauptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(691, 472);
            this.Controls.Add(this.label_SuccessAlert);
            this.Controls.Add(this.TB_Height);
            this.Controls.Add(this.TB_Width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TRB_Height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TRB_Seitenverhaeltnis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TRB_Datei);
            this.Controls.Add(this.LB_Bildinfo);
            this.Controls.Add(this.TRB_Width);
            this.Controls.Add(this.PB_Vorschau);
            this.Controls.Add(this.BTN_ChangeImage);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.BTN_ChooseImage);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "hauptform";
            this.Text = "Sizeriser";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Vorschau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Width)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Datei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Seitenverhaeltnis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_Height)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ChooseImage;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button BTN_ChangeImage;
        private System.Windows.Forms.PictureBox PB_Vorschau;
        private System.Windows.Forms.TrackBar TRB_Width;
        private System.Windows.Forms.ListBox LB_Bildinfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Impressum;
        private System.Windows.Forms.TrackBar TRB_Datei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TRB_Seitenverhaeltnis;
        private System.Windows.Forms.TrackBar TRB_Height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Width;
        private System.Windows.Forms.TextBox TB_Height;
        private System.Windows.Forms.Label label_SuccessAlert;
    }
}

