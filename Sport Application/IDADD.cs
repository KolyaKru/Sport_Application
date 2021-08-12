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

        private void scannerButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void scannerButton2_CheckedChanged(object sender, EventArgs e)
        {

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
