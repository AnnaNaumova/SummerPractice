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
            int n;
            Random x = new Random();
            Console.WriteLine("Введите длину массива:");
            n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double[] b = new double[n];
            double k = a[0];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + " элемент массива а = " + (a[i] = x.Next())); //случайное задание элементов массива
                //Console.WriteLine("Введите "+i+" элемент:"); //ручной ввод элементов массива
               // a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                k = k + a[i];
                b[i] = a[i] / (1 + Math.Pow(k, 2));
                Console.WriteLine(i+" элемент массива b = "+b[i]);
            }

            Console.ReadKey();
        }
    }
}
