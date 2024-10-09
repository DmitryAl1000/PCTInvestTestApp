using Excell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Excell
{
    public static class ExcellD
    {
        public static string[,] GetFromExcell(string filePath, List<string> log, int pageNumber = 0)
        {
            LoadFromExcel DBFile = new LoadFromExcel(filePath, log, pageNumber = 0);
            string[,] DBArray = DBFile.GetArray();

            return DBArray;
        }

        /// <summary>
        /// Первый столбеце Ключ, второй значение. Остальные не участвуют
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="log"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public static Dictionary<string,string> GetDictionaryFromExcell(string filePath, List<string> log, int pageNumber = 0)
        {
            LoadFromExcel DBFile = new LoadFromExcel(filePath, log, pageNumber = 0);
            Dictionary<string, string> DBDictionary = DBFile.GetDictionary();
            return DBDictionary;
        }

        /// <summary>
        /// Воспринимает только первый столбец. Создаёт HashSet список 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="log"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public static HashSet<string> GetHashSetFromExcell(string filePath, List<string> log, int pageNumber = 0)
        {
            LoadFromExcel DBFile = new LoadFromExcel(filePath, log, pageNumber = 0);

            string[,] array2d = DBFile.GetArray();

            HashSet<string> hashSet = new();
            for (int i = 0; i < array2d.GetLength(1); i++)
                hashSet.Add(array2d[0, i]);

            return hashSet;
        }





        public static void SaveToExcell(this Dictionary<string, string> dictionary, string filePath, List<string> log, int pageNumber = 0)
        {
            ExcellSaver DBFile = new ExcellSaver(filePath, log, pageNumber);
            DBFile.Record2DArray(dictionary);
            DBFile.Save();
        }







    }
}
