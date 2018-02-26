using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            var Auto1 = new List<Autoclass>
            {
                new Autoclass(){KW = 66, Tootja = "Volkswagen", Mudel = "Passat", Värv = "Valge" },
                new Autoclass(){KW = 75, Tootja = "BMW", Mudel ="316", Värv = "Roheline"},
                new Autoclass(){KW = 166, Tootja = "Volvo", Mudel = "850", Värv = "Tumesinine"},
                new Autoclass(){KW = 55, Tootja = "VAZ", Mudel = "21061", Värv = "Roheline"},
                new Autoclass(){KW = 81, Tootja = "Toyota", Mudel = "Avenisis Tourer", Värv = "Hall"},
                new Autoclass(){KW = 75, Tootja = "Mercedes-Benz", Mudel = "C 200", Värv = "Hõbedane"},
                new Autoclass(){KW = 426, Tootja = "Lamborghini", Mudel = "Huracan", Värv = "Punane"},
                new Autoclass(){KW = 175, Tootja = "Jaguar", Mudel = "S-Type", Värv = "Must"},
                new Autoclass(){KW = 66, Tootja = "Honda", Mudel = "Civic", Värv = "Kollane"},
                new Autoclass(){KW = 100, Tootja = "Opel", Mudel = "Vectra", Värv = "Helehall"},
            };

            Console.WriteLine("1. Autod kilovattide järjestuses");
            Console.WriteLine("-----------------------------");
            var query = (from element in Auto1
                         orderby element.KW descending
                         select element).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.Värv + " " + item.KW + " KW");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("2. Autod mille nimes on \"O\" täht");

            var a = Auto1.Where(x => x.Tootja.Contains("o")).ToList();
            foreach (var item in a)
            {
                Console.WriteLine(item.Tootja);
            }
            var b = Auto1.Where(x => x.Tootja.Contains("O")).ToList();
            foreach (var item in b)
            {
                Console.WriteLine(item.Tootja);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("3. Autod mille nimes on \"E\" täht");
            var c = Auto1.Where(x => x.Tootja.Contains("e")).ToList();
            foreach (var item in c)
            {
                Console.WriteLine(item.Tootja);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("4. Autod mille mudel koosneb rohkem kui neljast tähest");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("5. Kõige võimsam ja kõige nõrgem auto");
            Console.WriteLine();

            var d = Auto1.Where(x => x.KW == 426).ToList();

            foreach (var item in d)
            {
                Console.WriteLine("Kõige võimsam auto on " + item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }

            var e = Auto1.Where(x => x.KW == 55).ToList();

            foreach (var item in e)
            {
                Console.WriteLine("Kõige nõrgem auto on " + item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }
            Console.WriteLine("-----------------------------");

            Console.ReadLine();
        }



    }
}
