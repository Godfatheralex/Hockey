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

namespace TPFINAL
{
    public partial class Association : Form
    {

        public Association(Division division)
        {
           
        }


        public Association(DataSet monDataSet2, OracleConnection Oraconn2, Division division)
        {
            InitializeComponent();
            Oraconn = Oraconn2;
            monDataSet = monDataSet2;
            DivisionChoisi = division;

        }

        public OracleConnection Oraconn { get; set; }
        public DataSet monDataSet = new DataSet();
        private OracleDataAdapter Oraliste = new OracleDataAdapter();
        private Division DivisionChoisi { get; set; }

        private void Association_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            ConstructionEquipe();
            if(DivisionChoisi.Num == 1)
            {
                PNL_Division.BackgroundImage = Properties.Resources.LogoDEst;
            }
            else
            {
                PNL_Division.BackgroundImage = Properties.Resources.LogoDOuest;
            }
          
        }
        private void ConstructionEquipe()
        {
            const int marge_Position = 25;
            const int marge_LBL = 150;
            int marge_Haut = 25;
            try
            {
                string sql = "SELECT NOM, VILLE, LOGO, NUMEQUIPE FROM EQUIPES WHERE NUMDIVISION = " + DivisionChoisi.Num;
                OracleCommand oraselect = new OracleCommand(sql, Oraconn);
                oraselect.CommandType = CommandType.Text;
                OracleDataReader OraRead = oraselect.ExecuteReader();
                int compteur = 0;
                while (OraRead.Read())
                {
                    Label Position = new Label();
                    {
                        Position.Name = "LBL_" + (compteur).ToString();
                        Position.Location = new Point(marge_Position, marge_Haut);
                        Position.Text = (compteur + 1).ToString() +"-";
                        PN_Equipe.Controls.Add(Position);
                    }
                    Button BTN = new Button();
                    {
                        BTN.Name = "BTN_" + OraRead.GetInt32(3);
                        BTN.Location = new Point(marge_LBL, marge_Haut -5);
                        BTN.Text = OraRead.GetString(0);
                        BTN.Width = 107;
                        BTN.Height = 30;
                        BTN.Click += new EventHandler(this.BTN_Equipe_Click);
                        PN_Equipe.Controls.Add(BTN);
                    }

                    Button BTNMOD = new Button();
                    {
                        BTNMOD.Name = OraRead.GetString(0) + OraRead.GetInt32(3);
                        BTNMOD.Location = new Point(marge_LBL + 120, marge_Haut - 5);
                        BTNMOD.BackgroundImage = Properties.Resources.Modif;
                        BTNMOD.BackgroundImageLayout = ImageLayout.Stretch;
                        BTNMOD.Width = 30;
                        BTNMOD.Height = 30;
                        BTNMOD.Click += new EventHandler(this.Equipe_BTN_Click);
                        PN_Equipe.Controls.Add(BTNMOD);
                    }
                    compteur++;
                    marge_Haut += 35;

                }
                OraRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        void Equipe_BTN_Click(Object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            String Btn_Name = ClickedButton.Name.Substring(ClickedButton.Name.Length-1, 1);
            AjoutEquipe Aequipe = new AjoutEquipe(Convert.ToInt32(Btn_Name), Oraconn);
            if(Aequipe.ShowDialog() == DialogResult.OK)
            {
                string last = ClickedButton.Name.Substring(ClickedButton.Name.Length -1, 1);
                Button BTN = (Button)PN_Equipe.Controls.Find("BTN_"+ last.ToString(),true)[0];
                string sql = "SELECT NOM, VILLE, LOGO, NUMEQUIPE FROM EQUIPES WHERE NUMDIVISION = " + DivisionChoisi.Num;
                OracleCommand oraselect = new OracleCommand(sql, Oraconn);
                oraselect.CommandType = CommandType.Text;
                OracleDataReader OraRead = oraselect.ExecuteReader();
                if (BTN != null)
                {
                    while (OraRead.Read())
                    {
                        if (OraRead.GetInt32(3) == Convert.ToInt32(last))
                        BTN.Text = OraRead.GetString(0);
                    }
                }
                
            }

           
            
           // MessageBox.Show(ClickedButton.Text);
        }
        private void BTN_AjoutEquipe_Click(object sender, EventArgs e)
        {
            AjoutEquipe Aequipe = new AjoutEquipe();
            
            Aequipe.ShowDialog();
        }

        private void BTN_Equipe_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            String Btn_Name = ClickedButton.Name.Substring(ClickedButton.Name.Length-1, 1);
            FormEquipe FEquipe = new FormEquipe(monDataSet, Oraconn,Convert.ToInt32(Btn_Name));
            FEquipe.ShowDialog();
        }
    }
}
