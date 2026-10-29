using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        public static void A(in int x)
        {
            Console.WriteLine("A: " + x);
        }

        public static void B(out int x)
        {
            x = 20;
        }

        public static void C(ref int x, int amount = 5)
        {
            x += amount;
        }

        public static int SumValues(params int[] values)
        {
            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }

            return sum;
        }

        public static void Main()
        {
            int a = 10;
            A(in a);                       

            int b;
            B(out b);
            Console.WriteLine(b);          

            int c = 30;
            C(ref c);                     
            Console.WriteLine(c);          

            C(ref c, 10);
            Console.WriteLine(c);         

            Console.WriteLine(SumValues(1, 2, 3));      
            Console.WriteLine(SumValues(10, 20, 30, 40));
            Console.WriteLine(SumValues());            
        }
    }
}
