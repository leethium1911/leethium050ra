using System;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random z = new Random();

            int n = z.Next(51);
            //Console.WriteLine(n); вывод рандомного числа
            Console.WriteLine("Угадай рандомное число от 0 до 50. ");
            Console.WriteLine("Ответ:");

            int x = 1;
            int y = Convert.ToInt32(Console.ReadLine());
            while (x <= 3)

            {
                x++;

                if (y == n)
                {
                    Console.WriteLine("Поздравляем вы угадали число с " + x + "попытки");
                    break;
                }


                else
                {


                    Console.WriteLine("Неверно, попытка номер " + x + ":");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (x == 3)
                    {
                        Console.WriteLine("Вы не угадали число даже с " + x + " попыток, больше не играйте!");
                        break;
                    }

                }



            }









        }
    }
}
