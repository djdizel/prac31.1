using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac31._1
{
    abstract class PrintedProducts
    {
        /// <summary>
        /// поля
        /// </summary>
        string name;
        /// <summary>
        /// инкапсуляция
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public PrintedProducts() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        public PrintedProducts(string name)
        {
            this.name = name;
        }

        public abstract void Print();
        public abstract double Cost();
    }
}
