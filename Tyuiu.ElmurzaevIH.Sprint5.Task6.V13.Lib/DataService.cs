using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ElmurzaevIH.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader =  new StreamReader(path))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == 'С' || line[i] == 'с') && (line[i + 1] == 'С' || line[i + 1] == 'с'))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
