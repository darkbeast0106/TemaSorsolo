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
            while (readline == "")
            {
                Console.Clear();
                Console.WriteLine(temak[rnd.Next(temak.Count)]);
                Console.WriteLine("\nKilépéshez írj be valamit\nEnter lenyomására új témát generál.");
                readline = Console.ReadLine();
            }
        }
    }
}
