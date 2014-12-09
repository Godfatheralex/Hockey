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

//http://www15.flamingtext.com/Font-SF-Square-Head-Condensed-Italic



namespace TPFINAL
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
            this.CenterToScreen();
        }

        public DataSet monDataSet = new DataSet();       
        public OracleConnection Oraconn = new OracleConnection();

        Point lastmouseLocation;
        private List<Division> divisions = new List<Division>();
        private List<Equipe> equipes = new List<Equipe>();

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Apropos apropos = new Apropos();
            apropos.ShowDialog();
        }

        private void joueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Joueur joueur = new Joueur(3,Oraconn);
            joueur.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection Connect = new Connection();

            if (Connect.ShowDialog() == DialogResult.OK)
            {
                    Oraconn = Connect.Oraconn;
                    monDataSet = Connect.monDataSet;
            }

            //Requete SQL pour recuperer les Divisions de la BD
            try
            {
                string sql = "SELECT NUMDIVISION,NOM,DATE_CREATION FROM DIVISION";
                OracleCommand oraselect = new OracleCommand(sql, Oraconn);
                oraselect.CommandType = CommandType.Text;
                OracleDataReader OraRead = oraselect.ExecuteReader();

                while (OraRead.Read())
                {

                    Division NewDivision = new Division(OraRead.GetInt32(0), OraRead.GetString(1), OraRead.GetDateTime(2));
                    divisions.Add(NewDivision);



                }

                OraRead.Close();
            }
            catch (Exception exsql1)
            {
                MessageBox.Show(exsql1.Message.ToString());

            }
            int marges = 15;
            Size size = new Size(160, 160);
            Point location = new Point(marges, marges);
            foreach (Division division in divisions)
            {
                division.Border = new Rectangle(location, size);
                location.X += size.Width + marges;
                if ((location.X + size.Width + marges) >= PNL_MainScroll.Width)
                {
                    location.X = marges;
                    location.Y += (size.Height + marges);
                }
            }
            PNL_MainScroll.Height = location.Y + size.Height + marges;

            PNL_MainScroll.Refresh();
            //PNL_Main.Refresh();
        }

        private void associationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Association Asso = new Association(monDataSet,Oraconn, GetSelectedAccount());
            Asso.ShowDialog();
        }

        private void ajoutDivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int marges = 15;
            Size size = new Size(160, 160);
            Point location = new Point(marges, marges);

            Division Est = new Division("Est");
            divisions.Add(Est);

            Equipe Montreal = new Equipe("Montreal", "Canadiens", Properties.Resources.LogoCan);
            Est.equipe.Add(Montreal);
           
            Equipe Boston = new Equipe("Boston", "Bruins", Properties.Resources.LogoBos);
            Est.equipe.Add(Boston);

            //Division Ouest = new Division("Ouest");
            //divisions.Add(Ouest);
            //Equipe Calgary = new Equipe("Calgary", "Flames");
            //Ouest.equipe.Add(Calgary);

           

            foreach (Division division in divisions)
            {
                division.Border = new Rectangle(location, size);
                location.X += size.Width + marges;
                if ((location.X + size.Width + marges) >= PNL_MainScroll.Width)
                {
                    location.X = marges;
                    location.Y += (size.Height + marges);
                }
            }
            PNL_MainScroll.Height = location.Y + size.Height + marges; 
            
            PNL_MainScroll.Refresh();
            //PNL_Main.Refresh();
        }

        private void PNL_MainScroll_Paint(object sender, PaintEventArgs e)
        {
            DrawDivisions(e.Graphics);
        }

        private void DrawDivisions(Graphics DC)
        {
            foreach (Division division in divisions)
            {
                division.Draw(DC);
            }
        }

        private Division GetSelectedAccount()
        {
            Division selectedDivision = null;

            foreach (Division division in divisions)
            {
                if (division.Selected)
                {
                    selectedDivision = division;
                    break;
                }
            }
            return selectedDivision;
        }

        private void ModifySelectedAccount(Division modifications)
        {
            foreach (Division division in divisions)
            {
                if (division.Selected)
                {
                    division.Titre = modifications.Titre;
                    //More here!!!

                    break;
                }
            }
        }

        private void AccountsMouseOverHandler(Point mouseLocation, Graphics DC)
        {

            foreach (Division division in divisions)
            {
                Rectangle overIndicator = division.Border;
                overIndicator.Inflate(5, 5);
                if (!division.Border.Contains(mouseLocation))
                    DC.DrawRectangle(new Pen(PNL_MainScroll.BackColor, 3), overIndicator);
                else
                    DC.DrawRectangle(new Pen(Color.Gray, 3), overIndicator);
            }
        }

        private void PNL_MainScroll_MouseMove(object sender, MouseEventArgs e)
        {
            AccountsMouseOverHandler(e.Location, PNL_MainScroll.CreateGraphics());
        }

        private void AccountsClickHandler(Point mouseLocation)
        {

            foreach (Division division in divisions)
            {
                division.Selected = division.Border.Contains(mouseLocation);
               

            }

            PNL_MainScroll.Refresh();
        }

        private void AccountsRightClickHandler(Point mouseLocation)
        {
            foreach (Division division in divisions)
            {
                if (division.Border.Contains(mouseLocation))
                {
                    division.Selected = true;
                    Point pt = PNL_MainScroll.PointToScreen(mouseLocation);
                    
                }
                else
                {
                    division.Selected = false;
                }
            }
        }

        public void PNL_MainScroll_MouseClick(object sender, MouseEventArgs e)
        {
            AccountsClickHandler(e.Location);
            lastmouseLocation = e.Location;

            if (e.Button == MouseButtons.Right)
            {
                AccountsRightClickHandler(e.Location);

            }

            if(e.Button == MouseButtons.Left)
            {
                Division DivClicker = GetSelectedAccount();

                if (DivClicker.Selected)
                {
                    Association Asso = new Association(monDataSet, Oraconn, DivClicker);
                    Asso.ShowDialog();
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PBX_AjoutDiv.Image = Properties.Resources.AjoutDivision_Hover__2_;
            PBX_AjoutDiv.BackgroundImage = null;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PBX_AjoutDiv.Image = Properties.Resources.AjoutDivisionNormal;
            PBX_AjoutDiv.BackgroundImage = null;
        }

        private void PBX_AjoutDiv_Click(object sender, EventArgs e)
        {
            int marges = 15;
            Size size = new Size(160, 160);
            Point location = new Point(marges, marges);

            Division Est = new Division("Est");
            divisions.Add(Est);

            Equipe Montreal = new Equipe("Montreal", "Canadiens", Properties.Resources.LogoCan);
            Est.equipe.Add(Montreal);
           
            Equipe Boston = new Equipe("Boston", "Bruins", Properties.Resources.LogoBos);
            Est.equipe.Add(Boston);

            //Division Ouest = new Division("Ouest");
            //divisions.Add(Ouest);
            //Equipe Calgary = new Equipe("Calgary", "Flames");
            //Ouest.equipe.Add(Calgary);

           

            foreach (Division division in divisions)
            {
                division.Border = new Rectangle(location, size);
                location.X += size.Width + marges;
                if ((location.X + size.Width + marges) >= PNL_MainScroll.Width)
                {
                    location.X = marges;
                    location.Y += (size.Height + marges);
                }
            }
            PNL_MainScroll.Height = location.Y + size.Height + marges; 
            
            PNL_MainScroll.Refresh();
            //PNL_Main.Refresh();
        }

        private void PBX_AjoutDiv_MouseDown(object sender, MouseEventArgs e)
        {
            PBX_AjoutDiv.Image = Properties.Resources.AjoutDivisionClick;
        }

        private void PBX_AjoutDiv_MouseUp(object sender, MouseEventArgs e)
        {
            PBX_AjoutDiv.Image = Properties.Resources.AjoutDivision_Hover__2_;
        }
        


    }
}
