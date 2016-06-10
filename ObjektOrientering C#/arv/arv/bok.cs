using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arv
{
   
    class Bok
    {
        private string titel;
        private string author;
        private int price;

       
        //egenskaper (properties). Används för att förhindra åtkomst till privata variabler.
        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                titel = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


        //Konstruktor (constructor) Metod som körs när objektet skapas. Denna körs om det inte finns parametrar.
        public Bok() 
        { 
        }

        //Konstruktor med parametrar
        public Bok (string titel, string author, int price)
        {
            Author = author;
            Titel = titel;
            Price = price;
        }

        //Metod som skriver ut våra variabler.
        public virtual void skrivUt()
        {
            Console.WriteLine("\nFörfattare: {0}", Author);
            Console.WriteLine("Titel: {0}", Titel);
            Console.WriteLine("Pris: {0}", Price);
            
        }
    }       
}
