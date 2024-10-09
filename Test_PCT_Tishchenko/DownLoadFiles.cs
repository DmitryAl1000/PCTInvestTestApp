using Lib_Excell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCT_Tishchenko
{
    public static class DownLoadFiles
    {

        public static HashSet<string> GetDictionaryOfHexCodes()
        {
            List<string> log = new();
            string path = FindDictionaryPath();
            return ExcellD.GetHashSetFromExcell("G:\\6 - C#\\PCTInvestTestApp\\Test_PCT_Tishchenko\\bin\\Debug\\net8.0-windows\\dictionary.xlsx", log);
        }

        public static string FindDictionaryPath()
        {
            using (FileStream fstream = new FileStream("dictionary.xlsx", FileMode.OpenOrCreate))
            {
                return fstream.Name;
            }
        }
    }

      


   
}
