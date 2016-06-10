using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arv
{
    class FaktaBok : Bok
    {
       
            private string subject;

            public string Subject
            {
                get
                {
                    return subject;
                }
                set
                {
                    subject = value;
                }
            }

            //Konstruktor (constructor) Metod som körs när objektet skapas. Denna körs om det inte finns parametrar.
            public FaktaBok()
            {
            }

            public FaktaBok(string titel, string author, int price, string subject)
            {
                Author = author;
                Titel = titel;
                Price = price;
                Subject = subject;
            }

            public override void skrivUt()
            {
                base.skrivUt();
                Console.WriteLine("Ämne: {0}", Subject);
                Console.WriteLine("");
            }
        }
    
}
