namespace DTR_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            calcuRenderedBtn = new Button();
            nameLabel = new Label();
            panel1 = new Panel();
            StraightDutyGrpBox = new GroupBox();
            label4 = new Label();
            DutyRadBtnNo = new RadioButton();
            DutyRadBtnYes = new RadioButton();
            WorkingSchedGrpBox = new GroupBox();
            WorkingSchedLabel = new Label();
            WorkRadBtnNo = new RadioButton();
            WorkRadBtnYes = new RadioButton();
            groupBox2 = new GroupBox();
            TimeOutPicker = new DateTimePicker();
            BreakOutPicker = new DateTimePicker();
            BreakOutLabel = new Label();
            label32 = new Label();
            groupBox1 = new GroupBox();
            BreakInPicker = new DateTimePicker();
            TimeInPicker = new DateTimePicker();
            RenderedInLabel = new Label();
            BreakInLabel = new Label();
            WorkingLabel = new Label();
            SchedcomboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            EmpNamecomboBox = new ComboBox();
            EmpIdLabel = new Label();
            DatePicker = new DateTimePicker();
            dateLabel = new Label();
            empIDTextbox = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label9 = new Label();
            label14 = new Label();
            RenderedMinsLabel = new Label();
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            RenderedHoursLabel = new Label();
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            noBtn = new RadioButton();
            yesBtn = new RadioButton();
            label10 = new Label();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dateTimePicker5 = new DateTimePicker();
            label18 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label17 = new Label();
            label20 = new Label();
            label19 = new Label();
            button2 = new Button();
            label11 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label26 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            fontDialog1 = new FontDialog();
            panel4 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            StraightDutyGrpBox.SuspendLayout();
            WorkingSchedGrpBox.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // calcuRenderedBtn
            // 
            calcuRenderedBtn.Location = new Point(306, 430);
            calcuRenderedBtn.Name = "calcuRenderedBtn";
            calcuRenderedBtn.Size = new Size(184, 27);
            calcuRenderedBtn.TabIndex = 0;
            calcuRenderedBtn.Text = "Calculate Rendered Time";
            calcuRenderedBtn.UseVisualStyleBackColor = true;
            calcuRenderedBtn.Click += calculateRenderedTimeBtn_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(225, 108);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 15);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "EmpName";
            nameLabel.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(StraightDutyGrpBox);
            panel1.Controls.Add(WorkingSchedGrpBox);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(WorkingLabel);
            panel1.Controls.Add(SchedcomboBox);
            panel1.Controls.Add(calcuRenderedBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EmpNamecomboBox);
            panel1.Controls.Add(EmpIdLabel);
            panel1.Controls.Add(DatePicker);
            panel1.Controls.Add(dateLabel);
            panel1.Controls.Add(empIDTextbox);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 474);
            panel1.TabIndex = 3;
            panel1.Tag = "";
            panel1.Paint += panel1_Paint;
            // 
            // StraightDutyGrpBox
            // 
            StraightDutyGrpBox.Controls.Add(label4);
            StraightDutyGrpBox.Controls.Add(DutyRadBtnNo);
            StraightDutyGrpBox.Controls.Add(DutyRadBtnYes);
            StraightDutyGrpBox.Location = new Point(261, 224);
            StraightDutyGrpBox.Name = "StraightDutyGrpBox";
            StraightDutyGrpBox.Size = new Size(229, 43);
            StraightDutyGrpBox.TabIndex = 25;
            StraightDutyGrpBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 17);
            label4.Name = "label4";
            label4.Size = new Size(77, 16);
            label4.TabIndex = 22;
            label4.Text = "Has Break?";
            // 
            // DutyRadBtnNo
            // 
            DutyRadBtnNo.AutoSize = true;
            DutyRadBtnNo.Location = new Point(171, 16);
            DutyRadBtnNo.Name = "DutyRadBtnNo";
            DutyRadBtnNo.Size = new Size(41, 19);
            DutyRadBtnNo.TabIndex = 23;
            DutyRadBtnNo.TabStop = true;
            DutyRadBtnNo.Text = "No";
            DutyRadBtnNo.UseVisualStyleBackColor = true;
            DutyRadBtnNo.CheckedChanged += DutyRadBtnNo_CheckedChanged;
            // 
            // DutyRadBtnYes
            // 
            DutyRadBtnYes.AutoSize = true;
            DutyRadBtnYes.Location = new Point(114, 16);
            DutyRadBtnYes.Name = "DutyRadBtnYes";
            DutyRadBtnYes.Size = new Size(42, 19);
            DutyRadBtnYes.TabIndex = 21;
            DutyRadBtnYes.TabStop = true;
            DutyRadBtnYes.Text = "Yes";
            DutyRadBtnYes.UseVisualStyleBackColor = true;
            DutyRadBtnYes.CheckedChanged += DutyRadBtnYes_CheckedChanged;
            // 
            // WorkingSchedGrpBox
            // 
            WorkingSchedGrpBox.Controls.Add(WorkingSchedLabel);
            WorkingSchedGrpBox.Controls.Add(WorkRadBtnNo);
            WorkingSchedGrpBox.Controls.Add(WorkRadBtnYes);
            WorkingSchedGrpBox.Location = new Point(28, 179);
            WorkingSchedGrpBox.Name = "WorkingSchedGrpBox";
            WorkingSchedGrpBox.Size = new Size(462, 43);
            WorkingSchedGrpBox.TabIndex = 24;
            WorkingSchedGrpBox.TabStop = false;
            // 
            // WorkingSchedLabel
            // 
            WorkingSchedLabel.AutoSize = true;
            WorkingSchedLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            WorkingSchedLabel.Location = new Point(21, 17);
            WorkingSchedLabel.Name = "WorkingSchedLabel";
            WorkingSchedLabel.Size = new Size(158, 16);
            WorkingSchedLabel.TabIndex = 22;
            WorkingSchedLabel.Text = "Follow Working Sched?";
            WorkingSchedLabel.Click += label4_Click;
            // 
            // WorkRadBtnNo
            // 
            WorkRadBtnNo.AutoSize = true;
            WorkRadBtnNo.Location = new Point(289, 16);
            WorkRadBtnNo.Name = "WorkRadBtnNo";
            WorkRadBtnNo.Size = new Size(41, 19);
            WorkRadBtnNo.TabIndex = 23;
            WorkRadBtnNo.TabStop = true;
            WorkRadBtnNo.Text = "No";
            WorkRadBtnNo.UseVisualStyleBackColor = true;
            WorkRadBtnNo.CheckedChanged += WorkRadBtnNo_CheckedChanged;
            // 
            // WorkRadBtnYes
            // 
            WorkRadBtnYes.AutoSize = true;
            WorkRadBtnYes.Location = new Point(215, 16);
            WorkRadBtnYes.Name = "WorkRadBtnYes";
            WorkRadBtnYes.Size = new Size(42, 19);
            WorkRadBtnYes.TabIndex = 21;
            WorkRadBtnYes.TabStop = true;
            WorkRadBtnYes.Text = "Yes";
            WorkRadBtnYes.UseVisualStyleBackColor = true;
            WorkRadBtnYes.CheckedChanged += WorkRadBtnYes_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TimeOutPicker);
            groupBox2.Controls.Add(BreakOutPicker);
            groupBox2.Controls.Add(BreakOutLabel);
            groupBox2.Controls.Add(label32);
            groupBox2.Location = new Point(28, 346);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 69);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // TimeOutPicker
            // 
            TimeOutPicker.CustomFormat = "hh:mm tt";
            TimeOutPicker.Format = DateTimePickerFormat.Custom;
            TimeOutPicker.Location = new Point(297, 28);
            TimeOutPicker.Name = "TimeOutPicker";
            TimeOutPicker.ShowUpDown = true;
            TimeOutPicker.Size = new Size(149, 23);
            TimeOutPicker.TabIndex = 12;
            // 
            // BreakOutPicker
            // 
            BreakOutPicker.CustomFormat = "hh:mm tt";
            BreakOutPicker.Format = DateTimePickerFormat.Custom;
            BreakOutPicker.Location = new Point(72, 28);
            BreakOutPicker.Name = "BreakOutPicker";
            BreakOutPicker.ShowUpDown = true;
            BreakOutPicker.Size = new Size(149, 23);
            BreakOutPicker.TabIndex = 10;
            // 
            // BreakOutLabel
            // 
            BreakOutLabel.AutoSize = true;
            BreakOutLabel.Location = new Point(7, 34);
            BreakOutLabel.Name = "BreakOutLabel";
            BreakOutLabel.Size = new Size(59, 15);
            BreakOutLabel.TabIndex = 11;
            BreakOutLabel.Text = "Break Out";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(234, 34);
            label32.Name = "label32";
            label32.Size = new Size(57, 15);
            label32.TabIndex = 13;
            label32.Text = "Time Out";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BreakInPicker);
            groupBox1.Controls.Add(TimeInPicker);
            groupBox1.Controls.Add(RenderedInLabel);
            groupBox1.Controls.Add(BreakInLabel);
            groupBox1.Location = new Point(28, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 69);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // BreakInPicker
            // 
            BreakInPicker.CustomFormat = "hh:mm tt";
            BreakInPicker.Format = DateTimePickerFormat.Custom;
            BreakInPicker.Location = new Point(297, 28);
            BreakInPicker.Name = "BreakInPicker";
            BreakInPicker.ShowUpDown = true;
            BreakInPicker.Size = new Size(149, 23);
            BreakInPicker.TabIndex = 12;
            // 
            // TimeInPicker
            // 
            TimeInPicker.Cursor = Cursors.IBeam;
            TimeInPicker.CustomFormat = "hh:mm tt";
            TimeInPicker.Format = DateTimePickerFormat.Custom;
            TimeInPicker.Location = new Point(72, 28);
            TimeInPicker.Name = "TimeInPicker";
            TimeInPicker.ShowUpDown = true;
            TimeInPicker.Size = new Size(149, 23);
            TimeInPicker.TabIndex = 10;
            TimeInPicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // RenderedInLabel
            // 
            RenderedInLabel.AutoSize = true;
            RenderedInLabel.Location = new Point(7, 34);
            RenderedInLabel.Name = "RenderedInLabel";
            RenderedInLabel.Size = new Size(47, 15);
            RenderedInLabel.TabIndex = 11;
            RenderedInLabel.Text = "Time In";
            RenderedInLabel.Click += label3_Click;
            // 
            // BreakInLabel
            // 
            BreakInLabel.AutoSize = true;
            BreakInLabel.Location = new Point(233, 34);
            BreakInLabel.Name = "BreakInLabel";
            BreakInLabel.Size = new Size(49, 15);
            BreakInLabel.TabIndex = 13;
            BreakInLabel.Text = "Break In";
            BreakInLabel.Click += label3_Click_1;
            // 
            // WorkingLabel
            // 
            WorkingLabel.AutoSize = true;
            WorkingLabel.Location = new Point(28, 242);
            WorkingLabel.Name = "WorkingLabel";
            WorkingLabel.Size = new Size(103, 15);
            WorkingLabel.TabIndex = 18;
            WorkingLabel.Text = "Working Schedule";
            WorkingLabel.Click += label6_Click;
            // 
            // SchedcomboBox
            // 
            SchedcomboBox.FormattingEnabled = true;
            SchedcomboBox.ItemHeight = 15;
            SchedcomboBox.Location = new Point(137, 238);
            SchedcomboBox.Name = "SchedcomboBox";
            SchedcomboBox.Size = new Size(118, 23);
            SchedcomboBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 147);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 9;
            label2.Text = "Rendered Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 8;
            label1.Text = "Employee Information";
            label1.Click += label1_Click_1;
            // 
            // EmpNamecomboBox
            // 
            EmpNamecomboBox.FormattingEnabled = true;
            EmpNamecomboBox.Location = new Point(306, 105);
            EmpNamecomboBox.Name = "EmpNamecomboBox";
            EmpNamecomboBox.Size = new Size(184, 23);
            EmpNamecomboBox.TabIndex = 7;
            // 
            // EmpIdLabel
            // 
            EmpIdLabel.AutoSize = true;
            EmpIdLabel.Location = new Point(41, 113);
            EmpIdLabel.Name = "EmpIdLabel";
            EmpIdLabel.Size = new Size(45, 15);
            EmpIdLabel.TabIndex = 6;
            EmpIdLabel.Text = "Emp ID";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(116, 71);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(204, 23);
            DatePicker.TabIndex = 5;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(42, 77);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 15);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date";
            // 
            // empIDTextbox
            // 
            empIDTextbox.Location = new Point(116, 105);
            empIDTextbox.Name = "empIDTextbox";
            empIDTextbox.Size = new Size(92, 23);
            empIDTextbox.TabIndex = 3;
            empIDTextbox.TextChanged += textBox1_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(272, 39);
            label16.Name = "label16";
            label16.Size = new Size(38, 45);
            label16.TabIndex = 28;
            label16.Text = "0";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.Location = new Point(270, 94);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 27;
            label15.Text = "Hours";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(349, 94);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 26;
            label9.Text = "Minutes";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(115, 94);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 25;
            label14.Text = "Minutes";
            // 
            // RenderedMinsLabel
            // 
            RenderedMinsLabel.AutoSize = true;
            RenderedMinsLabel.BackColor = Color.Transparent;
            RenderedMinsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RenderedMinsLabel.ForeColor = Color.LimeGreen;
            RenderedMinsLabel.Location = new Point(112, 39);
            RenderedMinsLabel.Name = "RenderedMinsLabel";
            RenderedMinsLabel.Size = new Size(56, 45);
            RenderedMinsLabel.TabIndex = 24;
            RenderedMinsLabel.Text = "45";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(46, 94);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 23;
            label12.Text = "Hours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 9);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 22;
            label7.Text = "Rendered Time";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(349, 39);
            label8.Name = "label8";
            label8.Size = new Size(56, 45);
            label8.TabIndex = 20;
            label8.Text = "45";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 9);
            label5.Name = "label5";
            label5.Size = new Size(171, 30);
            label5.TabIndex = 16;
            label5.Text = "Late/UnderTime";
            label5.Click += label5_Click;
            // 
            // RenderedHoursLabel
            // 
            RenderedHoursLabel.AutoSize = true;
            RenderedHoursLabel.BackColor = Color.Transparent;
            RenderedHoursLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RenderedHoursLabel.ForeColor = Color.LimeGreen;
            RenderedHoursLabel.Location = new Point(48, 39);
            RenderedHoursLabel.Name = "RenderedHoursLabel";
            RenderedHoursLabel.Size = new Size(38, 45);
            RenderedHoursLabel.TabIndex = 15;
            RenderedHoursLabel.Text = "7";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(noBtn);
            panel2.Controls.Add(yesBtn);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(552, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 81);
            panel2.TabIndex = 4;
            // 
            // noBtn
            // 
            noBtn.AutoSize = true;
            noBtn.Location = new Point(198, 49);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(41, 19);
            noBtn.TabIndex = 11;
            noBtn.TabStop = true;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = true;
            // 
            // yesBtn
            // 
            yesBtn.AutoSize = true;
            yesBtn.Location = new Point(114, 49);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(42, 19);
            yesBtn.TabIndex = 10;
            yesBtn.TabStop = true;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = true;
            yesBtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 15);
            label10.Name = "label10";
            label10.Size = new Size(340, 18);
            label10.TabIndex = 9;
            label10.Text = "Does the selected employee have overtime?";
            label10.Click += label10_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(552, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 253);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker5);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(dateTimePicker4);
            groupBox3.Controls.Add(label17);
            groupBox3.Location = new Point(31, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(305, 108);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Overtime Time Duration";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.CustomFormat = "hh:mm tt";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.Location = new Point(83, 28);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.ShowUpDown = true;
            dateTimePicker5.Size = new Size(149, 23);
            dateTimePicker5.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(30, 34);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 32;
            label18.Text = "Time In";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "hh:mm tt";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(83, 69);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.Size = new Size(149, 23);
            dateTimePicker4.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 75);
            label17.Name = "label17";
            label17.Size = new Size(57, 15);
            label17.TabIndex = 34;
            label17.Text = "Time Out";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(163, 52);
            label20.Name = "label20";
            label20.Size = new Size(23, 15);
            label20.TabIndex = 36;
            label20.Text = "No";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(52, 52);
            label19.Name = "label19";
            label19.Size = new Size(105, 15);
            label19.TabIndex = 35;
            label19.Text = "Is Night Premium?";
            label19.Click += label19_Click;
            // 
            // button2
            // 
            button2.Location = new Point(165, 206);
            button2.Name = "button2";
            button2.Size = new Size(171, 27);
            button2.TabIndex = 30;
            button2.Text = "Calculate Overtime";
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(31, 14);
            label11.Name = "label11";
            label11.Size = new Size(104, 30);
            label11.TabIndex = 29;
            label11.Text = "Overtime";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.DarkOrange;
            label27.Location = new Point(705, 39);
            label27.Name = "label27";
            label27.Size = new Size(38, 45);
            label27.TabIndex = 38;
            label27.Text = "0";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label28.Location = new Point(703, 94);
            label28.Name = "label28";
            label28.Size = new Size(40, 15);
            label28.TabIndex = 37;
            label28.Text = "Hours";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label29.Location = new Point(782, 94);
            label29.Name = "label29";
            label29.Size = new Size(49, 15);
            label29.TabIndex = 36;
            label29.Text = "Minutes";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.DarkOrange;
            label30.Location = new Point(782, 39);
            label30.Name = "label30";
            label30.Size = new Size(56, 45);
            label30.TabIndex = 35;
            label30.Text = "45";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(694, 9);
            label26.Name = "label26";
            label26.Size = new Size(165, 30);
            label26.TabIndex = 34;
            label26.Text = "Night Premium";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.RoyalBlue;
            label21.Location = new Point(494, 39);
            label21.Name = "label21";
            label21.Size = new Size(38, 45);
            label21.TabIndex = 33;
            label21.Text = "0";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.Location = new Point(492, 94);
            label22.Name = "label22";
            label22.Size = new Size(40, 15);
            label22.TabIndex = 32;
            label22.Text = "Hours";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label23.Location = new Point(571, 94);
            label23.Name = "label23";
            label23.Size = new Size(49, 15);
            label23.TabIndex = 31;
            label23.Text = "Minutes";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.RoyalBlue;
            label24.Location = new Point(571, 39);
            label24.Name = "label24";
            label24.Size = new Size(56, 45);
            label24.TabIndex = 30;
            label24.Text = "45";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(504, 9);
            label25.Name = "label25";
            label25.Size = new Size(107, 30);
            label25.TabIndex = 29;
            label25.Text = "OverTime";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label27);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label29);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(RenderedMinsLabel);
            panel4.Controls.Add(label30);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(RenderedHoursLabel);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label22);
            panel4.Location = new Point(12, 492);
            panel4.Name = "panel4";
            panel4.Size = new Size(910, 114);
            panel4.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button1);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(930, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(143, 594);
            panel5.TabIndex = 40;
            // 
            // button1
            // 
            button1.Location = new Point(3, 497);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 5;
            button1.Text = "Save Record";
            button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(3, 546);
            button8.Name = "button8";
            button8.Size = new Size(137, 43);
            button8.TabIndex = 4;
            button8.Text = "Exit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 147);
            button7.Name = "button7";
            button7.Size = new Size(137, 43);
            button7.TabIndex = 3;
            button7.Text = "Import To Excel";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 100);
            button6.Name = "button6";
            button6.Size = new Size(137, 43);
            button6.TabIndex = 2;
            button6.Text = "Export To  Excel";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 52);
            button5.Name = "button5";
            button5.Size = new Size(137, 43);
            button5.TabIndex = 1;
            button5.Text = "Add Employee";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(137, 43);
            button4.TabIndex = 0;
            button4.Text = "View Records";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1083, 616);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "DTR Calculator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            StraightDutyGrpBox.ResumeLayout(false);
            StraightDutyGrpBox.PerformLayout();
            WorkingSchedGrpBox.ResumeLayout(false);
            WorkingSchedGrpBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button calcuRenderedBtn;
        private Label nameLabel;
        private Panel panel1;
        private DateTimePicker DatePicker;
        private Label dateLabel;
        private TextBox empIDTextbox;
        private Label EmpIdLabel;
        private ComboBox EmpNamecomboBox;
        private Label label1;
        private Label label2;
        private Label RenderedInLabel;
        private DateTimePicker TimeInPicker;
        private Label BreakInLabel;
        private DateTimePicker BreakInPicker;
        private Label RenderedHoursLabel;
        private Label label5;
        private Label WorkingLabel;
        private ComboBox SchedcomboBox;
        private BindingSource bindingSource1;
        private Label label8;
        private Panel panel2;
        private Label label10;
        private RadioButton yesBtn;
        private RadioButton noBtn;
        private Panel panel3;
        private Label label7;
        private Label label16;
        private Label label15;
        private Label label9;
        private Label label14;
        private Label RenderedMinsLabel;
        private Label label12;
        private Button button2;
        private Label label17;
        private DateTimePicker dateTimePicker4;
        private Label label18;
        private DateTimePicker dateTimePicker5;
        private Label label11;
        private Label label19;
        private Label label20;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label26;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private FontDialog fontDialog1;
        private Panel panel4;
        private Panel panel5;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker TimeOutPicker;
        private DateTimePicker BreakOutPicker;
        private Label BreakOutLabel;
        private Label label32;
        private GroupBox groupBox3;
        private Button button1;
        private RadioButton WorkRadBtnYes;
        private Label WorkingSchedLabel;
        private RadioButton WorkRadBtnNo;
        private GroupBox WorkingSchedGrpBox;
        private GroupBox StraightDutyGrpBox;
        private Label label4;
        private RadioButton DutyRadBtnNo;
        private RadioButton DutyRadBtnYes;
    }
}
