namespace TPFINAL
{
    partial class FormEquipe
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
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.PN_Attaquant = new System.Windows.Forms.Panel();
            this.PN_Defenseur = new System.Windows.Forms.Panel();
            this.PN_Gardien = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PBX_Logo
            // 
            this.PBX_Logo.Location = new System.Drawing.Point(249, 12);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(154, 70);
            this.PBX_Logo.TabIndex = 14;
            this.PBX_Logo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(25, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(25, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(25, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 1);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gardien:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Defenseurs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Attaquants:";
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(22, 38);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(75, 15);
            this.LBL_Nom.TabIndex = 7;
            this.LBL_Nom.Text = "NOMEQUIPE";
            // 
            // PN_Attaquant
            // 
            this.PN_Attaquant.AutoScroll = true;
            this.PN_Attaquant.Location = new System.Drawing.Point(25, 123);
            this.PN_Attaquant.Name = "PN_Attaquant";
            this.PN_Attaquant.Size = new System.Drawing.Size(378, 97);
            this.PN_Attaquant.TabIndex = 15;
            // 
            // PN_Defenseur
            // 
            this.PN_Defenseur.AutoScroll = true;
            this.PN_Defenseur.Location = new System.Drawing.Point(25, 252);
            this.PN_Defenseur.Name = "PN_Defenseur";
            this.PN_Defenseur.Size = new System.Drawing.Size(378, 67);
            this.PN_Defenseur.TabIndex = 16;
            // 
            // PN_Gardien
            // 
            this.PN_Gardien.AutoScroll = true;
            this.PN_Gardien.Location = new System.Drawing.Point(25, 350);
            this.PN_Gardien.Name = "PN_Gardien";
            this.PN_Gardien.Size = new System.Drawing.Size(378, 63);
            this.PN_Gardien.TabIndex = 17;
            // 
            // FormEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 425);
            this.Controls.Add(this.PN_Gardien);
            this.Controls.Add(this.PN_Defenseur);
            this.Controls.Add(this.PN_Attaquant);
            this.Controls.Add(this.PBX_Logo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Nom);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormEquipe";
            this.Text = "FormEquipe";
            this.Load += new System.EventHandler(this.FormEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBX_Logo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.Panel PN_Attaquant;
        private System.Windows.Forms.Panel PN_Defenseur;
        private System.Windows.Forms.Panel PN_Gardien;
    }
}