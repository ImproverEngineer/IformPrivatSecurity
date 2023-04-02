using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AppInformPrivateSecurity.Report
{
    #region Отчёт по справочникам.
    internal class PrintSpr : IDisposable
    {
        Excel.Application app = null;
        Excel.Workbook wb = null;
        Excel.Worksheet sheet = null;
        private bool disposed = false;
        DataGridView SprGridView;
        public PrintSpr(string title, DataGridView dataGridView)
        {
            this.SprGridView = dataGridView;
            List<string> heder = listHeder();
            this.app = new Excel.Application
            {
                Visible = false,        // скрыть отчет
                SheetsInNewWorkbook = 1 // количество листов в книге
            };
            this.wb = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            this.sheet = (Excel.Worksheet)app.Worksheets.get_Item(1); // выбрать количество листов в книге
            int row = 1;
            sheet.Name = title;
            sheet.Cells[row, 1] = title;
            centerAlignmentCell(row, 1);
            Excel.Range cell1 = sheet.Cells[row, 1];
            Excel.Range cell2 = sheet.Cells[row, heder.Count];
            Excel.Range range1 = sheet.get_Range(cell1, cell2);
            range1.Merge(Type.Missing);
            range1.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            row += 2;
            int col = 1;
            foreach (string st in heder)
            {
                sheet.Cells[row, col] = st;
                sheet.Cells[row, col].ColumnWidth = 26.57; // выставить размеры ячейки
                centerAlignmentCell(row, col);
                col++;
            }
            row++;
            col = 1;
            //  выгрузить данные 
            for (int i = 0; i < SprGridView.RowCount; i++)
            {
                for (int j = 1; j < SprGridView.ColumnCount; j++)
                {
                    sheet.Cells[row, col] = SprGridView[j, i].Value;
                    col++;
                }
                col = 1;
                row++;
            }
            app.Visible = true; // показываем отчет
            this.Dispose();
        }

        // Получение заголовка 
        private List<string> listHeder()
        {
            List<string> heder = new List<string>();
            for (int i = 0; i < SprGridView.ColumnCount; i++)
            {
                if ((SprGridView.Columns[i].Name).ToUpper().Trim() != "ID")
                {
                    heder.Add(SprGridView.Columns[i].HeaderText);
                }
            }
            return heder;
        }

        // Выравниваем по центру
        private void centerAlignmentCell(int row, int col)
        {
            sheet.Cells[row, col].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter; //выравнивание ячеек по центру
            sheet.Cells[row, col].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //выравниванин по горизонтали
        }


        #region Чистим память после создания отчёта
        /// <summary>
        /// Освобождаем память, тут надо сделать паяснение при работе с COM объектами лучше следить за памятью а то мало ли чего.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                this.sheet = null;
                this.wb = null;
                this.app = null;
            }
            // освобождаем неуправляемые объекты
            disposed = true;
        }
        #endregion
    }
    #endregion


}
