using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint2.Task6.V14.Lib;

namespace Tyuiu.ShananinaVV.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й   *");
            Console.WriteLine("* день не високосного года, в котором 1 января d-й день недели (если      *");
            Console.WriteLine("* 1 января — понедельник, то d = 1 ,  если вторник — d = 2 , …, если      *");
            Console.WriteLine("* воскресенье — d = 7).                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string res;

            int k;
            int d;

            Console.WriteLine("Введите целое число: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер дня недели, с которого начинается 1 января: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (((k < 1) || (k > 365)) || ((d < 1) || (d > 7)))
            {
                res = "Введены неверные значения";
            }
            else
            {
                res = "День недели: " + ds.FindDayName(k, d);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();





            
        }
    }
}
