using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отчёт
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //Создаём массив прибыли, заполняем и выводим
            Console.WriteLine("Прибыль");

            int[] profit = new int[13];

            for (int i = 1; i < profit.Length; i++)
            {
                profit[i] = rand.Next(1,100000);
                Console.WriteLine($"Месяц:{i} прибыль - {profit[i]} тыс.");
            }

            Console.WriteLine(" ");

            //Создаём массив расходов, заполняем и выводим
            Console.WriteLine("Расходы");

            int[] expenses = new int[13];

            for (int i = 1; i < expenses.Length; i++)
            {
                expenses[i] = rand.Next(1, 100000);
                Console.WriteLine($"Месяц:{i} расходы - {expenses[i]} тыс.");
            }

            Console.WriteLine(" ");

            //Создём массив итогов, считываем 2 первых и выводим разность ;
            int[] result = new int[13];
            for (int i = 1; i < result.Length; i++)
            {
                Console.WriteLine($"Итого, за {i} месяц кампания получила/потеряла: {profit[i] - expenses[i]} тыс.");
                result[i] = profit[i] - expenses[i];

            }
            //Создаём переменные для поиска минимума и максимума в массиве result
            int min = result[0];
            int index = 0;

            int max = result[0];
            int indexMax = 0;
            //поиск min и max в result
            for (int i = 0; i < result.Length; i++)
            {
                if (min > result[i])
                {
                    min = result[i];
                    index = i;
                }
                if (max < result[i])
                {
                    max = result[i];
                    indexMax = i;
                }
            }

            Console.WriteLine(" ");

            Console.WriteLine($"Месяц с минимальным доходом: {index}");
            Console.WriteLine($"Месяц с максимальным доходом: {indexMax}");
        }
    }
}
