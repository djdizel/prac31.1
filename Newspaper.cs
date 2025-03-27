using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace prac31._1
{
    class Newspaper:PrintedProducts
    {
        int count;
        double sheetCost;
        int circulation;

        public int Count { get => count; set => count = value; }
        public double SheetCost { get => sheetCost; set => sheetCost = value; }
        public int Circulation { get => circulation; set => circulation = value; }

        public Newspaper() { }

        public Newspaper(string name, int count, double sheetCost, int circulation):base(name)
        {
            Count = count;
            SheetCost = sheetCost;
            Circulation = circulation;
        }

        public override void Print()
        {
            Console.WriteLine($"Печатная продукция - газета {Name}\nКоличество листов - {Count}\tСтоимость 1-го листа - {SheetCost} руб.\tТираж газеты составляет {Circulation} экз.");
        }

        public override double Cost()
        {
            return Count * SheetCost * Circulation;
        }

        public static Newspaper Enter()
        {
            Console.Clear();
            Console.Write("Введите название газеты: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество листов газеты: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость одного листа газеты: ");
            double sheetCost =
            double.Parse(Console.ReadLine());
            Console.Write("Введите тираж газеты: ");
            int circulation =
            int.Parse(Console.ReadLine());
            return new Newspaper(name, count, sheetCost, circulation);
        }
    }
}

