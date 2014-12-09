namespace TPFINAL
{
    partial class Apropos
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.LBL_Titre = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // LBL_Titre
            // 
            this.LBL_Titre.AutoSize = true;
            this.LBL_Titre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titre.Location = new System.Drawing.Point(240, 41);
            this.LBL_Titre.Name = "LBL_Titre";
            this.LBL_Titre.Size = new System.Drawing.Size(113, 26);
            this.LBL_Titre.TabIndex = 0;
            this.LBL_Titre.Text = "Hockey Plus";
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Description.Location = new System.Drawing.Point(241, 82);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.LBL_Description.Size = new System.Drawing.Size(275, 75);
            this.LBL_Description.TabIndex = 1;
            this.LBL_Description.Text = "Auteurs: Alexandre Dubé - Yvon Steinthal\r\nVersion: 0.1\r\nDevelloppement d\'interfac" +
    "e\r\nBase de données\r\nProf: N.Chourot et S.Yacoub";
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ok.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.Location = new System.Drawing.Point(371, 209);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(143, 47);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // PBX_Logo
            // 
            this.PBX_Logo.Image = global::TPFINAL.Properties.Resources.LogoHP3;
            this.PBX_Logo.Location = new System.Drawing.Point(36, 82);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(172, 84);
            this.PBX_Logo.TabIndex = 2;
            this.PBX_Logo.TabStop = false;
            this.PBX_Logo.Click += new System.EventHandler(this.PBX_Logo_Click);
            // 
            // Apropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(529, 268);
            this.Controls.Add(this.PBX_Logo);
            this.Controls.Add(this.LBL_Description);
            this.Controls.Add(this.LBL_Titre);
            this.Controls.Add(this.BTN_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Apropos";
            this.Opacity = 0D;
            this.Text = "A propos...";
            this.Load += new System.EventHandler(this.Apropos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label LBL_Titre;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.PictureBox PBX_Logo;
        private System.Windows.Forms.Button BTN_Ok;
    }
}