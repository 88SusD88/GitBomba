using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Bomba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: " + 5*Math.Cos(2*x));
            Console.ReadKey();
            //Нам немного подпортили проект, но в целом всё работает
        }
    }
}
