using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3.Metodi_Staici
{
    public static class convertiInGalloni
    {
        public static readonly double GalloneALitro = 3.785;

        public static double convertiLitriInGalloni(string litriDaConvertire)
        {
            
            double Litri = double.Parse(litriDaConvertire);
            double Galloni = Litri * GalloneALitro;

            return Galloni;

        }
    }
}
