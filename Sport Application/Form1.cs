using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Sport_Application
{
    public partial class Form1 : Form
    {
        Student stud = new Student();

        string namestud;
        string group;

        public Form1()
        {
            InitializeComponent();
        }

        //Сканер 1
        private void COM3()
        {
            try
            {
                if (serialPort1.PortName != "COM3")
                {
                    serialPort1.Close();
                    serialPort1.PortName = "COM3";
                    serialPort1.Open();
                }
                else
                {
                    if (serialPort1.PortName == "COM3")
                    {
                        serialPort1.Close();
                        serialPort1.Open();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оборудование не подключено! Доступен режим ручного ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //Сканер 2
        private void COM8()
        {
            try
            {
                if (serialPort1.PortName != "COM8")
                {
                    serialPort1.Close();
                    serialPort1.PortName = "COM8";
                    serialPort1.Open();
                }
                else
                {
                    if (serialPort1.PortName == "COM8")
                    {
                        serialPort1.Close();
                        serialPort1.Open();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оборудование не подключено! Доступен режим ручного ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool IsNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (namestud != null && group != null)
            {
                if (inputBox.Text != "" && IsNum(selectObjectBox.Text) != true && IsNum(selectTimeBox.Text) != false)
                {
                    Student stud = new Student();

                    if (usrButton.Checked == true)
                    {
                        stud.Insert(inputBox.Text, selectTypeBox.Text, selectObjectBox.Text, usrButton.Text, Convert.ToInt32(selectTimeBox.Text));
                    }
                    else
                    {
                        stud.Insert(inputBox.Text, selectTypeBox.Text, "ПСМ", skillUpButton.Text, Convert.ToInt32(selectTimeBox.Text));
                    }

                    bufferBox.Items.Add(studentInfoBox.Text);
                    inputBox.Text = "";
                    studentInfoBox.Text = "";
                    allHoursBox.Text = "";
                    hoursObjectBox.Text = "";
                    selectTimeBox.Text = "";
                    selectTimeBox.Text = "Часы";
                    sendButton.Enabled = false;
                }
            }
            else
                MessageBox.Show("Введите данные корректно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Now;
            DateTime startDate;
            DateTime finishDate;
            if (Convert.ToInt32(todayDate.ToString("MM")) >= 02 && Convert.ToInt32(todayDate.ToString("MM")) <= 08)
            {
                //второй семестр
                startDate = new DateTime(todayDate.Year, 01, 26);
                finishDate = new DateTime(todayDate.Year, 08, 31);
            }
            else
            {
                if (Convert.ToInt32(todayDate.ToString("MM")) == 01 && Convert.ToInt32(todayDate.ToString("dd")) <= 25)
                {
                    //первый семестр после Нового года 
                    startDate = new DateTime(todayDate.Year - 1, 09, 01);
                    finishDate = new DateTime(todayDate.Year, 01, 25);

                }
                else
                {
                    //первый семестр до Нового года
                    startDate = new DateTime(todayDate.Year, 09, 01);
                    finishDate = new DateTime(todayDate.Year + 1, 01, 25);
                }
            }

            //запрос получения всех отр. часов семестра
            string hourssemquery = $"DECLARE @sum INT " +
                                   $"SET @sum = 0 " +
                                   $"Set @sum += (SELECT  COALESCE(SUM(ОтрабЧасы), 0) FROM Дневник " +
                                   $"WHERE(СтудНомер = '{inputBox.Text}') " +
                                   $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}')) " +
                                   $"Set @sum += (SELECT  COALESCE(SUM(Часы), 0) FROM Волонтерство " +
                                   $"WHERE(СтудНомер = '{inputBox.Text}') " +
                                   $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}')) " +
                                   $"Set @sum += ( SELECT  COALESCE(SUM(Часы), 0) FROM Мероприятия " +
                                   $"WHERE(СтудНомер = '{inputBox.Text}') " +
                                   $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}')) " +
                                   $"Set @sum += ( SELECT  COALESCE(SUM(Часы), 0) FROM Секции " +
                                   $"WHERE(СтудНомер = '{inputBox.Text}') " +
                                   $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}')) " +
                                   $"SELECT @sum";

            SqlCommand commanddb = new SqlCommand(hourssemquery, stud.ReturnConnect());

            stud.ReturnConnect().Open();

            int allhourssem = Convert.ToInt32(commanddb.ExecuteScalar());

            allHoursBox.Text = allhourssem.ToString();

            string input = $"SELECT ФИО_Студ FROM Студенты WHERE СтудНомер = '{inputBox.Text}'";

            commanddb = new SqlCommand(input, stud.ReturnConnect());

            string inputgr = $"SELECT Группа FROM Студенты JOIN Группы " +
                    $"ON Студенты.КодГруппы = Группы.КодГруппы WHERE СтудНомер = '{inputBox.Text}'";

            SqlCommand commanddb2 = new SqlCommand(inputgr, stud.ReturnConnect());

            namestud = (string)commanddb.ExecuteScalar();

            group = (string)commanddb2.ExecuteScalar();

            studentInfoBox.Text = namestud + "\r\n Группа: " + group;

            selectTimeBox.Enabled = true;

            string hoursobj;

            if (usrButton.Checked == true)
            {
                hoursobj = $"SELECT COALESCE (SUM(ОтрабЧасы), 0) FROM Дневник WHERE СтудНомер = '{inputBox.Text}' " +
                              $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}') " +
                              $"AND Объект = '{selectObjectBox.Text}'";
            }
            else
            {
                hoursobj = $"SELECT COALESCE (SUM(ОтрабЧасы), 0) FROM Дневник WHERE СтудНомер = '{inputBox.Text}' " +
                              $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}') " +
                              $"AND Объект = 'ПСМ'";
            }

            SqlCommand hoursobjcom = new SqlCommand(hoursobj, stud.ReturnConnect());

            int hours = Convert.ToInt32(hoursobjcom.ExecuteScalar());

            hoursObjectBox.Text = hours.ToString();

            stud.ReturnConnect().Close();
        }

        private void selectTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usrButton.Checked == true)
            {
                if (stud.checkHours(inputBox.Text, selectObjectBox.Text, int.Parse(selectTimeBox.Text)))
                {
                    sendButton.Enabled = true;
                }
                else
                    MessageBox.Show("Превышено общее количество часов!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sendButton.Enabled = true;
            }
        }

        private void selectObjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectObjectBox.Text == "Бассейн")
            {
                selectTypeBox.Items.Clear();
                selectTypeBox.Items.Add("Бассейн плавание");
                selectTypeBox.Items.Add("Бассейн аквааэробика");
                selectTypeBox.Items.Add("Бассейн водное поло");
            }
            else if (selectObjectBox.Text == "Стадион")
            {
                selectTypeBox.Items.Clear();
                selectTypeBox.Items.Add("Открытые площадки волейбол");
                selectTypeBox.Items.Add("Запасное поле футбол");
                selectTypeBox.Items.Add("Открытые площадки баскетбол");
                selectTypeBox.Items.Add("Стадион легкая атлетика");
                selectTypeBox.Items.Add("Стадион скандинавская ходьба");
                selectTypeBox.Items.Add("Стадион оздоровительный бег");
            }
            else if (selectObjectBox.Text == "Ледовая арена")
            {
                selectTypeBox.Items.Clear();
                selectTypeBox.Items.Add("Ледовая арена массовое катание");
            }
            else if (selectObjectBox.Text == "Тренажерный зал")
            {
                selectTypeBox.Items.Clear();
                selectTypeBox.Items.Add("Тренажерный зал атлетическая гимнастика");
                selectTypeBox.Items.Add("Тренажерный зал ОФП");
            }
            else if (selectObjectBox.Text == "Фитнесс")
            {
                selectTypeBox.Items.Clear();
                selectTypeBox.Items.Add("Фитнесс");
            }
            selectTypeBox.Text = "Выбрать тип занятия";
            inputBox.Text = "";
        }

        private void selectTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputBox.Enabled = true;
            inputBox.Text = "";
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string idCard = serialPort1.ReadLine();

                int startIndex = idCard.IndexOf("[") + 1;

                int endIndex = idCard.IndexOf("]");

                idCard = idCard.Substring(startIndex, endIndex - startIndex);

                string studnumbquery = $"SELECT СтудНомер FROM Студенты WHERE СтудНомер2 = '{idCard}'";

                SqlCommand commanddb = new SqlCommand(studnumbquery, stud.ReturnConnect());

                stud.ReturnConnect().Open();

                if (commanddb.ExecuteScalar() != null)
                {
                    new Thread(() =>
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            inputBox.Text = ((string)commanddb.ExecuteScalar());
                        }));

                    }).Start();
                }
                else
                {
                    IDADD idAdd = new IDADD();
                }
                
                this.inputBox.TextChanged += this.inputBox_TextChanged;

                }
            catch { }
        }

        //Сканер 1
        private void scannerButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Приложите карту к устройству ввода";
            COM3();
            inputBox.Text = "";
        }

        private void handInputButton_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            label1.Text = "  Введите № Студенческого билета";
            inputBox.Text = "";
        }

        private void skillUpButton_CheckedChanged(object sender, EventArgs e)
        {
            selectObjectBox.Text = "Выбрать объект";
            selectTypeBox.Text = "Выбрать тип занятия";
            selectObjectBox.Enabled = false;
            selectTypeBox.Items.Clear();
            selectTypeBox.Items.AddRange(new string[] { "Волейбол", "Мини-футбол", "Баскетбол", "Плавание", "Настольный теннис", "Легкая атлетика", "Хоккей", "Тяжелая атлетика", "Карате", "Гребля" });
            inputBox.Text = "";
        }

        private void usrButton_CheckedChanged(object sender, EventArgs e)
        {
            selectObjectBox.Text = "Выбрать объект";
            selectTypeBox.Text = "Выбрать тип занятия";
            selectObjectBox.Enabled = true;
            selectTypeBox.Items.Clear();
            inputBox.Text = "";
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void отчётПосещаемостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usrButton.Checked == true)
            {
                if (selectObjectBox.Text != "Выбрать объект")
                {
                    Report report = new Report();
                    report.Connection = $"Дневник.Объект = N'{selectObjectBox.Text}'";
                    report.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не выбран объект! \nВыберите объект.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (skillUpButton.Checked == true)
            {
                if (selectTypeBox.Text != "Выбрать тип занятия")
                {
                    Report report = new Report();
                    report.Connection = $"Дневник.УСР = N'{selectTypeBox.Text}'";
                    report.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не выбран тип занятия! \nВыберите занятия.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Добавить студента кнопка
        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handInputButton.Checked = true;
            serialPort1.Close();
            StudentADD studentADD = new StudentADD();
            studentADD.ShowDialog();
        }

        //Сканер 2 
        private void scannerButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Приложите карту к устройству ввода";
            COM8();
            inputBox.Text = "";
            studentInfoBox.Text = "";
        }
    }
}
