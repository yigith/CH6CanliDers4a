using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAciklama
{
    // ÖNCE PROPERTY KULLANMADAN YAPALIM
    public class Calisan
    {
        public string Ad;
        public int Yas;

        public void KunyeYazdir()
        {
            Console.WriteLine("{0} adlı çalışan {1} yaşındadır.", Ad, Yas);
        }
    }
}
