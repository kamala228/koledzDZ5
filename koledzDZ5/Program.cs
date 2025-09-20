using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koledzDZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1;
            Console.Write("ведите число: ");
            cislo1 = Convert.ToInt32(Console.ReadLine());
            if (cislo1 % 2 == 0)
            {
                Console.WriteLine("число парное ");
            }
            else
            {
                Console.WriteLine("число не парное ");
            }
            if (cislo1<0){
                Console.WriteLine("число отрицательное ");
            }
            else
            {
                Console.WriteLine("число положительное ");
            }
        }
    }
}
