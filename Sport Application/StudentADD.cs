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
            idStudentLabel.ForeColor = Color.Red;
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
            try
            {
                stud.InsertClient(numberBox.Text, idBox.Text, nameBox.Text, groupNumberBox.Text);
            }
            catch { }
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void groupNumberBox_SelectedIndexChanged(object sender, EventArgs e)
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
            passwordLabel.Visible = true;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text == "12345")
            {
                idBox.Visible = true;
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

                idStudentLabel.ForeColor = Color.Green;
            }
            catch { }
        }

        private void scannerButton2_Click(object sender, EventArgs e)
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

        private void scannerButton1_Click(object sender, EventArgs e)
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

        private void handButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            MessageBox.Show("Введите № Студенческого билета");
            numberBox.Text = "";
            groupNumberBox.Text = "";
            nameBox.Text = "";
        }
    }
}
