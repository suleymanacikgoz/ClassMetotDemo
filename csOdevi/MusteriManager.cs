using System;
using System.Collections.Generic;
using System.Text;

namespace csOdevi
{
    class MusteriManager
    {

        public void musteriEkle(Musteri x)
        {


        Console.WriteLine(x.musteriAdi +" müşterisi eklendi." );

            
        }
        public void musteriSil(Musteri x)
        {


            Console.WriteLine(x.musteriAdi + " müşterisi silindi.");


        }
        public void musteriListele(Musteri[] x)
        {


            foreach (var i in x)
            {
                Console.WriteLine(i.musteriAdi);
            }


        }


    }
}
