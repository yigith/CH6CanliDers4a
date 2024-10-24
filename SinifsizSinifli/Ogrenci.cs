using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifsizSinifli
{
    // class
    public class Ogrenci
    {
        // field
        private string _unvan = "öğrencimiz";

        // property
        public string Ad { get; set; }

        // property
        public int Yas { get; set; }

        // method
        public void KunyeGoster()
        {
            Console.WriteLine("{0} adlı {2} {1} yaşındadır.", Ad, Yas, _unvan);
        }
    }
}
