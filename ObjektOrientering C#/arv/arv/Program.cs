using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Bok EnBok = new Bok("Liftarens guide till galaxen", "Douglas Adams", 400);

            BarnBok enBarnBok = new BarnBok("Mio min Mio", "Astrid Lindgren", 700, "7 - 15 år");
            BarnBok nyBarnBarnbok = new BarnBok();
            nyBarnBarnbok.Author = "Kalle";


            FaktaBok enFaktaBok = new FaktaBok("Programmering i Java", "Nils Lindgren", 1200, "IT");
                    
           
           // EnBok.skrivUt();
            enBarnBok.skrivUt();
            //enFaktaBok.skrivUt();
               
            

            //För att förhindra att fönster stängs.
             Console.ReadLine();
        }

    }
}
