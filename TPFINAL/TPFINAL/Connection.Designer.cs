namespace TPFINAL
{
    partial class Connection
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
            this.LBL_User = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.TXB_User = new System.Windows.Forms.TextBox();
            this.TXB_Password = new System.Windows.Forms.TextBox();
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_User
            // 
            this.LBL_User.AutoSize = true;
            this.LBL_User.Location = new System.Drawing.Point(12, 9);
            this.LBL_User.Name = "LBL_User";
            this.LBL_User.Size = new System.Drawing.Size(87, 13);
            this.LBL_User.TabIndex = 0;
            this.LBL_User.Text = "Nom d\'utilisateur:";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Location = new System.Drawing.Point(12, 32);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(75, 13);
            this.LBL_Password.TabIndex = 1;
            this.LBL_Password.Text = "Mot de Passe:";
            // 
            // TXB_User
            // 
            this.TXB_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_User.Location = new System.Drawing.Point(105, 6);
            this.TXB_User.Name = "TXB_User";
            this.TXB_User.Size = new System.Drawing.Size(118, 20);
            this.TXB_User.TabIndex = 2;
            this.TXB_User.TextChanged += new System.EventHandler(this.TXB_User_TextChanged);
            // 
            // TXB_Password
            // 
            this.TXB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXB_Password.Location = new System.Drawing.Point(105, 29);
            this.TXB_Password.Name = "TXB_Password";
            this.TXB_Password.Size = new System.Drawing.Size(118, 20);
            this.TXB_Password.TabIndex = 3;
            this.TXB_Password.TextChanged += new System.EventHandler(this.TXB_Password_TextChanged);
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Connect.Enabled = false;
            this.BTN_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Connect.Location = new System.Drawing.Point(229, 8);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(103, 40);
            this.BTN_Connect.TabIndex = 4;
            this.BTN_Connect.Text = "Connect";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 60);
            this.Controls.Add(this.BTN_Connect);
            this.Controls.Add(this.TXB_Password);
            this.Controls.Add(this.TXB_User);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Connection";
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_User;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.TextBox TXB_User;
        private System.Windows.Forms.TextBox TXB_Password;
        private System.Windows.Forms.Button BTN_Connect;
    }
}