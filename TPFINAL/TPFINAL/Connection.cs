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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        public DataSet monDataSet = new DataSet();
        public OracleConnection Oraconn = new OracleConnection();

        private void Connection_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            TXB_User.Text = "Dubealex";
            TXB_Password.Text = "ORACLE1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Dsource ="(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"+
            "(HOST=205.237.244.251)(PORT=1521)))"+ "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";

            string UserId = TXB_User.Text;
            string Password = TXB_Password.Text;

            string ChaineConnection = "Data Source = " + Dsource + ";User Id =" + UserId + "; Password =" + Password;
            string Tab1 = "SELECT * FROM DIVISION";
            string Tab2 = "SELECT * FROM EQUIPES";
            string Tab3 = "SELECT * FROM JOUEURS";

            try
            {
                Oraconn.ConnectionString = ChaineConnection;
                Oraconn.Open();
                OracleDataAdapter oraHockey = new OracleDataAdapter(Tab1, Oraconn);
                oraHockey.Fill(monDataSet, "ListeDivisions");
                oraHockey = new OracleDataAdapter(Tab2, Oraconn);
                oraHockey.Fill(monDataSet, "ListeEquipes");
                oraHockey = new OracleDataAdapter(Tab3, Oraconn);
                oraHockey.Fill(monDataSet, "ListeJoueurs");

                MessageBox.Show(Oraconn.State.ToString());
                //Connection Connect = new Connection();
                //Connect.Adresse = Oraconn;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                BTN_Connect.Enabled = false;
            }
        }

        private void TXB_User_TextChanged(object sender, EventArgs e)
        {
            if (TXB_User.Text != "" && TXB_User.Text != "")
            {
                BTN_Connect.Enabled = true;
            
            }
            else
            {
                BTN_Connect.Enabled = false;
            }
        }

        private void TXB_Password_TextChanged(object sender, EventArgs e)
        {
            if (TXB_User.Text != "" && TXB_User.Text != "")
            {
                BTN_Connect.Enabled = true;

            }
            else
            {
                BTN_Connect.Enabled = false;
            }
        }
    }
}
