using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sport_Application
{
    class Student
    {
        DataSet dst = new DataSet();
        SqlDataAdapter adapter;
        DataSet dstJournal = new DataSet();
        //string connectionString = @"Data Source=db1.net.pvbc;" +
        //                    "Initial Catalog = sportapp;" +
        //                    "User Id = sportapp;" +
        //                    "Password = 2eZfa4mSCrnx";
        string connectionString = @"Data Source=TOSHIBA;" +
                    "Integrated Security = SSPI;" +
                    "Initial Catalog = sportapp";

        private string id;
        private string obj;
        private int timers;
        private string ysr;
        private string naprav;
        public DataSet Dst
        {
            get { return dst; }
        }

        public string ID
        {
            get { return id; }
        }

        public string Obj
        {
            get { return obj; }
        }

        public int Time
        {
            get { return timers; }
        }
        public string Ysr
        {
            get { return ysr; }
        }
        public string Naprav
        {
            get { return naprav; }
        }
        public Student() { }
        public Student(string id)
        {
            this.id = id;
        }
        public Student(string id, string obj)
        {
            this.id = id;
            this.obj = obj;
        }
        public Student(string id, string naprav, string obj, string ysr, int time)
        {
            this.id = id;
            this.obj = obj;
            this.timers = time;
            this.ysr = ysr;
            this.naprav = naprav;
        }
        public void connectStudent(string c, string a)
        {
            try
            {
                dst.Clear();
                adapter = new SqlDataAdapter(c, connectionString);
                adapter.Fill(dst, a);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public bool checkHours(string id, string obj, int time)
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

            string inputHours = $"SELECT COALESCE (SUM(ОтрабЧасы), 0) FROM Дневник WHERE СтудНомер = '{id}' "+  
                                $"AND Дата BETWEEN CONVERT (datetime, '{startDate}') AND CONVERT (datetime, '{finishDate}') " +
                                $"AND Объект = '{obj}'";

            SqlConnection connectdb = new SqlConnection(connectionString);

            connectdb.Open();

            SqlCommand hourscom = new SqlCommand(inputHours, connectdb);

            int hours = Convert.ToInt32(hourscom.ExecuteScalar());

            switch (obj)
            {
                case "Бассейн":
                    if (hours + time > 85)
                        return false;
                    else
                        return true;
                case "Ледовая арена":
                    if (hours + time > 85)
                        return false;
                    else
                        return true;
                case "Стадион":
                    if (hours + time > 85)
                        return false;
                    else
                        return true;
                case "Тренажерный зал":
                    if (hours + time > 85)
                        return false;
                    else
                        return true;
                case "Фитнесс":
                    if (hours + time > 85)
                        return false;
                    else
                        return true;
                default:
                    return false;
            }
        }

        private void connectJournal(string c, string a)
        {
            try
            {
                dstJournal.Clear();
                adapter = new SqlDataAdapter(c, connectionString);
                adapter.Fill(dstJournal, a);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Insert(string numstud, string way, string obj, string usr, int hours)
        {
            try
            {
                SqlConnection connectdb = new SqlConnection(connectionString);

                string inserthours = $"INSERT INTO Дневник(СтудНомер, Дата, Направление, Объект, УСР, ОтрабЧасы) " +
                    $"VALUES('{numstud}', CONVERT (datetime, '{DateTime.Now}'), '{way}', " +
                    $"'{obj}', '{usr}', {hours})";

                SqlCommand com = new SqlCommand(inserthours,connectdb);

                connectdb.Open();

                com.ExecuteNonQuery();

                connectdb.Close();

                MessageBox.Show("Сохранение прошло успешно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {}
        }
        public void InsertClient(string number, string id, string name, string group)
        {
            SqlConnection connectdb = new SqlConnection(connectionString);

            connectdb.Open();

            string checkquery = $"Select COUNT(СтудНомер) FROM Студенты Where СтудНомер = '{number}' OR ФИО_Студ = '{name}'";

            SqlCommand checkcommand = new SqlCommand(checkquery, connectdb);

            if (Convert.ToInt32(checkcommand.ExecuteScalar()) == 0)
            {
                string addstudentquery = $"DECLARE @numb nvarchar (10) "+
                                         $"SET @numb = (SELECT КодГруппы From Группы Where Группа = '{group}') "+
                                         $"INSERT INTO Студенты(СтудНомер, СтудНомер2, ФИО_Студ, КодГруппы) "+
                                         $"VALUES('{number}', '{id}', '{name}', CONVERT(int, @numb))";

                SqlCommand addcommand = new SqlCommand(addstudentquery, connectdb);

                addcommand.ExecuteNonQuery();

                connectdb.Close();

                MessageBox.Show("Добавление студента прошло успешно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                connectdb.Close();
                MessageBox.Show("Проверьте введённые данные.\nВозможно такой студент уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertID(string id, string number)
        {
            SqlConnection connectdb = new SqlConnection(connectionString);

            string checkquery = $"SELECT COUNT(СтудНомер) FROM Студенты WHERE СтудНомер = '{number}'";

            connectdb.Open();

            SqlCommand checkcommand = new SqlCommand(checkquery, connectdb);

            if (checkcommand.ExecuteScalar() != null)
            {
                string com = $"UPDATE Студенты SET СтудНомер2 = '{id}' WHERE СтудНомер = '{number}'";

                SqlCommand command = new SqlCommand(com, connectdb);

                command.ExecuteNonQuery();

                connectdb.Close();

                MessageBox.Show("Добавление id студенческого билета прошло успешно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                connectdb.Close();
                MessageBox.Show("Проверьте номер студенческого билета \nВозможно такой студент не зарегестрирован!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Check(string s)
        {
            if (Dst.Tables[s].Rows.Count == 0)
            {
                DataRow row = Dst.Tables[s].NewRow();
                row[0] = 0;
                Dst.Tables[s].Rows.Add(row);
            }
        }
    }
}
