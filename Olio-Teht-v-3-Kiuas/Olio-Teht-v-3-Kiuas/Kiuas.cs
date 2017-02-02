using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_3_Kiuas
{
    class Kiuas
    {
        //ominaisuudet
        public string malli { get; set; }
        public bool virta { get; set; }
        public int teho { get; set; }
        public double lämpötila { get; set; }
        public double kosteus { get; set; }

        //ei erityistä konstruktoria joten käytetään oletusta.

        //tästä napista se menee päälle
        public void Virratpäälle()
        {
            virta = true;
        }
        public void Virratveks()
        {
            virta = false;
        }
        
        //tällä säädetään lämpötilaa
        public void Lisäälämpöä()
        {
            lämpötila += 20;
        }
        public void Vähemmänlämpöä()
        {
            lämpötila -= 20;
        }

        //tällä säädellään kosteutta
        public void Lisääkosteutta()
        {
            kosteus += 5;
        }
        public void Vähemmänkosteutta()
        {
            kosteus -= 5;
        }

        //metodi jolla näytetään kiukaan tiedot
        public void PrintData()
        {
            Console.WriteLine("Kiukaan tiedot : ");
            Console.WriteLine(" - malli : " + malli);
            Console.WriteLine(" - virta : " + virta);
            Console.WriteLine(" - teho : " + teho);
            Console.WriteLine(" - lämpötila : " + lämpötila);
            Console.WriteLine(" - kosteus : " + kosteus);
        }

        //destructor
        ~Kiuas()
        {
            Console.WriteLine("Kiuas-objekti tuhottu.");
        }
    }
}
