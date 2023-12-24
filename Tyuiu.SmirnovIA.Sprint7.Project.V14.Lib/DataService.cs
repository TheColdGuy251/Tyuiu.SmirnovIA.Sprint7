using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SmirnovIA.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public int VehicleAmount(string[,] array)
        {
            return array.GetLength(0);
        }

        public int RouteAmount_Route(string[,] array, int id)
        {
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try {   
                if (Convert.ToInt32(array[i, 2]) == id)
                {
                    cnt++;
                }
                }
                catch { }
            }
            return cnt;
        }

        public int MinTime_Route(string[,] array, int id)
        {
            int min = 999999999;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (Convert.ToInt32(array[i, 2]) == id)
                    {
                        try
                        {
                            min = Math.Min(min, Convert.ToInt32(array[i, 6]));
                        }
                        catch { }
                    }
                }
                catch {  };
                if (min == 999999999)
                {
                    min = 0;
                }
            }
            return min;
        }

        public int MaxTime_Route(string[,] array, int id)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (Convert.ToInt32(array[i, 2]) == id)
                    {
                        try
                        {
                            max = Math.Max(max, Convert.ToInt32(array[i, 6]));
                        }
                        catch { }
                    }
                }
                catch { }

            }
            return max;
        }

        public int AvgTime_Route(string[,] array, int id)
        {
            int avg = 0;
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try { 
                    if (Convert.ToInt32(array[i, 2]) == id)
                    {
                        try
                        {
                            avg += Convert.ToInt32(array[i, 6]);
                            cnt++;
                        }
                        catch { }
                    }
                }
                catch { }
            }
            if (cnt == 0)
            {
                return 0;
            }
            return avg / cnt;
        }

        public int RouteAmount(string[,] array)
        {
            int cnt = 0;
            string[] usedId = new string[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (!(usedId.Contains(array[i, 2])))
                {
                    usedId[i] = array[i, 2];
                    cnt++;
                }
            }
            return cnt;
        }
        public int MinTime(string[,] array)
        {
            int min = 999999999;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    min = Math.Min(min, Convert.ToInt32(array[i, 6]));
                }
                catch
                {

                }

            }
            if (min == 999999999)
            {
                min = 0;
            }
            return min;
        }
        public int MaxTime(string[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    max = Math.Max(max, Convert.ToInt32(array[i, 6]));
                }
                catch
                {

                }
            }
            return max;
        }
        public int AvgTime(string[,] array)
        {
            int avg = 0;
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try { 
                    avg += Convert.ToInt32(array[i, 6]);
                    cnt++;
                }
                catch { }
            }
            if (cnt == 0)
            {
                return 0;
            }
            return avg / cnt;
        }
    }
}
