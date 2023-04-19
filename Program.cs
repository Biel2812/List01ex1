using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List01ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b1;
            int h2;
            int area;

            Console.WriteLine("Digite sua base");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura");
            h2 = int.Parse(Console.ReadLine());
            area = b1 * h2;
            Console.WriteLine("Resultado da area");
            Console.WriteLine(area);
        }
    }
}
