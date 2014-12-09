using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace TPFINAL
{
    public class Division
    {
        public string Titre { get; set; }
        public int Num { get; set; }
        public DateTime Naissance { get; set; }

        public List<Equipe> equipe { get; set; }

        public Rectangle Border { get; set; }

        public Color ColorRGB { get; set; }
        public Color BColorRGB { get; set; }

        public Boolean Selected { get; set; }

        public Division(string titre)
        {
            Titre = titre;
            Border = new Rectangle(new Point(0, 0), new Size(0, 0));
            equipe = new List<Equipe>();

        }

        public Division()
        {
            Titre = "NONAME";
            Border = new Rectangle(new Point(0, 0), new Size(0, 0));
            equipe = new List<Equipe>();

        }
        public Division(int num, string nom, DateTime naissance)
        {
            Titre = nom;
            Num = num;
            Naissance = naissance;
            Border = new Rectangle(new Point(0, 0), new Size(0, 0));
            equipe = new List<Equipe>();
        }

        public void Draw(Graphics DC)
        {
            SolidBrush fontcolor = new SolidBrush(Color.Black);
            Color NewColor;
            Font font = new Font("Calibri", 10);
            Bitmap image = new Bitmap(Properties.Resources.LogoDBase);

            switch (Titre)
            {
                case "EST":
                    image = new Bitmap(Properties.Resources.LogoDEst);
                    break;

                case "OUEST":
                    image = new Bitmap(Properties.Resources.LogoDOuest);
                    break;

                default:
                    image = new Bitmap(Properties.Resources.LogoDBase);
                    break;
            }


            Rectangle imageBorder = Border;
            imageBorder.Offset(5, 5);
            imageBorder.Width = 150;
            imageBorder.Height = 150;



           


            if (ColorRGB == Color.FromArgb(255, 255, 255))
            {
                NewColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                NewColor = ColorRGB;
            }

            if (Selected)
            {
                DC.FillRectangle(new SolidBrush(Color.Black), Border);
                fontcolor = new SolidBrush(Color.White);
                DC.DrawImage(image, imageBorder);
                DC.DrawString(Titre, font, fontcolor, new PointF(Border.Left - (Titre.Length * 10) + (Border.Width), (Border.Top + 130)));
            }
            else
            {
                DC.FillRectangle(new SolidBrush(NewColor), Border);
                DC.DrawRectangle(new Pen(Color.Black, 1), Border);
                DC.DrawImage(image, imageBorder);
                DC.DrawString(Titre, font, fontcolor, new PointF(Border.Left - (Titre.Length * 10) + (Border.Width), (Border.Top + 130)));
            }
                        
                DC.DrawString(Titre, font, fontcolor, new PointF(Border.Left - (Titre.Length * 10) + (Border.Width) , (Border.Top + 130)));




        }

    }
}
