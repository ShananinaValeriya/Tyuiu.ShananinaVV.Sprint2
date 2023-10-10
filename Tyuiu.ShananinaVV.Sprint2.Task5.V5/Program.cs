using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint2.Task5.V5.Lib;

namespace Tyuiu.ShananinaVV.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch,                 *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                    *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера в        *");
            Console.WriteLine("* зависимости от их достоинства: «валету» — 11, «даме» — 12,              *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14. Порядковые номера остальных карт            *");
            Console.WriteLine("* соответствуют их названиям («шестерка», «девятка» и т. п.).             *");
            Console.WriteLine("* По заданному номеру карты k (6 <=k <=14) определить достоинство         *");
            Console.WriteLine("* соответствующей карты.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            

           

            Console.WriteLine("Введите номер карты : ");
            int numCard = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numCard < 6 )||(numCard>14))
            {
                res = "Введено неверное значение";

            }
            else
            {
                res = "Достоинство карты : " + ds.FindCardValue(numCard);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
