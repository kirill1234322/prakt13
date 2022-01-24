using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Ввести А\n2.Ввести B\n3.Выполнить операцию +\n4.Выполнить операцию -\n5.Выполнить операцию *\n6.Выполнить операцию /");
            int a=0,b=0;
            int vvod=int.Parse(Console.ReadLine());



            if (vvod == 1)
            {
                a = int.Parse(Console.ReadLine());
            }
            if(vvod==4)
            {
                Console.WriteLine(a-b);
            }

            if (vvod == 2)
            {
                b = int.Parse(Console.ReadLine());
            }

            if (vvod == 3)
            {
                Console.WriteLine(a + b);
            }

            if(vvod==5)
            {
                Console.WriteLine(a*b);
            }







            Console.ReadKey();
            
        }
    }
}
