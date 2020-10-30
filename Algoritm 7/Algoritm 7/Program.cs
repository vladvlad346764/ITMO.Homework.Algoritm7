using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Погнали 
                double n;

                do
                {
                    Console.Write("Введите число N:  \n");
                    n = double.Parse(Console.ReadLine());

                } while (n <= 0);

                double S = 0;
                double d;
                int i;

                for (i = 1; i <= n; i++)
                {
                    Console.Write("Введите число D:  \n");
                    d = double.Parse(Console.ReadLine());
                    S = S + d;
                }

                double Mid = S / (i - 1);
                Console.Write("Значение Mid равно " + Mid);
                Console.WriteLine("\nПрограмма выполнена, нажмите на любую кнопку, чтобы выйти..");
            }



            catch
            {
                Console.WriteLine("Вы ввели не число.");
                Console.WriteLine("\nПрограмма завершена с ошибкой, повторите действия..");
            }
            finally
            {

                Console.ReadLine();

            }

        }
    }
}
