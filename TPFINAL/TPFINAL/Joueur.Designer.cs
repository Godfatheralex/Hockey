namespace TPFINAL
{
    partial class Joueur
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
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.LBL_Prenom = new System.Windows.Forms.Label();
            this.LBL_Pos = new System.Windows.Forms.Label();
            this.LBL_Date = new System.Windows.Forms.Label();
            this.LBL_NomR = new System.Windows.Forms.Label();
            this.LBL_PrenomR = new System.Windows.Forms.Label();
            this.LBL_PosR = new System.Windows.Forms.Label();
            this.LBL_DateR = new System.Windows.Forms.Label();
            this.LBL_Equipe = new System.Windows.Forms.Label();
            this.TMR_OpacityUp = new System.Windows.Forms.Timer(this.components);
            this.TMR_OpacityDown = new System.Windows.Forms.Timer(this.components);
            this.PBX_LeftArrow = new System.Windows.Forms.PictureBox();
            this.PBX_RightArrow = new System.Windows.Forms.PictureBox();
            this.PNL_Logo = new System.Windows.Forms.Panel();
            this.PBX_Joueur = new System.Windows.Forms.PictureBox();
            this.PNL_Division = new System.Windows.Forms.Panel();
            this.PNL_Shirt = new System.Windows.Forms.Panel();
            this.LBL_Num = new System.Windows.Forms.Label();
            this.LBL_Points = new System.Windows.Forms.Label();
            this.LBL_PointsR = new System.Windows.Forms.Label();
            this.LBL_Buts = new System.Windows.Forms.Label();
            this.LBL_ButsR = new System.Windows.Forms.Label();
            this.LBL_Passes = new System.Windows.Forms.Label();
            this.LBL_PasseR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_LeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_RightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Joueur)).BeginInit();
            this.PNL_Shirt.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ok.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ok.Location = new System.Drawing.Point(145, 432);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(110, 33);
            this.BTN_Ok.TabIndex = 2;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(91, 287);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(35, 15);
            this.LBL_Nom.TabIndex = 4;
            this.LBL_Nom.Text = "Nom:";
            // 
            // LBL_Prenom
            // 
            this.LBL_Prenom.AutoSize = true;
            this.LBL_Prenom.Location = new System.Drawing.Point(91, 311);
            this.LBL_Prenom.Name = "LBL_Prenom";
            this.LBL_Prenom.Size = new System.Drawing.Size(52, 15);
            this.LBL_Prenom.TabIndex = 5;
            this.LBL_Prenom.Text = "Prenom:";
            // 
            // LBL_Pos
            // 
            this.LBL_Pos.AutoSize = true;
            this.LBL_Pos.Location = new System.Drawing.Point(91, 335);
            this.LBL_Pos.Name = "LBL_Pos";
            this.LBL_Pos.Size = new System.Drawing.Size(55, 15);
            this.LBL_Pos.TabIndex = 6;
            this.LBL_Pos.Text = "Position:";
            // 
            // LBL_Date
            // 
            this.LBL_Date.AutoSize = true;
            this.LBL_Date.Location = new System.Drawing.Point(91, 359);
            this.LBL_Date.Name = "LBL_Date";
            this.LBL_Date.Size = new System.Drawing.Size(111, 15);
            this.LBL_Date.TabIndex = 7;
            this.LBL_Date.Text = "Date de Naissance:";
            // 
            // LBL_NomR
            // 
            this.LBL_NomR.AutoSize = true;
            this.LBL_NomR.Location = new System.Drawing.Point(237, 287);
            this.LBL_NomR.Name = "LBL_NomR";
            this.LBL_NomR.Size = new System.Drawing.Size(68, 15);
            this.LBL_NomR.TabIndex = 8;
            this.LBL_NomR.Text = "GALLAGHER";
            // 
            // LBL_PrenomR
            // 
            this.LBL_PrenomR.AutoSize = true;
            this.LBL_PrenomR.Location = new System.Drawing.Point(237, 311);
            this.LBL_PrenomR.Name = "LBL_PrenomR";
            this.LBL_PrenomR.Size = new System.Drawing.Size(58, 15);
            this.LBL_PrenomR.TabIndex = 9;
            this.LBL_PrenomR.Text = "BRENDAN";
            // 
            // LBL_PosR
            // 
            this.LBL_PosR.AutoSize = true;
            this.LBL_PosR.Location = new System.Drawing.Point(237, 335);
            this.LBL_PosR.Name = "LBL_PosR";
            this.LBL_PosR.Size = new System.Drawing.Size(54, 15);
            this.LBL_PosR.TabIndex = 10;
            this.LBL_PosR.Text = "ATTAQUE";
            // 
            // LBL_DateR
            // 
            this.LBL_DateR.AutoSize = true;
            this.LBL_DateR.Location = new System.Drawing.Point(237, 359);
            this.LBL_DateR.Name = "LBL_DateR";
            this.LBL_DateR.Size = new System.Drawing.Size(71, 15);
            this.LBL_DateR.TabIndex = 11;
            this.LBL_DateR.Text = "1992-05-06";
            // 
            // LBL_Equipe
            // 
            this.LBL_Equipe.AutoSize = true;
            this.LBL_Equipe.Location = new System.Drawing.Point(276, 235);
            this.LBL_Equipe.Name = "LBL_Equipe";
            this.LBL_Equipe.Size = new System.Drawing.Size(68, 15);
            this.LBL_Equipe.TabIndex = 13;
            this.LBL_Equipe.Text = "CANADIENS";
            // 
            // TMR_OpacityUp
            // 
            this.TMR_OpacityUp.Interval = 1;
            this.TMR_OpacityUp.Tick += new System.EventHandler(this.TMR_OpacityUp_Tick);
            // 
            // TMR_OpacityDown
            // 
            this.TMR_OpacityDown.Interval = 1;
            this.TMR_OpacityDown.Tick += new System.EventHandler(this.TMR_OpacityDown_Tick);
            // 
            // PBX_LeftArrow
            // 
            this.PBX_LeftArrow.BackgroundImage = global::TPFINAL.Properties.Resources.ArrowLeft;
            this.PBX_LeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBX_LeftArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBX_LeftArrow.Location = new System.Drawing.Point(54, 432);
            this.PBX_LeftArrow.Name = "PBX_LeftArrow";
            this.PBX_LeftArrow.Size = new System.Drawing.Size(63, 24);
            this.PBX_LeftArrow.TabIndex = 15;
            this.PBX_LeftArrow.TabStop = false;
            this.PBX_LeftArrow.Click += new System.EventHandler(this.PBX_LeftArrow_Click);
            this.PBX_LeftArrow.MouseEnter += new System.EventHandler(this.PBX_LeftArrow_MouseEnter);
            this.PBX_LeftArrow.MouseLeave += new System.EventHandler(this.PBX_LeftArrow_MouseLeave);
            // 
            // PBX_RightArrow
            // 
            this.PBX_RightArrow.BackgroundImage = global::TPFINAL.Properties.Resources.ArrowRight;
            this.PBX_RightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBX_RightArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBX_RightArrow.Location = new System.Drawing.Point(277, 433);
            this.PBX_RightArrow.Name = "PBX_RightArrow";
            this.PBX_RightArrow.Size = new System.Drawing.Size(63, 23);
            this.PBX_RightArrow.TabIndex = 14;
            this.PBX_RightArrow.TabStop = false;
            this.PBX_RightArrow.Click += new System.EventHandler(this.PBX_RightArrow_Click);
            this.PBX_RightArrow.MouseEnter += new System.EventHandler(this.PBX_RightArrow_MouseEnter);
            this.PBX_RightArrow.MouseLeave += new System.EventHandler(this.PBX_RightArrow_MouseLeave);
            // 
            // PNL_Logo
            // 
            this.PNL_Logo.BackgroundImage = global::TPFINAL.Properties.Resources.LogoCan;
            this.PNL_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PNL_Logo.Location = new System.Drawing.Point(277, 175);
            this.PNL_Logo.Name = "PNL_Logo";
            this.PNL_Logo.Size = new System.Drawing.Size(65, 45);
            this.PNL_Logo.TabIndex = 12;
            // 
            // PBX_Joueur
            // 
            this.PBX_Joueur.BackgroundImage = global::TPFINAL.Properties.Resources.RandomPlayer;
            this.PBX_Joueur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBX_Joueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_Joueur.Location = new System.Drawing.Point(114, 70);
            this.PBX_Joueur.Name = "PBX_Joueur";
            this.PBX_Joueur.Size = new System.Drawing.Size(154, 205);
            this.PBX_Joueur.TabIndex = 0;
            this.PBX_Joueur.TabStop = false;
            // 
            // PNL_Division
            // 
            this.PNL_Division.BackgroundImage = global::TPFINAL.Properties.Resources.LogoDEst;
            this.PNL_Division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_Division.Location = new System.Drawing.Point(0, 0);
            this.PNL_Division.Name = "PNL_Division";
            this.PNL_Division.Size = new System.Drawing.Size(153, 152);
            this.PNL_Division.TabIndex = 1;
            // 
            // PNL_Shirt
            // 
            this.PNL_Shirt.BackgroundImage = global::TPFINAL.Properties.Resources.BackShirt;
            this.PNL_Shirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_Shirt.Controls.Add(this.LBL_Num);
            this.PNL_Shirt.Location = new System.Drawing.Point(277, 97);
            this.PNL_Shirt.Name = "PNL_Shirt";
            this.PNL_Shirt.Size = new System.Drawing.Size(65, 72);
            this.PNL_Shirt.TabIndex = 3;
            // 
            // LBL_Num
            // 
            this.LBL_Num.AutoSize = true;
            this.LBL_Num.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Num.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_Num.Location = new System.Drawing.Point(22, 27);
            this.LBL_Num.Name = "LBL_Num";
            this.LBL_Num.Size = new System.Drawing.Size(21, 15);
            this.LBL_Num.TabIndex = 8;
            this.LBL_Num.Text = "33";
            // 
            // LBL_Points
            // 
            this.LBL_Points.AutoSize = true;
            this.LBL_Points.Location = new System.Drawing.Point(91, 386);
            this.LBL_Points.Name = "LBL_Points";
            this.LBL_Points.Size = new System.Drawing.Size(45, 15);
            this.LBL_Points.TabIndex = 16;
            this.LBL_Points.Text = "Points:";
            // 
            // LBL_PointsR
            // 
            this.LBL_PointsR.AutoSize = true;
            this.LBL_PointsR.Location = new System.Drawing.Point(142, 386);
            this.LBL_PointsR.Name = "LBL_PointsR";
            this.LBL_PointsR.Size = new System.Drawing.Size(14, 15);
            this.LBL_PointsR.TabIndex = 17;
            this.LBL_PointsR.Text = "0";
            // 
            // LBL_Buts
            // 
            this.LBL_Buts.AutoSize = true;
            this.LBL_Buts.Location = new System.Drawing.Point(162, 386);
            this.LBL_Buts.Name = "LBL_Buts";
            this.LBL_Buts.Size = new System.Drawing.Size(34, 15);
            this.LBL_Buts.TabIndex = 18;
            this.LBL_Buts.Text = "Buts:";
            // 
            // LBL_ButsR
            // 
            this.LBL_ButsR.AutoSize = true;
            this.LBL_ButsR.Location = new System.Drawing.Point(202, 386);
            this.LBL_ButsR.Name = "LBL_ButsR";
            this.LBL_ButsR.Size = new System.Drawing.Size(14, 15);
            this.LBL_ButsR.TabIndex = 19;
            this.LBL_ButsR.Text = "0";
            // 
            // LBL_Passes
            // 
            this.LBL_Passes.AutoSize = true;
            this.LBL_Passes.Location = new System.Drawing.Point(222, 386);
            this.LBL_Passes.Name = "LBL_Passes";
            this.LBL_Passes.Size = new System.Drawing.Size(48, 15);
            this.LBL_Passes.TabIndex = 20;
            this.LBL_Passes.Text = "Passes:";
            // 
            // LBL_PasseR
            // 
            this.LBL_PasseR.AutoSize = true;
            this.LBL_PasseR.Location = new System.Drawing.Point(276, 386);
            this.LBL_PasseR.Name = "LBL_PasseR";
            this.LBL_PasseR.Size = new System.Drawing.Size(14, 15);
            this.LBL_PasseR.TabIndex = 21;
            this.LBL_PasseR.Text = "0";
            // 
            // Joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(373, 477);
            this.Controls.Add(this.LBL_PasseR);
            this.Controls.Add(this.LBL_Passes);
            this.Controls.Add(this.LBL_ButsR);
            this.Controls.Add(this.LBL_Buts);
            this.Controls.Add(this.LBL_PointsR);
            this.Controls.Add(this.LBL_Points);
            this.Controls.Add(this.PBX_LeftArrow);
            this.Controls.Add(this.PBX_RightArrow);
            this.Controls.Add(this.LBL_Equipe);
            this.Controls.Add(this.PNL_Logo);
            this.Controls.Add(this.LBL_DateR);
            this.Controls.Add(this.LBL_PosR);
            this.Controls.Add(this.LBL_PrenomR);
            this.Controls.Add(this.LBL_NomR);
            this.Controls.Add(this.LBL_Date);
            this.Controls.Add(this.LBL_Pos);
            this.Controls.Add(this.LBL_Prenom);
            this.Controls.Add(this.LBL_Nom);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.PBX_Joueur);
            this.Controls.Add(this.PNL_Division);
            this.Controls.Add(this.PNL_Shirt);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Joueur";
            this.Opacity = 0D;
            this.Text = "Fiche Joueur";
            this.Load += new System.EventHandler(this.Joueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_LeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_RightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Joueur)).EndInit();
            this.PNL_Shirt.ResumeLayout(false);
            this.PNL_Shirt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBX_Joueur;
        private System.Windows.Forms.Panel PNL_Division;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Panel PNL_Shirt;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.Label LBL_Prenom;
        private System.Windows.Forms.Label LBL_Pos;
        private System.Windows.Forms.Label LBL_Date;
        private System.Windows.Forms.Label LBL_Num;
        private System.Windows.Forms.Label LBL_NomR;
        private System.Windows.Forms.Label LBL_PrenomR;
        private System.Windows.Forms.Label LBL_PosR;
        private System.Windows.Forms.Label LBL_DateR;
        private System.Windows.Forms.Panel PNL_Logo;
        private System.Windows.Forms.Label LBL_Equipe;
        private System.Windows.Forms.Timer TMR_OpacityUp;
        private System.Windows.Forms.Timer TMR_OpacityDown;
        private System.Windows.Forms.PictureBox PBX_RightArrow;
        private System.Windows.Forms.PictureBox PBX_LeftArrow;
        private System.Windows.Forms.Label LBL_Points;
        private System.Windows.Forms.Label LBL_PointsR;
        private System.Windows.Forms.Label LBL_Buts;
        private System.Windows.Forms.Label LBL_ButsR;
        private System.Windows.Forms.Label LBL_Passes;
        private System.Windows.Forms.Label LBL_PasseR;
    }
}