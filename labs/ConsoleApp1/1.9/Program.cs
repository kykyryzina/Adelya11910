using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите сторону a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Радиус: " + (Math.Sqrt(3) / 6 * a));
        }
    }
}
