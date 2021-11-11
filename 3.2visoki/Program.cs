using System;

namespace _3._2visoki
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите натуральное число под названием палиндром не больше 100: ");
                int x = int.Parse(Console.ReadLine());
                int per, ftor;

                if (x <= 100)
                {
                    do
                    {
                        if (x < 10)
                            Console.WriteLine(x);
                        else
                        {
                            per = x % 10;
                            ftor = x / 10;

                            if (per == ftor) Console.WriteLine(x);
                        }
                        x--;
                    }
                    while (x >= 0);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
