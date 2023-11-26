using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ElmurzaevIH.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double min = 1000000000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var num = Convert.ToDouble(line);
                    if (num < min && Math.Abs(num) >= 10 && Math.Abs(num) < 100)
                    {
                        min = Convert.ToDouble(line);
                    }
                }
            }
            return min;
        }
    }
}
