using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Oracle.DataAccess.Client;

namespace TPFINAL
{
    public partial class Joueur : Form
    {
        public Joueur(int NumeroJoueur, OracleConnection Connect)
        {
            InitializeComponent();
            NumJoueur = NumeroJoueur;
            Oraconn = Connect;
        }
        private int NumJoueur { get; set; }
        public OracleConnection Oraconn { get; set; }
        //public DataSet monDataSet = new DataSet();
        private OracleDataAdapter Oraliste = new OracleDataAdapter();
        private string NomEquipe;
        private void Joueur_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            this.Opacity = 0.1;
            TMR_OpacityUp.Enabled = true;
            ConstructionJoueur();
            Logo();
            LogoReflection();
        }
        private void ConstructionJoueur()
        {
            string sql = "SELECT JOUEURS.NOM, JOUEURS.PRENOM, JOUEURS.POSITION,JOUEURS.DATE_NAISSANCE, JOUEURS.NUM_MAILLOT, JOUEURS.PHOTO, JOUEURS.NUMJOUEUR, EQUIPES.NOM" +
            " FROM DIVISION" +
            " INNER JOIN EQUIPES ON EQUIPES.NUMDIVISION = DIVISION.NUMDIVISION" +
            " INNER JOIN JOUEURS ON EQUIPES.NUMEQUIPE = JOUEURS.NUMEQUIPE WHERE NUMJOUEUR = " + NumJoueur;
            OracleCommand oraselect = new OracleCommand(sql, Oraconn);
            oraselect.CommandType = CommandType.Text;
            OracleDataReader OraRead = oraselect.ExecuteReader();

            while (OraRead.Read())
            {
                LBL_NomR.Text = OraRead.GetString(0);
                LBL_PrenomR.Text = OraRead.GetString(1);
                LBL_PosR.Text = OraRead.GetString(2);
                LBL_DateR.Text = OraRead.GetDateTime(3).ToString().Substring(0, 10);
                LBL_Num.Text = OraRead.GetInt32(4).ToString();
                NomEquipe = OraRead.GetString(7);
                LBL_Equipe.Text = OraRead.GetString(7);
                string nom = OraRead.GetString(0);
                PBX_Joueur.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(OraRead.GetString(0));

            }
            OraRead.Close();
        }
        private void Logo()
        {
            switch (NomEquipe)
            {
                case "BRUINS":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoBos;
                    break;
                case "AVALANCHE":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoCol;
                    break;
                case "MAPLE LEAF":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoTor;
                    break;
                case "PINGUINS":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoPitt;
                    break;
                case "SHARKS":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoSan;
                    break;
                case "CANADIENS":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoCan;
                    break;
                case "FLAMES":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoCal;
                    break;
                case "KINGS":
                    PNL_Logo.BackgroundImage = Properties.Resources.LogoLA;
                    break;
            }

           
        }

        private void TMR_OpacityUp_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.035;
            }
            else
            {
                TMR_OpacityUp.Enabled = false;
            }
        }

        private void TMR_OpacityDown_Tick(object sender, EventArgs e)
        {
            TMR_OpacityUp.Enabled = false;

            if (this.Opacity >= 0.1)
            {
                this.Opacity -= 0.050;
            }
            else
            {
                TMR_OpacityDown.Enabled = false;
                this.Close();
            }
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            TMR_OpacityDown.Enabled = true;
        }

        private void LogoReflection()
        {
            PNL_Logo.BackgroundImage = DrawReflection(PNL_Logo.BackgroundImage, Color.White, 150);
        }

        public static Image DrawReflection(Image _Image, Color _BackgroundColor, int _Reflectivity)
        {
            // Calculate the size of the new image
            int height = (int)(_Image.Height + (_Image.Height * ((float)_Reflectivity / 255)));
            Bitmap newImage = new Bitmap(_Image.Width, height, PixelFormat.Format24bppRgb);
            newImage.SetResolution(_Image.HorizontalResolution, _Image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                // Initialize main graphics buffer
                graphics.Clear(_BackgroundColor);
                graphics.DrawImage(_Image, new Point(0, 0));
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                Rectangle destinationRectangle = new Rectangle(0, _Image.Size.Height,
                                                 _Image.Size.Width, _Image.Size.Height);

                // Prepare the reflected image
                int reflectionHeight = (_Image.Height * _Reflectivity) / 255;
                Image reflectedImage = new Bitmap(_Image.Width, reflectionHeight);

                // Draw just the reflection on a second graphics buffer
                using (Graphics gReflection = Graphics.FromImage(reflectedImage))
                {
                    gReflection.DrawImage(_Image,
                       new Rectangle(0, 0, reflectedImage.Width, reflectedImage.Height),
                       0, _Image.Height - reflectedImage.Height, reflectedImage.Width,
                       reflectedImage.Height, GraphicsUnit.Pixel);
                }
                reflectedImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Rectangle imageRectangle =
                    new Rectangle(destinationRectangle.X, destinationRectangle.Y,
                    destinationRectangle.Width,
                    (destinationRectangle.Height * _Reflectivity) / 255);

                // Draw the image on the original graphics
                graphics.DrawImage(reflectedImage, imageRectangle);

                // Finish the reflection using a gradiend brush
                LinearGradientBrush brush = new LinearGradientBrush(imageRectangle,
                       Color.FromArgb(255 - _Reflectivity, _BackgroundColor),
                        _BackgroundColor, 90, false);
                graphics.FillRectangle(brush, imageRectangle);
            }

            return newImage;
        }

        private void PBX_RightArrow_MouseEnter(object sender, EventArgs e)
        {
            PBX_RightArrow.Image = Properties.Resources.ArrowRight;
            PBX_RightArrow.BackgroundImage = null;
        }

        private void PBX_RightArrow_MouseLeave(object sender, EventArgs e)
        {
            PBX_RightArrow.Image = null;
            PBX_RightArrow.BackgroundImage = Properties.Resources.ArrowRight;
        }

        private void PBX_LeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void PBX_RightArrow_Click(object sender, EventArgs e)
        {

        }

        private void PBX_LeftArrow_MouseEnter(object sender, EventArgs e)
        {
            PBX_LeftArrow.Image = Properties.Resources.ArrowLeft;
            PBX_LeftArrow.BackgroundImage = null;
        }

        private void PBX_LeftArrow_MouseLeave(object sender, EventArgs e)
        {
            PBX_LeftArrow.Image = null;
            PBX_LeftArrow.BackgroundImage = Properties.Resources.ArrowLeft;
        }
    }
}
