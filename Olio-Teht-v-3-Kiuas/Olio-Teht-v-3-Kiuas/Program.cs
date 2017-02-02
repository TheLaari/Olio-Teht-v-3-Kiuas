using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Teht_v_3_Kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan yksi kiuas-instanssi
            Kiuas helo = new Kiuas();
            helo.malli = "Ringo Black 60 STJ";
            helo.virta = true;
            helo.teho = 6000;
            helo.lämpötila = 0;
            helo.kosteus = 45;

            //näytetään helon tiedot
            helo.PrintData();
            Console.ReadLine();
            //Käännä lisää lämpöä
            helo.Lisäälämpöä();
            //näytä tiedot uudelleen, huomaa lämpötilan nousu (!)
            helo.PrintData();
            Console.ReadLine();

        }
    }
}
