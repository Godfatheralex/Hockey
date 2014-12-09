namespace TPFINAL
{
    partial class AjoutJoueur
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
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TXB_Numero = new System.Windows.Forms.TextBox();
            this.TXB_Prenom = new System.Windows.Forms.TextBox();
            this.TXB_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ajouter.Location = new System.Drawing.Point(344, 12);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(115, 134);
            this.BTN_Ajouter.TabIndex = 17;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // TXB_Numero
            // 
            this.TXB_Numero.Location = new System.Drawing.Point(177, 87);
            this.TXB_Numero.Name = "TXB_Numero";
            this.TXB_Numero.Size = new System.Drawing.Size(149, 23);
            this.TXB_Numero.TabIndex = 15;
            this.TXB_Numero.TextChanged += new System.EventHandler(this.TXB_Numero_TextChanged);
            // 
            // TXB_Prenom
            // 
            this.TXB_Prenom.Location = new System.Drawing.Point(177, 50);
            this.TXB_Prenom.Name = "TXB_Prenom";
            this.TXB_Prenom.Size = new System.Drawing.Size(149, 23);
            this.TXB_Prenom.TabIndex = 14;
            this.TXB_Prenom.TextChanged += new System.EventHandler(this.TXB_Prenom_TextChanged);
            // 
            // TXB_Nom
            // 
            this.TXB_Nom.Location = new System.Drawing.Point(177, 13);
            this.TXB_Nom.Name = "TXB_Nom";
            this.TXB_Nom.Size = new System.Drawing.Size(149, 23);
            this.TXB_Nom.TabIndex = 13;
            this.TXB_Nom.TextChanged += new System.EventHandler(this.TXB_Nom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date de Naissance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom:";
            // 
            // AjoutJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 166);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TXB_Numero);
            this.Controls.Add(this.TXB_Prenom);
            this.Controls.Add(this.TXB_Nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjoutJoueur";
            this.Text = "Nouveau Joueur:";
            this.Load += new System.EventHandler(this.AjoutJoueur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TXB_Numero;
        private System.Windows.Forms.TextBox TXB_Prenom;
        private System.Windows.Forms.TextBox TXB_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}