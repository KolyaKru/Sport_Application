namespace Sport_Application
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bufferBox = new System.Windows.Forms.ListBox();
            this.selectObjectBox = new System.Windows.Forms.ComboBox();
            this.selectTimeBox = new System.Windows.Forms.ComboBox();
            this.studentInfoBox = new System.Windows.Forms.TextBox();
            this.hoursObjectBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allHoursBox = new System.Windows.Forms.TextBox();
            this.handInputButton = new System.Windows.Forms.RadioButton();
            this.scannerButton1 = new System.Windows.Forms.RadioButton();
            this.selectTypeBox = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panelTrend = new System.Windows.Forms.Panel();
            this.skillUpButton = new System.Windows.Forms.RadioButton();
            this.usrButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTypeInput = new System.Windows.Forms.Panel();
            this.scannerButton2 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.отчётПосещаемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTrend.SuspendLayout();
            this.panelTypeInput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Enabled = false;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(29, 306);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(374, 29);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(29, 567);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(374, 65);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Записать";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Введите № Студенческого билета";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bufferBox
            // 
            this.bufferBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bufferBox.FormattingEnabled = true;
            this.bufferBox.ItemHeight = 16;
            this.bufferBox.Location = new System.Drawing.Point(411, 36);
            this.bufferBox.Name = "bufferBox";
            this.bufferBox.Size = new System.Drawing.Size(377, 596);
            this.bufferBox.TabIndex = 10;
            // 
            // selectObjectBox
            // 
            this.selectObjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectObjectBox.FormattingEnabled = true;
            this.selectObjectBox.Items.AddRange(new object[] {
            "Бассейн",
            "Стадион",
            "Ледовая арена",
            "Фитнесс",
            "Тренажерный зал"});
            this.selectObjectBox.Location = new System.Drawing.Point(29, 132);
            this.selectObjectBox.Name = "selectObjectBox";
            this.selectObjectBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectObjectBox.Size = new System.Drawing.Size(374, 32);
            this.selectObjectBox.TabIndex = 0;
            this.selectObjectBox.Text = "Выбрать объект";
            this.selectObjectBox.SelectedIndexChanged += new System.EventHandler(this.selectObjectBox_SelectedIndexChanged);
            // 
            // selectTimeBox
            // 
            this.selectTimeBox.Enabled = false;
            this.selectTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTimeBox.FormattingEnabled = true;
            this.selectTimeBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.selectTimeBox.Location = new System.Drawing.Point(29, 528);
            this.selectTimeBox.Name = "selectTimeBox";
            this.selectTimeBox.Size = new System.Drawing.Size(374, 32);
            this.selectTimeBox.TabIndex = 8;
            this.selectTimeBox.Text = "Часы";
            this.selectTimeBox.SelectedIndexChanged += new System.EventHandler(this.selectTimeBox_SelectedIndexChanged);
            // 
            // studentInfoBox
            // 
            this.studentInfoBox.BackColor = System.Drawing.SystemColors.Window;
            this.studentInfoBox.Enabled = false;
            this.studentInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentInfoBox.Location = new System.Drawing.Point(29, 341);
            this.studentInfoBox.Multiline = true;
            this.studentInfoBox.Name = "studentInfoBox";
            this.studentInfoBox.ReadOnly = true;
            this.studentInfoBox.Size = new System.Drawing.Size(374, 41);
            this.studentInfoBox.TabIndex = 3;
            this.studentInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursObjectBox
            // 
            this.hoursObjectBox.BackColor = System.Drawing.SystemColors.Window;
            this.hoursObjectBox.Enabled = false;
            this.hoursObjectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursObjectBox.Location = new System.Drawing.Point(29, 500);
            this.hoursObjectBox.Name = "hoursObjectBox";
            this.hoursObjectBox.ReadOnly = true;
            this.hoursObjectBox.Size = new System.Drawing.Size(374, 22);
            this.hoursObjectBox.TabIndex = 7;
            this.hoursObjectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество отработаных часов на объекте\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество всех отработаных часов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allHoursBox
            // 
            this.allHoursBox.BackColor = System.Drawing.SystemColors.Window;
            this.allHoursBox.Enabled = false;
            this.allHoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allHoursBox.Location = new System.Drawing.Point(29, 430);
            this.allHoursBox.Name = "allHoursBox";
            this.allHoursBox.ReadOnly = true;
            this.allHoursBox.Size = new System.Drawing.Size(374, 22);
            this.allHoursBox.TabIndex = 5;
            this.allHoursBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // handInputButton
            // 
            this.handInputButton.AutoSize = true;
            this.handInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.handInputButton.Location = new System.Drawing.Point(13, 3);
            this.handInputButton.Name = "handInputButton";
            this.handInputButton.Size = new System.Drawing.Size(98, 24);
            this.handInputButton.TabIndex = 11;
            this.handInputButton.Text = "Вручную";
            this.handInputButton.UseVisualStyleBackColor = true;
            this.handInputButton.CheckedChanged += new System.EventHandler(this.handInputButton_CheckedChanged);
            // 
            // scannerButton1
            // 
            this.scannerButton1.AutoSize = true;
            this.scannerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannerButton1.Location = new System.Drawing.Point(117, 3);
            this.scannerButton1.Name = "scannerButton1";
            this.scannerButton1.Size = new System.Drawing.Size(119, 24);
            this.scannerButton1.TabIndex = 12;
            this.scannerButton1.Text = "Сканер №1";
            this.scannerButton1.UseVisualStyleBackColor = true;
            this.scannerButton1.CheckedChanged += new System.EventHandler(this.scannerButton1_CheckedChanged);
            // 
            // selectTypeBox
            // 
            this.selectTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTypeBox.FormattingEnabled = true;
            this.selectTypeBox.Location = new System.Drawing.Point(29, 170);
            this.selectTypeBox.Name = "selectTypeBox";
            this.selectTypeBox.Size = new System.Drawing.Size(374, 32);
            this.selectTypeBox.TabIndex = 13;
            this.selectTypeBox.Text = "Выбрать тип занятия";
            this.selectTypeBox.SelectedIndexChanged += new System.EventHandler(this.selectTypeBox_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(94, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выбрать направление";
            // 
            // panelTrend
            // 
            this.panelTrend.Controls.Add(this.skillUpButton);
            this.panelTrend.Controls.Add(this.usrButton);
            this.panelTrend.Location = new System.Drawing.Point(29, 47);
            this.panelTrend.Name = "panelTrend";
            this.panelTrend.Size = new System.Drawing.Size(374, 79);
            this.panelTrend.TabIndex = 15;
            // 
            // skillUpButton
            // 
            this.skillUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skillUpButton.Location = new System.Drawing.Point(192, 3);
            this.skillUpButton.Name = "skillUpButton";
            this.skillUpButton.Size = new System.Drawing.Size(149, 73);
            this.skillUpButton.TabIndex = 14;
            this.skillUpButton.Text = "Повышение спортивного мастерства";
            this.skillUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skillUpButton.UseVisualStyleBackColor = true;
            this.skillUpButton.CheckedChanged += new System.EventHandler(this.skillUpButton_CheckedChanged);
            // 
            // usrButton
            // 
            this.usrButton.Checked = true;
            this.usrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usrButton.Location = new System.Drawing.Point(3, 3);
            this.usrButton.Name = "usrButton";
            this.usrButton.Size = new System.Drawing.Size(183, 73);
            this.usrButton.TabIndex = 13;
            this.usrButton.TabStop = true;
            this.usrButton.Text = "Управляемая самостоятельная работа";
            this.usrButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usrButton.UseVisualStyleBackColor = true;
            this.usrButton.CheckedChanged += new System.EventHandler(this.usrButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(112, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Выбрать тип ввода";
            // 
            // panelTypeInput
            // 
            this.panelTypeInput.Controls.Add(this.scannerButton2);
            this.panelTypeInput.Controls.Add(this.handInputButton);
            this.panelTypeInput.Controls.Add(this.scannerButton1);
            this.panelTypeInput.Location = new System.Drawing.Point(29, 240);
            this.panelTypeInput.Name = "panelTypeInput";
            this.panelTypeInput.Size = new System.Drawing.Size(374, 36);
            this.panelTypeInput.TabIndex = 17;
            // 
            // scannerButton2
            // 
            this.scannerButton2.AutoSize = true;
            this.scannerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannerButton2.Location = new System.Drawing.Point(242, 3);
            this.scannerButton2.Name = "scannerButton2";
            this.scannerButton2.Size = new System.Drawing.Size(119, 24);
            this.scannerButton2.TabIndex = 13;
            this.scannerButton2.Text = "Сканер №2";
            this.scannerButton2.UseVisualStyleBackColor = true;
            this.scannerButton2.CheckedChanged += new System.EventHandler(this.scannerButton2_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтудентаToolStripMenuItem,
            this.toolStripSeparator1,
            this.отчётПосещаемостиToolStripMenuItem,
            this.toolStripSeparator2,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // отчётПосещаемостиToolStripMenuItem
            // 
            this.отчётПосещаемостиToolStripMenuItem.Name = "отчётПосещаемостиToolStripMenuItem";
            this.отчётПосещаемостиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.отчётПосещаемостиToolStripMenuItem.Text = "Отчёт посещаемости";
            this.отчётПосещаемостиToolStripMenuItem.Click += new System.EventHandler(this.отчётПосещаемостиToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.panelTypeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelTrend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allHoursBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoursObjectBox);
            this.Controls.Add(this.studentInfoBox);
            this.Controls.Add(this.selectTimeBox);
            this.Controls.Add(this.selectObjectBox);
            this.Controls.Add(this.bufferBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTrend.ResumeLayout(false);
            this.panelTypeInput.ResumeLayout(false);
            this.panelTypeInput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox bufferBox;
        private System.Windows.Forms.ComboBox selectObjectBox;
        private System.Windows.Forms.ComboBox selectTimeBox;
        private System.Windows.Forms.TextBox studentInfoBox;
        private System.Windows.Forms.TextBox hoursObjectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox allHoursBox;
        private System.Windows.Forms.RadioButton handInputButton;
        private System.Windows.Forms.RadioButton scannerButton1;
        private System.Windows.Forms.ComboBox selectTypeBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTrend;
        private System.Windows.Forms.RadioButton usrButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelTypeInput;
        public System.Windows.Forms.RadioButton skillUpButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem отчётПосещаемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.RadioButton scannerButton2;
    }
}

