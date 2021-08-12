using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;


namespace Sport_Application
{
    public partial class Report : Form
    {
        private string connection;
        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        private void ReportTablet(string time1, string time2)
        {
            Student student = new Student();
            string input = $"SELECT Дневник.СтудНомер, Студенты.ФИО_Студ, Дневник.Дата, Дневник.Направление," +
                $" Дневник.Объект, Дневник.УСР FROM Дневник INNER JOIN Студенты ON " +
                $"Дневник.СтудНомер = Студенты.СтудНомер " +
                $"WHERE ({connection}) " +
                $"AND (Дневник.Дата BETWEEN CONVERT(DATETIME, '{time1}', 102) " +
                $"AND CONVERT(DATETIME, '{time2}', 102))";
            student.connectStudent(input, "Journal");
            dataGridView1.DataSource = student.Dst.Tables["Journal"];
        }
        public Report()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ReportTablet(dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00"), dateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:59"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ReportTablet(dateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00"), dateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:59"));
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ReportTablet(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"), DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2016)|*.xlsx|Excel Files(2013)|*.xlsx";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 20;

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }
    }
}
