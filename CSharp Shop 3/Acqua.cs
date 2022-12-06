using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CSharp_Shop_3.Custom_Exception;

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
            if (ph < 0 ||ph > 10)
            {
                throw new NumberOutOfRange("ph", "non si può creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10");
            }
            else
            {
                this.ph = ph;
            }
            
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
                throw new NumberOutOfRange("DaBere", "mi dispiace è finita l'acqua!");
            }
        }
        public void RiempieLaBottiglia(double daRiempire)
        {
            double LitriRiempiti = litri + daRiempire;

            if (LitriRiempiti <= MaxLitri)
            {
               litri += daRiempire;
               Console.WriteLine("i litri: " + this.litri);

            }
            else 
            {
                throw new NumberOutOfRange("daRiempire", "Hai superato la Capienza massima , l'acqua è caduta per terra!");
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
