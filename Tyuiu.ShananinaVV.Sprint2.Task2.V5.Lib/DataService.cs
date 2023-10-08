using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShananinaVV.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((((x >= 6) && (x <= 8)) && ((y >= 5) && (y <= 11))) || (((x >= 3) && (x <= 5)) && ((y >= 3) && (y <= 5))) || (((x >= 9) && (x <= 12)) && ((y >= 5) && (y <= 6))) || ((x == 5) && (y >= 6) && (y <= 7)) || ((x >= 3) && (x <= 5) && (y == 11)) || ((x >= 7) && (x <= 10) && (y == 12)) || ((x == 9) && (y >= 3) && (y <= 4)) || ((x >= 11) && (x <= 12) && (y >= 3) && (y <= 4)) || (((x == 13) && (y >= 6)) && (y <= 8)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
