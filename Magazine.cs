using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac31._1
{
    class Magazine:PrintedProducts
    {
        int circulation;
        double price;

        public int Circulation { get => circulation; set => circulation = value; }
        public double Price { get => price; set => price = value; }

        public Magazine(string name, int circulation, double price) : base (name)
        {
            this.Circulation = circulation;
            this.Price = price;
        }

        public override void Print()
        {
            Console.WriteLine($"Печатная продукция - журнал {Name}\n" + $"Тираж - {Circulation} экз. \tЦена 1-го экземпляра - {Price} руб.");
        }

        public override double Cost()
        {
            return Price * Circulation;
        }

        public static Magazine Enter()
        {
            Console.Clear();
            Console.Write("Введите название журнала: ");
            string name = Console.ReadLine();
            Console.Write("Введите тираж журнала: ");
            int circulation = int.Parse(Console.ReadLine());
            Console.Write("Введите цену журнала: ");
            double price = double.Parse(Console.ReadLine());
            return new Magazine(name, circulation, price);
        }
    }
}
