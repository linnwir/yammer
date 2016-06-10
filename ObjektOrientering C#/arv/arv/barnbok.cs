using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arv
{
    class BarnBok : Bok
    {
        private string age;

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //Konstruktor (constructor) Metod som körs när objektet skapas. Denna körs om det inte finns parametrar.
        public BarnBok() 
        { 
        }

        public BarnBok(string titel, string author, int price, string age)
        {
            Author = author;
            Titel = titel;
            Price = price;
            Age = age;
        }

        /*public override void skrivUt()
        {
            base.skrivUt();
            Console.WriteLine("Ålder: {0}", Age);
            Console.WriteLine("");
        }   */            
    }
}
