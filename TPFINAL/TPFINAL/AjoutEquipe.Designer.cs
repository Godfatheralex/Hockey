namespace TPFINAL
{
    partial class AjoutEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEquipe));
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Equipe = new System.Windows.Forms.TextBox();
            this.TXB_Ville = new System.Windows.Forms.TextBox();
            this.PBX_Logo = new System.Windows.Forms.PictureBox();
            this.TXB_NumEquipe = new System.Windows.Forms.TextBox();
            this.LBL_Date = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.LBL_NumDivision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ajouter.Enabled = false;
            this.BTN_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(157, 203);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(119, 48);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de l\'equipe:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ville de l\'equipe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Logo:";
            // 
            // TXB_Equipe
            // 
            this.TXB_Equipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_Equipe.Location = new System.Drawing.Point(144, 41);
            this.TXB_Equipe.Name = "TXB_Equipe";
            this.TXB_Equipe.Size = new System.Drawing.Size(132, 23);
            this.TXB_Equipe.TabIndex = 4;
            this.TXB_Equipe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXB_Ville
            // 
            this.TXB_Ville.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_Ville.Location = new System.Drawing.Point(144, 70);
            this.TXB_Ville.Name = "TXB_Ville";
            this.TXB_Ville.Size = new System.Drawing.Size(132, 23);
            this.TXB_Ville.TabIndex = 5;
            this.TXB_Ville.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PBX_Logo
            // 
            this.PBX_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBX_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PBX_Logo.ErrorImage")));
            this.PBX_Logo.Location = new System.Drawing.Point(213, 133);
            this.PBX_Logo.Name = "PBX_Logo";
            this.PBX_Logo.Size = new System.Drawing.Size(58, 34);
            this.PBX_Logo.TabIndex = 6;
            this.PBX_Logo.TabStop = false;
            this.PBX_Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TXB_NumEquipe
            // 
            this.TXB_NumEquipe.Enabled = false;
            this.TXB_NumEquipe.Location = new System.Drawing.Point(235, 173);
            this.TXB_NumEquipe.Name = "TXB_NumEquipe";
            this.TXB_NumEquipe.Size = new System.Drawing.Size(36, 23);
            this.TXB_NumEquipe.TabIndex = 7;
            // 
            // LBL_Date
            // 
            this.LBL_Date.AutoSize = true;
            this.LBL_Date.Location = new System.Drawing.Point(29, 105);
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.Size = new System.Drawing.Size(100, 15);
            this.LBL_Date.TabIndex = 8;
            this.LBL_Date.Text = "Date de Creation:";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(144, 99);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(132, 23);
            this.DTP_Date.TabIndex = 9;
            // 
            // LBL_NumDivision
            // 
            this.LBL_NumDivision.AutoSize = true;
            this.LBL_NumDivision.Location = new System.Drawing.Point(87, 181);
            this.LBL_NumDivision.Name = "LBL_NumDivision";
            this.LBL_NumDivision.Size = new System.Drawing.Size(118, 15);
            this.LBL_NumDivision.TabIndex = 10;
            this.LBL_NumDivision.Text = "Numero de Division:";
            // 
            // AjoutEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 263);
            this.Controls.Add(this.LBL_NumDivision);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.LBL_Date);
            this.Controls.Add(this.TXB_NumEquipe);
            this.Controls.Add(this.PBX_Logo);
            this.Controls.Add(this.TXB_Ville);
            this.Controls.Add(this.TXB_Equipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Ajouter);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjoutEquipe";
            this.Text = "Nouvelle Equipe";
            this.Load += new System.EventHandler(this.AjoutEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_Equipe;
        private System.Windows.Forms.TextBox TXB_Ville;
        private System.Windows.Forms.PictureBox PBX_Logo;
        private System.Windows.Forms.TextBox TXB_NumEquipe;
        private System.Windows.Forms.Label LBL_Date;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label LBL_NumDivision;
    }
}