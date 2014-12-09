using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINAL
{
    public partial class AjoutJoueur : Form
    {
        public AjoutJoueur()
        {
            InitializeComponent();
        }

        private void AjoutJoueur_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void TXB_Nom_TextChanged(object sender, EventArgs e)
        {
            VerificationChamps();
        }

        private void TXB_Prenom_TextChanged(object sender, EventArgs e)
        {
            VerificationChamps();
        }

        private void TXB_Numero_TextChanged(object sender, EventArgs e)
        {
            VerificationChamps();
        }

        private void VerificationChamps()
        {
            if(TXB_Numero.Text != "" && TXB_Nom.Text != ""  && TXB_Prenom.Text != "")
            {
                BTN_Ajouter.Enabled = true;

            }
            else
            {

                BTN_Ajouter.Enabled = false;
            }



        }

    }
}
