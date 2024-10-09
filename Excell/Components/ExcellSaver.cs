using Aspose.Cells;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lib_Excell
{
    public class ExcellSaver
    {
        List<string> _log;

        Workbook _excelBook = new Workbook(); // книга
        Worksheet _sheet;           // страница
        Cells _cells;
        Cell _cell;

        string _filePath = string.Empty;
        int _pageForRecord;

        public ExcellSaver(string filePath, List<string> log, int pageForRecord = 0)
        {
            this._filePath = filePath;
            _log = log;
            if (pageForRecord < 0)
                pageForRecord = 0;
            this._pageForRecord = pageForRecord;
            _sheet = _excelBook.Worksheets[_pageForRecord];
            _cells = _sheet.Cells;
            _cell = _cells["A1"]; 
        }

        // По номеру создаем название колонки. Напирмер 28 - "AC"
        private string ColumName(int num)
        {
            int abcCount = 26; // символов в латинском алфавите
            Queue<string> simbol = new Queue<string>();
            Dictionary<int, string> abc = new Dictionary<int, string>()
            {
                { 0,"A" },
                { 1, "B" },
                { 2, "C" },
                { 3, "D" },
                { 4, "E" },
                { 5,"F" },
                { 6,"G" },
                { 7,"H" },
                { 8, "I" },
                { 9,"J" },
                { 10, "K" },
                { 11, "L" },
                { 12, "M" },
                { 13, "N" },
                { 14, "O" },
                { 15, "P" },
                { 16, "Q" },
                { 17, "R" },
                { 18, "S" },
                { 19, "T" },
                { 20, "U" },
                { 21, "V" },
                { 22, "W" },
                { 23, "X" },
                { 24, "Y" },
                { 25, "Z" },
            };

            int result = num / abcCount;
            if (result != 0 )
                simbol.Enqueue(abc[result-1]);
            int remains = num % abcCount;
                simbol.Enqueue(abc[remains]);

            string culumName = string.Empty;
            foreach (var item in simbol) //складываем стек
                culumName += item;

            return culumName;
        }

        public void setPageForRecord(int pageForRecord) => this._pageForRecord = pageForRecord;

        //записать линию. Подойдет для заголовка
        public void RecordLine(string[] array, int startRowY = 0, int startColumX = 0)
        {
            if (startRowY < 0)
                startRowY = 0;
            if (startColumX < 0)
                startColumX = 0;

            startRowY++; //смещение на 1 тк в экселе строки начинаются с 1, а не с нуля

            for (int x = 0; x < array.Length; x++)
            {
                string columName = ColumName(x + startColumX);
                string cellForRecord = columName + startRowY.ToString(); //y тут всегда одинаковый
                _cell = _cells[cellForRecord];
                _cell.PutValue(array[x]); 
            }
        }

        //записать колонку
        public void RecordColum(string[] array, int startRowY = 0, int startColumX = 0)
        {
            if (startRowY < 0)
                startRowY = 0;
            if (startColumX < 0)
                startColumX = 0;
            int arraySizeY = array.Length;

            string columName = ColumName(startColumX);
                for (int y = 0 ; y <  arraySizeY ; y++) 
                {
                    string cellForRecord = columName + (y + 1 + startRowY).ToString(); //смещение на 1, тк в экселе строки начинаются с 1
                _cell = _cells[cellForRecord];
                    _cell.PutValue(array[y]); 
                }
        }

        public void RecordColum(List<string> array, int startRowY = 0, int startColumX = 0)
        {
            if (startRowY < 0)
                startRowY = 0;
            if (startColumX < 0)
                startColumX = 0;
            int arraySizeY = array.Count;

            string columName = ColumName(startColumX);
            for (int y = 0; y < arraySizeY; y++)
            {
                string cellForRecord = columName + (y + 1 + startRowY).ToString(); //смещение на 1, тк в экселе строки начинаются с 1
                _cell = _cells[cellForRecord];
                _cell.PutValue(array[y]);
            }
        }

        public void Record2DArray(Dictionary<string,string> dictionary, int startRowY = 0, int startColumX = 0)
        {
            if (startRowY < 0) startRowY = 0;
            if (startColumX < 0) startColumX = 0;


            string keyColumName = ColumName(0 + startColumX);
            string ValueColumName = ColumName(1 + startColumX);
            int i = 0;
            foreach (var item in dictionary)
            {
                string cellForRecord = keyColumName + (i + 1 + startRowY).ToString(); //смещение на 1, тк в экселе строки начинаются с 1, а не с нуля
                _cell = _cells[cellForRecord];
                _cell.PutValue(item.Key);

                cellForRecord = ValueColumName + (i + 1 + startRowY).ToString(); //смещение на 1, тк в экселе строки начинаются с 1, а не с нуля
                _cell = _cells[cellForRecord];
                _cell.PutValue(item.Value);
                i++;
            }
        }

        public void Record2DArray(List<string[]> list, int startRowY = 0, int startColumX = 0)
        {
            if (startRowY < 0)
                startRowY = 0;
            if (startColumX < 0)
                startColumX = 0;

            for (int i = startRowY; i < startRowY + list.Count; i++)
                RecordLine(list[i], i, startColumX);
        }

        /// <summary>
        /// записать двумерный массив
        /// </summary>
        /// <param name="array"></param>
        /// <param name="startRowY"></param>
        /// <param name="startColumX"></param>
        public void Record2DArray(string[,] array, int startRowY = 0, int startColumX = 0)
        {
            if (startRowY < 0)
                startRowY = 0;
            if (startColumX < 0)
                startColumX = 0;


            int arraySizeX = array.GetLength(0);
            int arraySizeY = array.GetLength(1);

            for (int x = 0; x < arraySizeX; x++)
            {
                string columName = ColumName(x + startColumX);
                for (int y = 0 ; y <  arraySizeY ; y++) 
                {
                    string cellForRecord = columName + (y + 1 + startRowY ).ToString(); //смещение на 1, тк в экселе строки начинаются с 1, а не с нуля
                    _cell = _cells[cellForRecord];
                    _cell.PutValue(array[x, y ]); 
                }
            }
        }

        public void Save()
        {
            if (!_filePath.Contains(".xlsx"))
                _filePath += ".xlsx";
            try
            {
                _excelBook.Save(_filePath, SaveFormat.Xlsx);
                _log.Add($"файл сохранен {_filePath}");
            }
            catch (Exception)
            {
                _log.Add($"{_filePath} - Ошибка записи файла, возможно он занят другим приложением");
            }
        }

        // методы посредники
        public void Record2DArrayAndSave(string[,] array, int startRowY = 0, int startColumX = 0)
        {
            Record2DArray(array, startRowY, startColumX);
            Save();
        }

        // асинхронные
        public async Task SaveAsync()
        {
            await Task.Run(() => Save());
        }

        public async Task Record2DArrayAndSaveAsync(string[,] array, int startRowY = 0, int startColumX = 0)
        {
            await Task.Run(() => Record2DArrayAndSave(array, startRowY, startColumX));
        }


    }
}
