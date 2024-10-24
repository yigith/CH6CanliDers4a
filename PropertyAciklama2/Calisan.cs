using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAciklama2
{
    public class Calisan
    {
        // auto-property
        public string Ad { get; set; }


        #region full property
        //private string _ad;

        //public string Ad
        //{
        //    get { return _ad; }
        //    set { _ad = value; }
        //} 
        #endregion

        private int _yas;
        public int Yas
        {
            get 
            { 
                return _yas; 
            }
            set
            {
                // gelen değer sıfırdan küçükse
                if (value < 0)
                    throw new Exception("Yaş negatif olamaz!");

                _yas = value;
            }
        }

        public void KunyeYazdir()
        {
            Console.WriteLine($"{Ad} adlı çalışan {Yas} yaşındadır.");
        }
    }
}


/*
 * 
 * prop [TAB] => AUTO PROPERTY
 * fullprop [TAB] => FULL PROPERTY
 */