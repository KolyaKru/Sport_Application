namespace Sport_Application
{
    partial class StudentADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentADD));
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.numbStudentLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.groupNumberBox = new System.Windows.Forms.ComboBox();
            this.scannerButton2 = new System.Windows.Forms.RadioButton();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.idStudentLabel = new System.Windows.Forms.Label();
            this.scannerButton1 = new System.Windows.Forms.RadioButton();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.handButton = new System.Windows.Forms.RadioButton();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить студента";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Enabled = false;
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentButton.Location = new System.Drawing.Point(163, 328);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(214, 36);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Добавить студента";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // numbStudentLabel
            // 
            this.numbStudentLabel.AutoSize = true;
            this.numbStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbStudentLabel.Location = new System.Drawing.Point(160, 67);
            this.numbStudentLabel.Name = "numbStudentLabel";
            this.numbStudentLabel.Size = new System.Drawing.Size(237, 24);
            this.numbStudentLabel.TabIndex = 2;
            this.numbStudentLabel.Text = "№ студенческого билета";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(243, 123);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "ФИО";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupLabel.Location = new System.Drawing.Point(243, 179);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(73, 24);
            this.groupLabel.TabIndex = 4;
            this.groupLabel.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 5;
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numberBox.Location = new System.Drawing.Point(137, 94);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(276, 26);
            this.numberBox.TabIndex = 6;
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberBox_KeyPress);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.nameBox.Location = new System.Drawing.Point(137, 150);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(276, 26);
            this.nameBox.TabIndex = 7;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // groupNumberBox
            // 
            this.groupNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.groupNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupNumberBox.Enabled = false;
            this.groupNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNumberBox.FormattingEnabled = true;
            this.groupNumberBox.Location = new System.Drawing.Point(137, 206);
            this.groupNumberBox.Name = "groupNumberBox";
            this.groupNumberBox.Size = new System.Drawing.Size(276, 28);
            this.groupNumberBox.TabIndex = 9;
            this.groupNumberBox.SelectedIndexChanged += new System.EventHandler(this.groupNumberBox_SelectedIndexChanged);
            // 
            // scannerButton2
            // 
            this.scannerButton2.AutoSize = true;
            this.scannerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannerButton2.Location = new System.Drawing.Point(403, 36);
            this.scannerButton2.Name = "scannerButton2";
            this.scannerButton2.Size = new System.Drawing.Size(128, 28);
            this.scannerButton2.TabIndex = 10;
            this.scannerButton2.TabStop = true;
            this.scannerButton2.Text = "Сканер №2";
            this.scannerButton2.UseVisualStyleBackColor = true;
            this.scannerButton2.Click += new System.EventHandler(this.scannerButton2_Click);
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.Location = new System.Drawing.Point(133, 296);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(276, 26);
            this.idBox.TabIndex = 11;
            this.idBox.Visible = false;
            // 
            // idButton
            // 
            this.idButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idButton.Location = new System.Drawing.Point(383, 240);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(148, 26);
            this.idButton.TabIndex = 12;
            this.idButton.Text = "Просмотреть ID ";
            this.idButton.UseVisualStyleBackColor = true;
            this.idButton.Click += new System.EventHandler(this.idButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(172, 240);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(205, 26);
            this.passwordBox.TabIndex = 13;
            this.passwordBox.Visible = false;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // idStudentLabel
            // 
            this.idStudentLabel.AutoSize = true;
            this.idStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idStudentLabel.Location = new System.Drawing.Point(159, 269);
            this.idStudentLabel.Name = "idStudentLabel";
            this.idStudentLabel.Size = new System.Drawing.Size(234, 24);
            this.idStudentLabel.TabIndex = 14;
            this.idStudentLabel.Text = "ID студенческого билета";
            // 
            // scannerButton1
            // 
            this.scannerButton1.AutoSize = true;
            this.scannerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scannerButton1.Location = new System.Drawing.Point(199, 36);
            this.scannerButton1.Name = "scannerButton1";
            this.scannerButton1.Size = new System.Drawing.Size(128, 28);
            this.scannerButton1.TabIndex = 15;
            this.scannerButton1.TabStop = true;
            this.scannerButton1.Text = "Сканер №1";
            this.scannerButton1.UseVisualStyleBackColor = true;
            this.scannerButton1.Click += new System.EventHandler(this.scannerButton1_Click);
            // 
            // closeBox
            // 
            this.closeBox.BackgroundImage = global::Sport_Application.Properties.Resources.cross;
            this.closeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBox.Location = new System.Drawing.Point(511, 9);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 16;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // handButton
            // 
            this.handButton.AutoSize = true;
            this.handButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.handButton.Location = new System.Drawing.Point(12, 36);
            this.handButton.Name = "handButton";
            this.handButton.Size = new System.Drawing.Size(104, 28);
            this.handButton.TabIndex = 17;
            this.handButton.TabStop = true;
            this.handButton.Text = "Вручную";
            this.handButton.UseVisualStyleBackColor = true;
            this.handButton.Click += new System.EventHandler(this.handButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(17, 243);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(149, 20);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Введите пароль";
            this.passwordLabel.Visible = false;
            // 
            // StudentADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 375);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.handButton);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.scannerButton1);
            this.Controls.Add(this.scannerButton2);
            this.Controls.Add(this.idStudentLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.idButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.groupNumberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numbStudentLabel);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить студента";
            this.Load += new System.EventHandler(this.StudentADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label numbStudentLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox groupNumberBox;
        private System.Windows.Forms.RadioButton scannerButton2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button idButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label idStudentLabel;
        private System.Windows.Forms.RadioButton scannerButton1;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.RadioButton handButton;
        private System.Windows.Forms.Label passwordLabel;
    }
}