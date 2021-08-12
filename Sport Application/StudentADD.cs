using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Threading;




namespace Sport_Application
{
    public partial class StudentADD : Form
    {
        Student stud = new Student();

        public StudentADD()
        {
            InitializeComponent();
        }

        private bool COM8()
        {
            try
            {
                if (serialPort1.PortName != "COM8")
                {
                    serialPort1.Close();
                    serialPort1.PortName = "COM8";
                    serialPort1.Open();
                    return true;
                }
                else
                {
                    if (serialPort1.PortName == "COM8")
                    {
                        serialPort1.Close();
                        serialPort1.PortName = "COM8";
                        serialPort1.Open();
                        return true;
                    }
                    else { return false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оборудование не подключено! Доступен режим ручного ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool COM3()
        {
            try
            {
                if (serialPort1.PortName != "COM3")
                {
                    serialPort1.Close();
                    serialPort1.PortName = "COM3";
                    serialPort1.Open();
                    return true;
                }
                else
                {
                    if (serialPort1.PortName == "COM3")
                    {
                        serialPort1.Close();
                        serialPort1.PortName = "COM3";
                        serialPort1.Open();
                        return true;
                    }
                    else { return false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оборудование не подключено! Доступен режим ручного ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void StudentADD_Load(object sender, EventArgs e)
        {
            string input = $"SELECT КодГруппы, Группа FROM Группы";
            stud.connectStudent(input, "Group");
            for (int i = 0; i < stud.Dst.Tables["Group"].Rows.Count; i++)
            {
                groupNumberBox.Items.Add(stud.Dst.Tables["Group"].Rows[i][1].ToString());
            }

            passwordBox.PasswordChar = '*';
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            stud.InsertClient(numberBox.Text, idBox.Text, nameBox.Text, groupNumberBox.Text);
            //numberBox.Text = "";
            //nameBox.Text = "";
            //groupNumberBox.Text = "";
            //addStudentButton.Enabled = false;
            //groupNumberBox.Enabled = false;
            //this.Close();
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void selectObjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < stud.Dst.Tables["Group"].Rows.Count; i++)
            {
                if (groupNumberBox.Text == stud.Dst.Tables["Group"].Rows[i][1].ToString())
                {
                    
                    addStudentButton.Enabled = true;
                }
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            groupNumberBox.Enabled = true;
        }
    
        private void idButton_Click(object sender, EventArgs e)
        {
            passwordBox.Visible = true;
            MessageBox.Show("Введите пароль в поле справа от кнопки <<?>>");
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text == "12345")
            {
                idBox.Visible = true;
                idStudentLabel.Visible = true;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string idCard = serialPort1.ReadLine();

                int startIndex = idCard.IndexOf("[") + 1;
                int endIndex = idCard.IndexOf("]");

                idCard = idCard.Substring(startIndex, endIndex - startIndex);

                new Thread(() =>
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        idBox.Text = idCard;
                    }));

                }).Start();

                string com = $"SELECT СтудНомер FROM Студенты WHERE СтудНомер2 = '{idCard}'";

                SqlCommand command = new SqlCommand(com, stud.ReturnConnect());

                stud.ReturnConnect().Open();

                new Thread(() =>
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        numberBox.Text = ((string)command.ExecuteScalar());
                    }));

                }).Start();

                this.numberBox.TextChanged += this.numberBox_TextChanged;
            }
            catch { }
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string namequery = $"SELECT ФИО_Студ FROM Студенты WHERE СтудНомер = '{numberBox.Text}'";

                SqlCommand commanddb = new SqlCommand(namequery, stud.ReturnConnect());

                stud.ReturnConnect().Open();

                nameBox.Text = ((string)commanddb.ExecuteScalar());

                stud.ReturnConnect().Close();

                string numbgroupquery = $"SELECT Группа FROM Студенты join Группы ON Студенты.КодГруппы = Группы.КодГруппы WHERE СтудНомер = '{numberBox.Text}'";

                stud.ReturnConnect().Open();

                SqlCommand command1 = new SqlCommand(numbgroupquery, stud.ReturnConnect());

                groupNumberBox.Text = ((string)command1.ExecuteScalar());

                numberBox.TextChanged += numberBox_TextChanged;
            }

            catch { }

        }

        private void scannerButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (COM8())
                {
                    MessageBox.Show("Приложите карту к устройству ввода");
                    numberBox.Text = "";
                    nameBox.Text = "";
                }
            }
            catch { }
        }

        private void scannerButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (COM3())
                {
                    MessageBox.Show("Приложите карту к устройству ввода");
                    numberBox.Text = "";
                    nameBox.Text = "";
                }
            }
            catch { }
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
