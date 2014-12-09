namespace TPFINAL
{
    partial class Association
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
            this.PNL_Division = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_AjoutEquipe = new System.Windows.Forms.Button();
            this.PN_Equipe = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Division
            // 
            this.PNL_Division.BackgroundImage = global::TPFINAL.Properties.Resources.LogoDOuest;
            this.PNL_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_Division.Location = new System.Drawing.Point(0, 0);
            this.PNL_Division.Name = "PNL_Division";
            this.PNL_Division.Size = new System.Drawing.Size(211, 202);
            this.PNL_Division.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TPFINAL.Properties.Resources.ClassementAsso;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(115, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_AjoutEquipe
            // 
            this.BTN_AjoutEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AjoutEquipe.Location = new System.Drawing.Point(151, 465);
            this.BTN_AjoutEquipe.Name = "BTN_AjoutEquipe";
            this.BTN_AjoutEquipe.Size = new System.Drawing.Size(136, 37);
            this.BTN_AjoutEquipe.TabIndex = 7;
            this.BTN_AjoutEquipe.Text = "Ajout d\'une Equipe";
            this.BTN_AjoutEquipe.UseVisualStyleBackColor = true;
            this.BTN_AjoutEquipe.Click += new System.EventHandler(this.BTN_AjoutEquipe_Click);
            // 
            // PN_Equipe
            // 
            this.PN_Equipe.AutoScroll = true;
            this.PN_Equipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Equipe.Location = new System.Drawing.Point(43, 256);
            this.PN_Equipe.Name = "PN_Equipe";
            this.PN_Equipe.Size = new System.Drawing.Size(332, 185);
            this.PN_Equipe.TabIndex = 8;
            // 
            // Association
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(412, 511);
            this.Controls.Add(this.PN_Equipe);
            this.Controls.Add(this.BTN_AjoutEquipe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PNL_Division);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Association";
            this.Text = "Association";
            this.Load += new System.EventHandler(this.Association_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Division;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_AjoutEquipe;
        private System.Windows.Forms.Panel PN_Equipe;
    }
}