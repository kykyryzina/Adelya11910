using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();
            Console.WriteLine((int.Parse(str[0].ToString()) == int.Parse(str[1].ToString()) ? "Одинаковы!" : "Разные!"));
        }
    }
}
