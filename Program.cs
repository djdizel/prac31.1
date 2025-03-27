using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac31._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PrintedProducts> pressa = new List<PrintedProducts>();
            bool flag = true;
            do
            {
                Console.Write("Введите название печатной продукции: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "m": case "M":
                        {
                            pressa.Add(Magazine.Enter()); break;
                        }
                    case "n": case "N":
                        {
                            pressa.Add(Newspaper.Enter()); break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет такой печатной продукции"); break;
                        }
                    case "q": case "Q": 
                        Console.WriteLine("Выход из программы...");
                        return; 
                        break;
                }
                foreach(PrintedProducts p in pressa)
                {
                    p.Print();
                    Console.WriteLine("Стоимость тиража:" + p.Cost() + "руб.");
                }
            }
            while (flag);
            Console.ReadLine();
        }
    }
}
