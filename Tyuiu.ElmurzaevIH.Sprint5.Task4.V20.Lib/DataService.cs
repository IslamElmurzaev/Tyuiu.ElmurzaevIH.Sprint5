using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ElmurzaevIH.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Pow(Math.Pow(Convert.ToDouble(strX), 2) / Math.Sin(Convert.ToDouble(strX)), 3);
            return Math.Round(res, 3);
        }
    }
}
