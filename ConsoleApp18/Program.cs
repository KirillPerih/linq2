using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp18
{
    class Departament
    {
        public string Name { get; set; }
        public string Reg { get; set; }

    }
    class Employ
    {
        public string Name { get; set; }
        public string departament { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Departament> departament = new List<Departament>()
            {
                new Departament {Name = "Отдел закупок", Reg = "Германия" },
                new Departament {Name = "Отдел продаж", Reg = "Испания" },
                new Departament {Name = "Отдел маркетинга", Reg = "Испания" }
            };
            List<Employ> lydis = new List<Employ>()
            {
                new Employ {Name = "Иванов", departament = "Отдел закупок" },
                new Employ {Name = "Петров", departament = "Отдел закупок" },
                new Employ {Name = "Сидоров", departament = "Отдел продаж" },
                new Employ {Name = "Лямин", departament = "Отдел продаж" },
                new Employ {Name = "Сидоренко", departament = "Отдел маркетинга" },
                new Employ {Name = "Кривоносов", departament = "Отдел продаж" }
            };
            var qwe = from lyd in lydis
                      join t in departament on lyd.departament equals t.Name
                      select new { Name = lyd.Name, departament = lyd.departament, Reg = t.Reg };
            foreach (var s in qwe.TakeWhile(x => x.Name.StartsWith("И")))
                Console.WriteLine($"{s.Name}-{s.departament}({s.Reg})");
        }
    }
}
