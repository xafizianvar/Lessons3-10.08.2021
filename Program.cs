using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидети число! ");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n >= 500 && n < 1000)
            {
                n = n - (n * 0.03);
            }
            if (n >= 1000)
            {
                n = n - (n * 0.05);
            }
            else
            {
                n = n;
            }
            
            Console.WriteLine("Скидка="+n);

            /*--------------------------------------*/

            int a, b, c, d, y,h;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if ((a<b)&&(b<c)&&(c<d))
            {
                y = Math.Min(a, Math.Min(b, Math.Min(c, d)));
                Console.WriteLine("min=" + y);
            }
            if ((a == b) && (b == c) && (c == d))
            {
                y = a * b * c * d;
                Console.WriteLine("Произвидения="+y);
            }
            else
            {
                Console.WriteLine("Числа расположены по возрастанию");
            }   

            /*---------------------------------------------*/

            int A,B,C;
            A=Convert.ToInt32(Console.ReadLine());
            B=Convert.ToInt32(Console.ReadLine());
            C=Convert.ToInt32(Console.ReadLine());
            if ((A>=B)&&(B>=C))
            {
                A=A;
                B=B;
                C=C;
                Console.WriteLine(A+" "+B+" "+C);
            }
            else
            {
                Console.WriteLine("Этот цифры непавозрастанию");
            }
        Console.ReadKey();            
        }
    }
}
