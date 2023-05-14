using AppInformPrivateSecurity.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;

namespace AppInformPrivateSecurity.Report
{
    #region Направление на прохождение медкомисии
    internal class PrintMedicalDirection : Print
    {
        string path = Environment.CurrentDirectory;
        public PrintMedicalDirection(List<string> infoWorker)
        {
            this.app = new Excel.Application
            {
                Visible = true,
                SheetsInNewWorkbook = 1

            };
            //открываем файл с текущей дерикторией
            this.wb = app.Workbooks.Open(path + @"\Tamplate\Направление на Мед.комиссию.xltx");
            //открываем нужный лист
            this.sheet = (Excel.Worksheet)app.Worksheets["Направление на мед. комиссию"];
            int row = 14;
            this.sheet.Cells[row, 7].value = infoWorker[0] + " " + infoWorker[1] + " " + infoWorker[2];
            row += 2;
            this.sheet.Cells[row, 12].value = DateTime.Parse(infoWorker[3]).ToString("dd.MM.yyyy");
            Dispose();
        }
    }
    #endregion

    #region worning list
    internal class WorningList : Print
    {
        public WorningList(List<Employeer.Statistic> statistic)
        {
            string path = Environment.CurrentDirectory;
            this.app = new Excel.Application
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            this.wb = app.Workbooks.Open(path + @"\Tamplate\WorningList.xlt");
            this.sheet = (Excel.Worksheet)app.Worksheets["Worning лист"];
            app.Visible = true;
            int row = 4;
            foreach (Employeer.Statistic stat in statistic)
            {
                this.sheet.Cells[row, 1] = stat.name;
                this.sheet.Cells[row, 2] = stat.Term;
                this.sheet.Cells[row, 3] = stat.Type;
                row += 1;
            }
            this.Dispose();
        }
    }
    #endregion
    internal class PrintPeriodicInspection : Print
    {
        DataGridView gridView;
        public PrintPeriodicInspection(DataGridView dataGrid)
        {
            this.gridView = dataGrid;
            string path = Environment.CurrentDirectory;
            this.app = new Excel.Application
            {
                Visible = false,
                SheetsInNewWorkbook = 1
            };
            this.wb = app.Workbooks.Open(path + @"\Tamplate\Уведомление на периодическую проверку.xltx");
            this.sheet = (Excel.Worksheet)app.Worksheets["Уведомление на П.П."];
            int row = 32;
            Excel.Range cell1 = sheet.Cells[row, 1];
            Excel.Range cell2 = sheet.Cells[row, 38];
            Excel.Range range1 = sheet.get_Range(cell1, cell2);
            range1.Copy();
            int tempRow = row;
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                tempRow = copyRange(tempRow, range1);
            }

            int number = 1;
            //  выгрузить данные 
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                sheet.Cells[row, 1] = number.ToString();
                sheet.Cells[row, 4] = this.gridView["Ф.И.О", i].Value;
                sheet.Cells[row, 15] = this.gridView["Разряд охраника", i].Value;
                number++;
                row++;
            }
            app.Visible = true;
            // показываем отчет
            this.Dispose();
        }
        #region подготавливаем облость для вставки
        /// <summary>
        /// копирование полей 
        /// </summary>
        /// <param name="row">строка</param>
        /// <param name="range">область выделения</param>
        /// <returns></returns>
        private int copyRange(int row, Excel.Range range)
        {
            Excel.Range cell3 = sheet.Cells[row, 1];
            Excel.Range cell4 = sheet.Cells[row, 38];
            Excel.Range range2 = sheet.get_Range(cell3, cell4);
            range.Copy();
            range2.PasteSpecial();
            Excel.Range range3 = sheet.get_Range((Excel.Range)sheet.Cells[row, 1], (Excel.Range)sheet.Cells[row, 3]);
            range3.Merge(Type.Missing);
            Excel.Range range4 = sheet.get_Range((Excel.Range)sheet.Cells[row, 4], (Excel.Range)sheet.Cells[row, 14]);
            range4.Merge(Type.Missing);
            Excel.Range range5 = sheet.get_Range((Excel.Range)sheet.Cells[row, 15], (Excel.Range)sheet.Cells[row, 26]);
            range5.Merge(Type.Missing);
            Excel.Range range6 = sheet.get_Range((Excel.Range)sheet.Cells[row, 27], (Excel.Range)sheet.Cells[row, 33]);
            range6.Merge(Type.Missing);
            Excel.Range range7 = sheet.get_Range((Excel.Range)sheet.Cells[row, 34], (Excel.Range)sheet.Cells[row, 38]);
            range7.Merge(Type.Missing);
            return ++row;
        }
        #endregion
    }

    #region Отчёт по справочникам.
    internal class PrintSpr : Print
    {
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

    }
    #endregion

    #region Суперакласс построения отчетов
    abstract class Print : IDisposable
    {
        protected Excel.Application app = null;
        protected Excel.Workbook wb = null;
        protected Excel.Worksheet sheet = null;
        protected bool disposed = false;
        protected DataGridView SprGridView;
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                    this.sheet = null;
                    this.wb = null;
                    this.app = null;
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~Print()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
    #endregion

}
