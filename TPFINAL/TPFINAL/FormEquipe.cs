using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.IO;

namespace TPFINAL
{
    public partial class FormEquipe : Form
    {
        public FormEquipe()
        {
            InitializeComponent();
        }
        public FormEquipe( DataSet DataSet, OracleConnection Connect, int EquipeChoisi)
        {
            Oraconn = Connect;
            monDataSet = DataSet;
            NumEquipe = EquipeChoisi;
            InitializeComponent();
        }

        public OracleConnection Oraconn { get; set; }
        public DataSet monDataSet = new DataSet();
        private OracleDataAdapter Oraliste = new OracleDataAdapter();
        public int NumEquipe { get; set; }

        private void FormEquipe_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            ConstructeurTop();
            ConstructeurJoueur();
        }
        private void ConstructeurTop()
        {
            try
            {
                LBL_Nom.DataBindings.Clear();
                PBX_Logo.DataBindings.Clear();


                string sql = "SELECT NOM, LOGO FROM EQUIPES WHERE NUMEQUIPE = " + NumEquipe;
                OracleDataAdapter oraListe = new OracleDataAdapter(sql, Oraconn);
                oraListe.Fill(monDataSet, "EquipeChoisi");

                LBL_Nom.DataBindings.Add("Text", monDataSet, "EquipeChoisi.Nom");
                PBX_Logo.DataBindings.Add("image", monDataSet, "EquipeChoisi.Logo", true);
                PBX_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ConstructeurJoueur()
        {
             int marge_Attaquant = 0;
             int marge_Defenseur = 0;
             int marge_Gardien = 0;
            const int marge_LBL = 25;
            const int marge_nom = 75;

            try
            {
                // La Requete !!
                string sql = "SELECT NOM, PRENOM, NUMJOUEUR, PHOTO, POSITION FROM JOUEURS WHERE NUMEQUIPE = " + NumEquipe;
                OracleCommand oraselect = new OracleCommand(sql, Oraconn);
                oraselect.CommandType = CommandType.Text;
                OracleDataReader OraRead = oraselect.ExecuteReader();
                int compteur = 1;


                while (OraRead.Read())
                {
                    Label Position = new Label();
                    {
                        Position.Name = "LBL_" + (compteur).ToString();
                        Position.Text = Convert.ToInt32(compteur) + "-";
                        Position.Size = new Size(20, 32);
                        //PN_Attaquant.Controls.Add(Position);
                    }
                    Label Nom = new Label();
                    {
                        if (OraRead.GetInt32(2).ToString().Length <= 1)
                            Nom.Name = "LBL_" + "0" + OraRead.GetInt32(2);
                        else
                            Nom.Name = "LBL_" + OraRead.GetInt32(2);
                        Nom.Text = OraRead.GetString(0) + "," + OraRead.GetString(1);
                        Nom.Size = new Size((OraRead.GetString(0) + "," + OraRead.GetString(1)).Length * 8, 25);
                        Nom.BorderStyle = BorderStyle.FixedSingle;
                        Nom.Cursor = Cursors.Hand;
                        Nom.Click += new EventHandler(this.Nom_Click);
                        //Nom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    }
                    // Placement dans la bonne section --
                        if (OraRead.GetString(4) == "CENTRE" || OraRead.GetString(4) == "AILIER GAUCHE" || OraRead.GetString(4) == "AILIER DROIT")
                        {
                            Position.Location = new Point(marge_LBL, marge_Attaquant);
                            Nom.Location = new Point(marge_nom, marge_Attaquant);
                            PN_Attaquant.Controls.Add(Nom);
                            PN_Attaquant.Controls.Add(Position);
                            marge_Attaquant+=35;
                        }
                        else if (OraRead.GetString(4) == "DEFENSEUR")
                        {
                            Position.Location = new Point(marge_LBL, marge_Defenseur);
                            Nom.Location = new Point(marge_nom, marge_Defenseur);
                            PN_Defenseur.Controls.Add(Nom);
                            PN_Defenseur.Controls.Add(Position);
                            marge_Defenseur+=35;
                        }
                        else if (OraRead.GetString(4) == "GARDIEN")
                        {
                            Position.Location = new Point(marge_LBL, marge_Gardien);
                            Nom.Location = new Point(marge_nom, marge_Gardien);
                            PN_Gardien.Controls.Add(Nom);
                            PN_Gardien.Controls.Add(Position);
                            marge_Gardien+=35;
                        }
                    
                   
                    compteur++;
                }
                OraRead.Close();

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void Nom_Click(object sender, EventArgs e)
        {
            Label ClickedButton = (Label)sender;
            String Btn_Name = ClickedButton.Name.Substring(ClickedButton.Name.Length - 2, 2);
            Joueur FJoueur = new Joueur(Convert.ToInt32(Btn_Name), Oraconn);
            FJoueur.ShowDialog();
        }
    }
}
