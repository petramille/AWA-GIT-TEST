using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett namn");
            string name = Console.ReadLine();
            Console.WriteLine("Hej Petra!");
            Console.WriteLine("Nu skrev jag en rad till!");
            Console.WriteLine("Här skriver jag lite kod");
            Console.WriteLine("OCh så lite till");
            Console.WriteLine("Ett försök till");
            Console.WriteLine("Överlever den här mergen?");
            //Den här raden tog jag bort
        }

    static void TestMethod()
        {
            Console.WriteLine("Ny utbytt rad i den nya metoden");
            Console.WriteLine("Här lade jag till en rad i branchen");
        }
    }
}
