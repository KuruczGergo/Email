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

            //adatszerkezet
            List<string> e_mailok = new List<string>();
            e_mailok.Add("alma@kört.hu");
            e_mailok.Add("alma2@asd.hu");
            e_mailok.Add("alma3@dsa.hu");
            e_mailok.Add("kuruczg@kkszki.hu");
            e_mailok.Add("alma.korte@alma.hu");



            //Menüvezérlés
            while (true)
            {
                Console.WriteLine("0. Kilepés");
                Console.WriteLine("1. E-mailek listázása");
                Console.WriteLine("2. Új e-mail ");
                Console.WriteLine("3. E-mail törlése");
                Console.WriteLine("4. Érvényes e-mailok listázása ");

                string valasz = Console.ReadLine();
                switch (valasz)
                {
                    case "0": return;
                    case "1":
                        Console.Clear();
                        Console.WriteLine("E-mailok listázása");
                        int sorszam = 0;
                        foreach (String e_mail in e_mailok)
                        {
                            Console.WriteLine($"{sorszam++} {e_mail}");
                        }
                        break;
                    case "2": Console.WriteLine("Adja meg az új e-mail címet");
                        String uj = Console.ReadLine();
                        e_mailok.Add(uj);
                        break;
                    case "3": Console.WriteLine("E-mailek törlése");
                        Console.WriteLine("Adja meg a törlendő e-mail sorszámát");
                        int index = Convert.ToInt32(Console.ReadLine());
                        e_mailok.RemoveAt(index);
                        break;
                    case "4": Console.WriteLine("Érvényes e-mailek listázása"); break;
                    default: Console.Clear(); Console.WriteLine("Rossz parancs"); break;
                }
                Console.ReadLine();
            }

        }
    }
}
