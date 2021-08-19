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

        //string connectionString = @"Data Source=db1.net.pvbc;" +
        //                    "Initial Catalog = sportapp;" +
        //                    "User Id = sportapp;" +
        //                    "Password = 2eZfa4mSCrnx";

        public string Connection 
        {
           get
            {
                string connectionString = @"Data Source=TOSHIBA;" +
                    "Integrated Security = SSPI;" +
                    "Initial Catalog = sportapp";
                return connectionString;
            }
        }

        public DataSet Dst
        {
            get { return dst; }
        }

        public Student() { }

        public void connectStudent(string c, string a)
        {
            try
            {
                dst.Clear();
                adapter = new SqlDataAdapter(c, Connection);
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

            SqlConnection connectdb = new SqlConnection(Connection);

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

        public void Insert(string numstud, string way, string obj, string usr, int hours)
        {
            try
            {
                SqlConnection connectdb = new SqlConnection(Connection);

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
        public void InsertClientID(string number, string id, string name, string group)
        {
            try
            {
                SqlConnection connectdb = new SqlConnection(Connection);

                connectdb.Open();

                string checkquery = $"Select COUNT(СтудНомер) FROM Студенты Where СтудНомер = '{number}' OR ФИО_Студ = '{name}' OR СтудНомер2 = '{id}'";

                SqlCommand checkcommand = new SqlCommand(checkquery, connectdb);

                if (Convert.ToInt32(checkcommand.ExecuteScalar()) == 0)
                {
                    string addstudentquery = $"DECLARE @numb nvarchar (10) " +
                                             $"SET @numb = (SELECT КодГруппы From Группы Where Группа = '{group}') " +
                                             $"INSERT INTO Студенты(СтудНомер, СтудНомер2, ФИО_Студ, КодГруппы) " +
                                             $"VALUES('{number}', '{id}', '{name}', CONVERT(int, @numb))";

                    SqlCommand addcommand = new SqlCommand(addstudentquery, connectdb);

                    addcommand.ExecuteNonQuery();

                    connectdb.Close();

                    MessageBox.Show("Добавление студента прошло успешно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    connectdb.Close();
                    MessageBox.Show("Проверьте введённые данные.\nВозможно такой студент уже существует!\nЛибо номер ID студенческого билета не получен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {}
        }

        public void InsertClient(string number, string name, string group)
        {
            try
            {
                SqlConnection connectdb = new SqlConnection(Connection);

                connectdb.Open();

                string checkquery = $"Select COUNT(СтудНомер) FROM Студенты Where СтудНомер = '{number}' OR ФИО_Студ = '{name}'";

                SqlCommand checkcommand = new SqlCommand(checkquery, connectdb);

                if (Convert.ToInt32(checkcommand.ExecuteScalar()) == 0)
                {
                    string addstudentquery = $"DECLARE @numb nvarchar (10) " +
                                             $"SET @numb = (SELECT КодГруппы From Группы Where Группа = '{group}') " +
                                             $"INSERT INTO Студенты(СтудНомер, ФИО_Студ, КодГруппы) " +
                                             $"VALUES('{number}', '{name}', CONVERT(int, @numb))";

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
            catch { }
        }

        public void InsertID(string id, string number)
        {
            SqlConnection connectdb = new SqlConnection(Connection);

            string checkquery = $"SELECT COUNT(СтудНомер) FROM Студенты WHERE СтудНомер = '{number}'";

            connectdb.Open();

            SqlCommand checkcommand = new SqlCommand(checkquery, connectdb);

            if (Convert.ToInt32(checkcommand.ExecuteScalar()) != 0)
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
                MessageBox.Show("Проверьте номер студенческого билета \nВозможно такой студент не зарегестрирован!\nЛибо номер ID студенческого билета не получен.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
