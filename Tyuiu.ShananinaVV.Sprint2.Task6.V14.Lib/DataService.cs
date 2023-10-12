using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShananinaVV.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {

            
            int dayOfWeek = (k + d - 2) % 7 + 1;
            switch (dayOfWeek)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: throw new ArgumentException($"Введены неверные значения. Значения {dayOfWeek}");
            }
            

        }
    }
}
