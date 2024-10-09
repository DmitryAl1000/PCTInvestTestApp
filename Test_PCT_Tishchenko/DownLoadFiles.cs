using System;
using System.Collections.Generic;
using System.Linq;
using Lib_Excell;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PCT_Tishchenko
{
    public static class DownLoadFiles
    {
        //на скорую руку
        public static Dictionary<string, string> GetDictionaryFromExcel()
        {
            List<string> log = new();
            string path = FindDictionaryPath(); //= "G:\\6 - C#\\PCTInvestTestApp\\Test_PCT_Tishchenko\\bin\\Debug\\net8.0-windows\\dictionary.xlsx"

            string[,] resultArray = ExcellD.GetFromExcell(path, log);
            Dictionary<string, string> resultDictionary = ConvertToDictionaryWhithUpperKeys(resultArray);
            return resultDictionary;
        }



        private static Dictionary<string, string> ConvertToDictionaryWhithUpperKeys(string[,] array)
        {
            Dictionary<string, string> resultDictionary = new Dictionary<string, string>();

            if (array is null)
                return resultDictionary;
            if (array.GetLength(0) < 1)
                return resultDictionary;

            for (int x = 0; x < array.GetLength(1); x++)
            {
                if (!resultDictionary.ContainsKey(array[0, x]))
                    resultDictionary.Add(array[0, x].ToUpper(), array[1, x]);
            }

            return resultDictionary;
        }

        private static string FindDictionaryPath()
        {
            using (FileStream fstream = new FileStream("dictionary.xlsx", FileMode.OpenOrCreate))
            {
                return fstream.Name;
            }
        }
    }

      


   
}
