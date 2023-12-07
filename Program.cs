using System; 

namespace Objects_and__Classes
{
    internal class Program
    {
        string x = "Genericka vrednost x";
        string y = "Genericka vrednost y";

        public static void Metoda() 
        {
        Program TreciObjekat = new Program();
            Console.WriteLine(TreciObjekat.x);
            Console.WriteLine(TreciObjekat.y);
        }

        static void Main(string[] args)
        {
            Program PrviObjekat = new Program();
            Console.WriteLine(PrviObjekat.x);
            Console.WriteLine(PrviObjekat.y);

            Program DrugiObjekat = new Program();
            Console.WriteLine(PrviObjekat.x);
            Console.WriteLine(PrviObjekat.y);

            Console.WriteLine("######################");
            Metoda();
            
        }
    }
}
