using PriceCalc.AddOn;
using PriceCalc.Fare;
using PriceCalc.Printing;

// ReSharper disable CommentTypo

namespace PriceCalc
{
    class Program
    {
        static void Main()
        {
            /*
             Utbud:
                 Två olika rutter:
                  - Gothenburg - Kiel      1000kr
                  - Karlskrona - Gdynia    2000kr
                 
                 Tillval:
                  - Breakfast Buffet       +150kr
                  - Pet                    +300kr per djur (kan läggas till flera gånger)
                  - Champagne              +400kr (kan läggas till flera gånger)
                  - SpaAccess              +350kr (kan läggas till flera gånger)
                  - Flexi                  +10% på själva ruttens pris, påverkar ej priset på övriga tillval
                  - All-inclusive          +800 kr om själva ruttens pris under 1500kr
                                           +1200kr om själva ruttens pris mellan 1500kr och 2500kr

             Exempel:
                 Gothenburg - Kiel         
                 + Breakfast buffet        
                 + Pet                     
                 + Pet                     
                 + Champagne               
                 + Flexi           
                 + All-inclusive
                 Totalt: 3050kr

             Exempel:
                 Karlskrona - Gdynia       
                 + Breakfast buffet        
                 + Champagne               
                 + Champagne               
                 + SpaAccess               
                 + SpaAccess    
                 + All-inclusive
                 Totalt: 4850kr
            */

            CalculateAndPrint();
        }

        private static void CalculateAndPrint()
        {
            Product first = new GothenburgKiel();
            first = new BreakfastBuffet(first);
            first = new Pet(first);
            first = new Pet(first);
            first = new Champagne(first);
            first = new Flexi(first);
            first = new AllInclusive(first);

            Product second = new KarlskronaGdynia();
            second = new BreakfastBuffet(second);
            second = new Champagne(second);
            second = new Champagne(second);
            second = new SpaAccess(second);
            second = new SpaAccess(second);
            second = new AllInclusive(second);

            IReceiptPrinter printer = new ConsoleReceiptPrinter();

            printer.Print(first);
            printer.Print(second);
        }
    }
}
