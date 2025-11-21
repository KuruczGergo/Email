using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menüvezérlés

            while (true)
            {
                Console.WriteLine("0. Kile");
                Console.WriteLine("1. E-mailek listázása");
                Console.Write("2. Új e-mail ");
                Console.WriteLine("3. E-mail törlése");
                Console.Write("4. Érvényes e-mailok listázása ");

                string valasz = Console.ReadLine();
                switch (valasz)
                {
                    case "0": return;
                    case "1": Console.WriteLine("E-mailok listázása"); break;
                    case "2": Console.WriteLine("Új e-mailek"); break;
                    case "3": Console.WriteLine("E-mailek törlése"); break;
                    case "4": Console.WriteLine("Érvényes e-mailek listázása"); break;
                    default: Console.Clear(); Console.WriteLine("Rossz parancs"); break;
                }
                Console.ReadLine();
            }

        }
    }
}
