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

namespace TPFINAL
{
    public partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
        
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.035;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            if (this.Opacity >= 0.1)
            {
                this.Opacity -= 0.050;
            }
            else
            {
                timer3.Enabled = false;
                this.Close();
            }
        }

        private void Apropos_Load(object sender, EventArgs e)
        {


            this.CenterToParent();
            PBX_Logo.Top = 207;
            LBL_Description.Left = 357;
            LBL_Titre.Left = 357;
            BTN_Ok.Top = 100;
            this.Opacity = 0.1;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             if(PBX_Logo.Top > 82)
            { PBX_Logo.Top = PBX_Logo.Top - 3; }

          


            if(LBL_Description.Left > 241 )
            {
                LBL_Description.Left = LBL_Description.Left - 3;
                LBL_Titre.Left = LBL_Titre.Left - 3;

            }
            else
            {
                BTN_Ok.Visible = true;

                if (BTN_Ok.Top < 209)
                {
                    BTN_Ok.Top = BTN_Ok.Top + 5;
                }
                else
                {
                    Reflection();
                    timer1.Enabled = false;
                }
            }
            
           
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
             timer3.Enabled = true;
        }
        

        private void Reflection()
        {
            PBX_Logo.Image = DrawReflection(PBX_Logo.Image, Color.White, 150);
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

        private void PBX_Logo_Click(object sender, EventArgs e)
        {

        }

    }
}
