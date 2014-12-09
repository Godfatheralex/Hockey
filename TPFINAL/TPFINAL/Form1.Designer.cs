namespace TPFINAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MNU_Strip = new System.Windows.Forms.MenuStrip();
            this.AproposMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_MainScroll = new System.Windows.Forms.Panel();
            this.PNL_Scroll = new System.Windows.Forms.Panel();
            this.PBX_AjoutDiv = new System.Windows.Forms.PictureBox();
            this.MNU_Strip.SuspendLayout();
            this.PNL_Scroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_AjoutDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // MNU_Strip
            // 
            this.MNU_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AproposMenuItem});
            this.MNU_Strip.Location = new System.Drawing.Point(0, 0);
            this.MNU_Strip.Name = "MNU_Strip";
            this.MNU_Strip.Size = new System.Drawing.Size(435, 24);
            this.MNU_Strip.TabIndex = 0;
            this.MNU_Strip.Text = "menuStrip1";
            // 
            // AproposMenuItem
            // 
            this.AproposMenuItem.Name = "AproposMenuItem";
            this.AproposMenuItem.Size = new System.Drawing.Size(24, 20);
            this.AproposMenuItem.Text = "?";
            this.AproposMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // PNL_MainScroll
            // 
            this.PNL_MainScroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_MainScroll.Location = new System.Drawing.Point(3, 3);
            this.PNL_MainScroll.Name = "PNL_MainScroll";
            this.PNL_MainScroll.Size = new System.Drawing.Size(395, 64);
            this.PNL_MainScroll.TabIndex = 1;
            this.PNL_MainScroll.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_MainScroll_Paint);
            this.PNL_MainScroll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PNL_MainScroll_MouseClick);
            this.PNL_MainScroll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_MainScroll_MouseMove);
            // 
            // PNL_Scroll
            // 
            this.PNL_Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Scroll.AutoScroll = true;
            this.PNL_Scroll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PNL_Scroll.Controls.Add(this.PNL_MainScroll);
            this.PNL_Scroll.Location = new System.Drawing.Point(12, 71);
            this.PNL_Scroll.Name = "PNL_Scroll";
            this.PNL_Scroll.Size = new System.Drawing.Size(423, 398);
            this.PNL_Scroll.TabIndex = 2;
            // 
            // PBX_AjoutDiv
            // 
            this.PBX_AjoutDiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBX_AjoutDiv.BackgroundImage")));
            this.PBX_AjoutDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBX_AjoutDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_AjoutDiv.Location = new System.Drawing.Point(133, 24);
            this.PBX_AjoutDiv.Name = "PBX_AjoutDiv";
            this.PBX_AjoutDiv.Size = new System.Drawing.Size(182, 41);
            this.PBX_AjoutDiv.TabIndex = 3;
            this.PBX_AjoutDiv.TabStop = false;
            this.PBX_AjoutDiv.Click += new System.EventHandler(this.PBX_AjoutDiv_Click);
            this.PBX_AjoutDiv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBX_AjoutDiv_MouseDown);
            this.PBX_AjoutDiv.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.PBX_AjoutDiv.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.PBX_AjoutDiv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBX_AjoutDiv_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 481);
            this.Controls.Add(this.PBX_AjoutDiv);
            this.Controls.Add(this.PNL_Scroll);
            this.Controls.Add(this.MNU_Strip);
            this.MainMenuStrip = this.MNU_Strip;
            this.MinimumSize = new System.Drawing.Size(427, 476);
            this.Name = "Form1";
            this.Text = "HockeyPlus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MNU_Strip.ResumeLayout(false);
            this.MNU_Strip.PerformLayout();
            this.PNL_Scroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_AjoutDiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MNU_Strip;
        private System.Windows.Forms.ToolStripMenuItem AproposMenuItem;
        private System.Windows.Forms.Panel PNL_MainScroll;
        private System.Windows.Forms.Panel PNL_Scroll;
        private System.Windows.Forms.PictureBox PBX_AjoutDiv;
    }
}

