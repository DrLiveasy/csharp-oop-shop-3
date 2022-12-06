using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Shop_3
{
    internal class Acqua : Prodotto
    {

        #region Proprietà
        private double litri;
        private double ph;
        private string sorgente;

        #endregion

        //Stato
        private double MaxLitri = 1.5;

        //Costruttori
       
        public Acqua(string name, string description, double prezzo, double IVA, double litri, double ph, string sorgente) : base(name, description,  prezzo, IVA)
        {
            this.sorgente = sorgente;
            this.litri = litri;
            this.ph = ph;
        }
        //Getters
        public double GetLitri()
        { 
            return litri;
        }
        public double GetPh()
        {
            return ph;
        }
        public string GetSorgente()
        {
            return sorgente;
        }
        public double GetMaxLitri()
        {
            return MaxLitri;
        }
 
        #region METODI PUBBLICI
        public void litriDaBere(double DaBere)
        {
            if (litri >= DaBere)
            {
                this.litri -= DaBere;
                Console.WriteLine("Sono stai bevuti: "+DaBere+" L" + "\nTi mancano: "+ GetLitri() +" L"  );
            }
            else 
            {
                Console.WriteLine("Mi dispaiace i litri richiesti da bere non ci sono");
            }
        }
        public void RiempieLaBottiglia(double daRiempire)
        {
            double LitriRiempiti = litri + daRiempire;

            if (LitriRiempiti <= MaxLitri)
            {
                
               Console.WriteLine("i litri: " + LitriRiempiti);

            }
            else 
            {
           
               
               Console.WriteLine("i litri: " + MaxLitri);
                

            }
        }
        public void svuota()
        {
            litri = 0;  
        }
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine($"litri : {GetLitri()} \n ph: {GetPh()} % \n srogente: {GetSorgente()} ");
        }
        #endregion

    }
}
