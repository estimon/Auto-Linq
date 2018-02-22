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

            Console.WriteLine("Autod kilovattide järjestuses");
            Console.WriteLine("-----------------------------");
            var query = (from element in Auto1
                         orderby element.KW descending
                         select element).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.Värv + " " + item.KW + " KW");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Autod mille nimes on \"O\" täht");

            var a = Auto1.Where(x => x.Tootja.Contains("o")).ToList();
            foreach (var item in a)
            {
                Console.WriteLine(item.Tootja);
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Autod mille nimes on \"E\" täht");
            var b = Auto1.Where(x => x.Tootja.Contains("e")).ToList();
            foreach (var item in a)
            {
                Console.WriteLine(item.Tootja);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Kõige nõrgem ja kõige tugevam auto");

            var c = Auto1.Where(x => x.KW == 426).ToList();
            foreach (var item in c)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.KW +"KW");
            }
            var d = Auto1.Where(x => x.KW == 55).ToList();
            foreach (var item in d)
            {
                Console.WriteLine(item.Tootja + " " + item.Mudel + " " + item.KW + "KW");
            }



            Console.Read();
        }



    }
}
