using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaSorsolo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> temak = File.ReadAllLines("feladat-temak.txt").ToList();
            string readline = "";
            Random rnd = new Random();
            Console.WriteLine("Amennyiben szeretné az ismétlődést megengedni (y/n)");
            string ismetlodesBeker = Console.ReadLine().ToLower();
            bool ismetlodes = false;
            if (ismetlodesBeker.Length > 0 && ismetlodesBeker[0] == 'y')
            {
                ismetlodes = true;
            }
            //Enter lenyomásra új téma generálása.
            while (readline == "" && temak.Count > 0)
            {
                //Konzol űrítése
                Console.Clear();
                //Új téma kiratása
                int sorszam = rnd.Next(temak.Count);
                Console.WriteLine(temak[sorszam]);
                //Instrukció kiratása
                Console.WriteLine("\nAz újboli sorsoláshoz nyomj entert.\nKilépéshez írj be valamit az enter elé.");
                if (!ismetlodes)
                {
                    temak.RemoveAt(sorszam);
                    if (temak.Count > 0)
                    {
                        Console.WriteLine("Még {0} db téma van hátra", temak.Count);
                    }
                    else
                    {
                        Console.WriteLine("Nincs több téma, a program leáll.");
                    }
                }
                //Felhasználó input beolvasása - ha üres akkor új témát generál, amúgy pedig kilép.
                readline = Console.ReadLine();
            }
        }
    }
}
