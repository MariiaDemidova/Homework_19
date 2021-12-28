using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    class Computer
    {
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public double Clockrate { get; set; }
        public int RAM { get; set; }
        public int HardDrive { get; set; }
        public double VideoMemorySize { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> listComp = new List<Computer>()
            {
                new Computer(){Code="1408409", Brand ="Dell", Processor="Intel Core i5", Clockrate = 2.9, RAM = 8, HardDrive = 1000, VideoMemorySize = 2, Price = 552.5, Quantity = 5},
                new Computer(){Code="1383066", Brand ="Acer", Processor="Intel Pentium", Clockrate = 2, RAM = 4, HardDrive = 128, VideoMemorySize = 1, Price = 220.1, Quantity = 15},
                new Computer(){Code="1537004", Brand ="Acer", Processor="Intel Core i5", Clockrate = 2.6, RAM = 8, HardDrive = 512, VideoMemorySize = 4, Price = 964.7, Quantity = 1},
                new Computer(){Code="1541875", Brand ="Lenovo", Processor="AMD Athlon", Clockrate = 3.6, RAM = 8, HardDrive = 256, VideoMemorySize = 2, Price = 425.5, Quantity = 50},
                new Computer(){Code="1630034", Brand ="MSI", Processor="Intel Core i5", Clockrate = 3.6, RAM = 32, HardDrive = 1000, VideoMemorySize = 8, Price = 2635, Quantity = 4},
                new Computer(){Code="1498988", Brand ="ASUS", Processor="Intel Pentium", Clockrate = 4, RAM = 8, HardDrive = 256, VideoMemorySize = 2, Price = 451.2, Quantity = 1},
                new Computer(){Code="1422131", Brand ="HP", Processor="AMD Athlon", Clockrate = 2.3, RAM = 4, HardDrive = 128, VideoMemorySize = 1, Price = 297, Quantity = 23},
            };
            Console.WriteLine("Введите нужный тип процессора");
                string typeProcessor = Convert.ToString(Console.ReadLine());
                List<Computer> processor = listComp
                    .Where(p => p.Processor.Contains(typeProcessor))
                    .ToList();

                foreach (Computer p in processor)
                {
                    Console.WriteLine($"{p.Code} {p.Brand} {p.Processor} {p.Clockrate} {p.RAM} {p.HardDrive} {p.VideoMemorySize} {p.Price} {p.Quantity}");
                }
            Console.WriteLine();
            Console.WriteLine("Введите нужный объем ОЗУ");
            int inputRAM = Convert.ToInt32(Console.ReadLine());
            List<Computer> ram = listComp
                .Where(r => r.RAM >= inputRAM)
                .ToList();

            foreach (Computer r in ram)
            {
                Console.WriteLine($"{r.Code} {r.Brand} {r.Processor} {r.Clockrate} {r.RAM} {r.HardDrive} {r.VideoMemorySize} {r.Price} {r.Quantity}");
            }
            Console.WriteLine();
            Console.WriteLine("Список по увеличению стоимости");
            List<Computer> orderPrice = listComp
                .OrderBy(o => o.Price)
                .ToList();

            foreach (Computer o in orderPrice)
            {
                Console.WriteLine($"{o.Code} {o.Brand} {o.Processor} {o.Clockrate} {o.RAM} {o.HardDrive} {o.VideoMemorySize} {o.Price} {o.Quantity}");
            }
            Console.WriteLine();
            Console.WriteLine("Список с группировкой по типу процессора");
            var sortProcessor = listComp
                .GroupBy(s => s.Processor);

            foreach (IGrouping<string, Computer> s in sortProcessor)
            {
                foreach (Computer g in s)
                {
                    Console.WriteLine($"{g.Code} {g.Brand} {g.Processor} {g.Clockrate} {g.RAM} {g.HardDrive} {g.VideoMemorySize} {g.Price} {g.Quantity}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var minPrice = listComp
                .Min(min => min.Price);
            Computer cheapComp = orderPrice
                .First();

            Console.WriteLine("Самый бюджетный компьютер:");
            Console.WriteLine(minPrice);
            Console.WriteLine($"{cheapComp.Code} {cheapComp.Brand} {cheapComp.Processor} {cheapComp.Clockrate} {cheapComp.RAM} {cheapComp.HardDrive} {cheapComp.VideoMemorySize} {cheapComp.Price} {cheapComp.Quantity}");
            Console.WriteLine();
            var maxPrice = listComp
                .Max(max => max.Price);
            Computer expensive = orderPrice
                .Last();
            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine(maxPrice);
            Console.WriteLine($"{expensive.Code} {expensive.Brand} {expensive.Processor} {expensive.Clockrate} {expensive.RAM} {expensive.HardDrive} {expensive.VideoMemorySize} {expensive.Price} {expensive.Quantity}");
            Console.WriteLine();
            bool quantityCheck = listComp
                .Any(a => a.Quantity > 30);
            if (quantityCheck == true)
            {
                Console.WriteLine("Есть компьютеры с наличием более 30 штук");
            }
            List<Computer> quan = listComp
               .Where(q => q.Quantity >= 30)
               .ToList();

            foreach (Computer q in quan)
            {
                Console.WriteLine($"{q.Code} {q.Brand} {q.Processor} {q.Clockrate} {q.RAM} {q.HardDrive} {q.VideoMemorySize} {q.Price} {q.Quantity}");
            }
            Console.ReadKey();
        }
    }
}

