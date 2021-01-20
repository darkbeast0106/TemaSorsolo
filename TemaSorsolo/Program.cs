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
            //Enter lenyomásra új téma generálása.
            while (readline == "")
            {
                Console.Clear();
                Console.WriteLine(temak[rnd.Next(temak.Count)]);
                Console.WriteLine("\nAz újboli sorsoláshoz nyomj entert.\nKilépéshez írj be valamit az enter elé.");
                readline = Console.ReadLine();
            }
        }
    }
}
