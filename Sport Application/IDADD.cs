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
    public partial class IDADD : Form
    {
        Student stud = new Student();

        public IDADD()
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

        private void scannerButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (COM3())
                {
                    MessageBox.Show("Приложите карту к устройству ввода");
                    numberBox.Text = "";
                    idBox.Text = "";
                }
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
                    idBox.Text = "";
                }
            }
            catch { }
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
            }
            catch { }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                stud.InsertID(idBox.Text, numberBox.Text);
            }
            catch { }
        }
    }
}
