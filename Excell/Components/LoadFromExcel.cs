using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using System.IO;

namespace Excell
{
    public class LoadFromExcel
    {
        List<string> _log;

        string _filePath;
        int _pageNumber = 0;
        WorksheetCollection _collection;
        Worksheet _workPage;
        int _maxColumX;
        int _maxRowsY;

        string[,] _arrayExcell;

        public LoadFromExcel(string filePath, List<string> log, int pageNumber = 0)
        {
            this._filePath = filePath ;
            this._pageNumber = pageNumber;
            this._log = log ;


            if (CreateCollectionOfPage())
            {
                SetPageNumber(_pageNumber);
                CrateArray();
            }
        }

        public string[,] GetArray()
        {
            return _arrayExcell;
        }


        // =========== 1. подгрузка и создание массива из файла .xlsx =============
        private bool CreateCollectionOfPage()
        {
            if (!File.Exists(_filePath))
            {
                _log.Add($"Файл не существует {_filePath}");
                return false;
            }
            else
            {
                _log.Add($"Файл загружен {_filePath}");
                Workbook wb = new Workbook(_filePath);
                _collection = wb.Worksheets;
                return true;
            }
        }

        private void SetPageNumber(int pageNumber)
        {
            _pageNumber = pageNumber;
            _workPage = _collection[_pageNumber]; // установка нужно листа
        }
        private void SetMaxDataCoulumX() => _maxColumX = _workPage.Cells.MaxDataColumn + 1; //+1 потому что ячейки не с нуля нумеруются
        private void SetMaxDataRowY() => _maxRowsY = _workPage.Cells.MaxDataRow + 1;
        private void CrateArray()
        {
            SetMaxDataCoulumX();
            SetMaxDataRowY();
            string[,] array = new string[_maxColumX, _maxRowsY];
            for (int columX = 0; columX < _maxColumX; columX++)
            {
                for (int rowsY = 0; rowsY < _maxRowsY; rowsY++)
                    array[columX, rowsY] = _workPage.Cells[rowsY, columX].Value?.ToString() ?? string.Empty;
            }
            _arrayExcell = array;
        }


        //делает из первых двух столбцов словарь, остальные столбцы игнорирует
        public Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> dictionary = new();
            for (int x = 0; x < _arrayExcell.GetLength(1); x++)
            {
                if (!dictionary.ContainsKey(_arrayExcell[0, x]))
                    dictionary.Add(_arrayExcell[0, x], _arrayExcell[1, x]);
            }

            return dictionary;
        }


    }
}
