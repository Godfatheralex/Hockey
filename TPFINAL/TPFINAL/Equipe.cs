using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace TPFINAL
{
    public class Equipe
    {
        public string Nom { get; set; }

        public string Ville { get; set; }

        public Image Logo { get; set; }

       public Equipe()
        {
            Nom = "NONAME";
            Ville = "NOCITY";

        }

        public Equipe(string ville, string nom, Image logo)
       {
           Nom = nom;
           Ville = ville;
           Logo = logo;

       }
    }
}
