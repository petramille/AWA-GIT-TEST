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
            //Jag la till en rad kommentar här nu i testMichelle
            //Jag tog bort en rad här
        }

    static void TestMethod()
        {
            Console.WriteLine("Ny utbytt rad i den nya metoden");
            //Det här är en rad i den nya branchen
        }
    }
}
