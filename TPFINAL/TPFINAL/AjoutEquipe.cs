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
    public partial class AjoutEquipe : Form
    {
        public AjoutEquipe()
        {
            InitializeComponent();
            New = true;


        }
        public AjoutEquipe(int Num, OracleConnection OraConnect)
        {
            InitializeComponent();
            numEquipe = Num;
            Oraconn = OraConnect;
            Lister();
             
        }
        public int numEquipe { get; set; }
        public DataSet monDataSet = new DataSet();
        private OracleDataAdapter Oraliste = new OracleDataAdapter();
        public OracleConnection Oraconn { get; set; }
        string nomFichier;
        bool New = false;
        private void Lister()
        {
            string sqlEquipe = "SELECT NOM, VILLE, LOGO, NUMEQUIPE, DATE_INTRODUCTION FROM EQUIPEs WHERE NUMEQUIPE = " + numEquipe ;
            OracleDataAdapter oraListe = new OracleDataAdapter(sqlEquipe, Oraconn);
            oraListe.Fill(monDataSet, "EquipeChoisi");

            try
            {
                TXB_Equipe.DataBindings.Add("Text", monDataSet, "EquipeChoisi.NOM");
                TXB_Ville.DataBindings.Add("Text", monDataSet, "EquipeChoisi.VILLE");
                PBX_Logo.DataBindings.Add("image", monDataSet, "EquipeChoisi.LOGO", true);
                TXB_NumEquipe.DataBindings.Add("Text", monDataSet, "EquipeChoisi.NUMEQUIPE");
                DTP_Date.DataBindings.Add("Text", monDataSet, "EquipeChoisi.DATE_INTRODUCTION");
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VerificationChamps();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            VerificationChamps();
        }

        private void VerificationChamps()
        {
            if (TXB_Equipe.Text != "" && TXB_Ville.Text != "")
            {
                BTN_Ajouter.Enabled = true;

            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }

        }
        // ------------Début Traitement de l'image: Chercher un fichier image
        private string RechercherFichier()
        {
            OpenFileDialog fImage = new OpenFileDialog();
            fImage.Title = "sélectionner une image";
            fImage.CheckFileExists = true;
            fImage.InitialDirectory = @":C\";
            //fImage.InitialDirectory = Application.StartupPath;
            fImage.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            fImage.FilterIndex = 1;
            fImage.RestoreDirectory = true;
            if (fImage.ShowDialog() == DialogResult.OK)
            {
                nomFichier = fImage.FileName;
                Bitmap bitmap1 = new Bitmap(nomFichier);
            }
            else
            {
                nomFichier = null;
            }
            return nomFichier;
        } //--------------------------Fin Rechercher Fichier ----------------------------.


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nomFichier = RechercherFichier();

            if (nomFichier != null)
            {
                PBX_Logo.Image = System.Drawing.Image.FromFile(nomFichier);
                PBX_Logo.ImageLocation = nomFichier;
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AjoutEquipe_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            if(New)
            {

            }
            else
            UpdateEquipe();
        }
        private void NewEquipe()
        {
            string SQLNew = "INSERT INTO EQUIPES (NUMEQUIPE, NOM, DATE_INTRODUCTION, NUMDIVISION, VILLE) VALUES(SEQ_EQUIPE.NEXTVAL,'" + TXB_Equipe.Text + "','";
        }
        private void UpdateEquipe()
        {
            string sqlUpdate = "UPDATE EQUIPES SET NOM = :nom, VILLE = :ville, LOGO = :logo WHERE NUMEQUIPE = " + TXB_NumEquipe.Text;
            OracleParameter oranom = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
            OracleParameter oraville = new OracleParameter(":ville", OracleDbType.Varchar2, 30);
            OracleParameter oraphoto = new OracleParameter(":photo", OracleDbType.Blob);

            oranom.Value = TXB_Equipe.Text;
            oraville.Value = TXB_Ville.Text;

            FileStream Streamp = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
            byte[] buffer1 = new byte[Streamp.Length];
            Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
            Streamp.Close();
            // ajout de la photo dans la BD.
            oraphoto.Value = buffer1;
            OracleCommand oraAjout = new OracleCommand(sqlUpdate, Oraconn);
            oraAjout.CommandType = CommandType.Text;

            oraAjout.Parameters.Add(oranom);
            oraAjout.Parameters.Add(oraville);
            oraAjout.Parameters.Add(oraphoto);

            oraAjout.ExecuteNonQuery();
        }
    }
}
