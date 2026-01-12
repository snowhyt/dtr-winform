namespace DTR_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static TimeSpan FollowSched(
            string selectedSchedule,
            DateTimePicker TimeInPicker,
            DateTimePicker TimeOutPicker,
            bool hasBreak,
            DateTimePicker BreakInPicker,
            DateTimePicker BreakOutPicker,
           ) 
        {

            if (string.IsNullOrEmpty(selectedSchedule)) { return TimeSpan.Zero; }
            
            DateTime timeIn = TimeInPicker.Value;
            DateTime timeOut = TimeOutPicker.Value;
            DateTime breakIn = BreakInPicker.Value;
            DateTime breakOut = BreakOutPicker.Value;

            TimeSpan schedIn;
            TimeSpan schedOut;
            TimeSpan schedHours;
            TimeSpan renderedTime;

            switch (selectedSchedule)
            {
                case "4:00AM - 1:00PM":
                    schedIn = new TimeSpan(4, 0, 0);
                    schedOut = new TimeSpan(13, 0, 0);

                    TimeCalculation(TimeInPicker, TimeOutPicker, schedIn, schedOut);

                    if (hasBreak) 
                    {
                        
                    }

                    //if(timeIn < DateTime.Today + schedIn || timeOut >DateTime.Today + schedOut)
                    //{
                    //    timeIn = DateTime.Today + schedIn;
                    //    timeOut = DateTime.Today + schedOut;
                    //    TimeInPicker.Value = timeIn;
                    //    TimeOutPicker.Value = timeOut;
             


                    //    //late
                    //    if(timeIn > DateTime.Today + schedIn )
                    //    {
                    //        TimeSpan lateTime = timeIn - (DateTime.Today + schedIn);
                    //    }

                    //    //undertime
                    //    else if (timeOut < DateTime.Today + schedOut)
                    //    {
                    //        TimeSpan undertime = (DateTime.Today + schedOut) - timeOut;
                    //    }

                    //}

                    break;
                case "8:00AM - 5:00PM":
                    schedIn = new TimeSpan(8, 0, 0);
                    schedOut = new TimeSpan(17, 0, 0);
                    
                    break;

                default:
                    return TimeSpan.Zero;
            }
            return timeOut - timeIn;
        }

        public static void TimeCalculation(
            DateTimePicker TimeInPicker,
            DateTimePicker TimeOutPicker,
            TimeSpan schedIn,
            TimeSpan schedOut) 
        {
            DateTime timeIn = TimeInPicker.Value;
            DateTime timeOut = TimeOutPicker.Value; 

            if (timeIn < DateTime.Today + schedIn || timeOut > DateTime.Today + schedOut)
            {
                timeIn = DateTime.Today + schedIn;
                timeOut = DateTime.Today + schedOut;
                TimeInPicker.Value = timeIn;
                TimeOutPicker.Value = timeOut;



                //late
                if (timeIn > DateTime.Today + schedIn)
                {
                    TimeSpan lateTime = timeIn - (DateTime.Today + schedIn);
                }

                //undertime
                else if (timeOut < DateTime.Today + schedOut)
                {
                    TimeSpan undertime = (DateTime.Today + schedOut) - timeOut;
                }

            }

        }


        public static TimeSpan notFollowSched(
            DateTimePicker TimeInPicker, 
            DateTimePicker TimeOutPicker, 
            bool hasBreak, 
            DateTimePicker BreakInPicker, 
            DateTimePicker BreakOutPicker)
        {
            if (TimeInPicker.Value >= TimeOutPicker.Value)
            {
                // Invalid time range
                return TimeSpan.Zero;
            }
            DateTime timeIn = TimeInPicker.Value;
            DateTime timeOut = TimeOutPicker.Value;

            return timeOut - timeIn;
        }

        //---------------- CALCULATE BUTTON CLICK ------------------------
        private void calculateRenderedTimeBtn_Click(object sender, EventArgs e)
        {
            var selectedSchedule = SchedcomboBox.SelectedItem as string;

            //get pickers
            DateTime timeIn = TimeInPicker.Value;
            DateTime timeOut = TimeOutPicker.Value;
            DateTime breakIn = BreakInPicker.Value;
            DateTime breakOut = BreakOutPicker.Value;
            TimeSpan renderedTime;
    
            //calculate rendered time
            if (WorkRadBtnYes.Checked)
             {
               renderedTime = FollowSched(selectedSchedule, TimeInPicker, TimeOutPicker, DutyRadBtnYes.Checked, BreakInPicker, BreakOutPicker);
            }
            else
            {
                renderedTime = notFollowSched(TimeInPicker, TimeOutPicker, DutyRadBtnYes.Checked, BreakInPicker, BreakOutPicker);


            }

            //break or no break
            if(DutyRadBtnYes.Checked)
            {
                if (breakOut > breakIn)
                {
                    TimeSpan totalWork = renderedTime;
                    TimeSpan breakTime = breakOut - breakIn;

                    renderedTime = totalWork - breakTime;
                }
            }

            RenderedHoursLabel.Text = $"{renderedTime.Hours}";
            RenderedMinsLabel.Text = $"{renderedTime.Minutes}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


 
            WorkRadBtnYes.Checked = true;
            DutyRadBtnYes.Checked = true;
            UpdateRadBtnChecked();

            SchedcomboBox.Items.AddRange(new string[]
            {
                "4:00AM - 1:00PM",
                "5:00AM - 2:00PM",
                "6:00AM - 3:00PM",
                "8:00AM - 5:00PM",
                "9:00AM - 6:00PM",
                "11:30AM - 8:30PM"
            });
        }

        private void UpdateRadBtnChecked()
        {
            SchedcomboBox.Enabled = WorkRadBtnYes.Checked;
            WorkingLabel.Enabled = WorkRadBtnYes.Checked;

            //duty
           
            if(DutyRadBtnYes.Checked == false)
            {
                BreakInPicker.Value = DateTime.Today + TimeSpan.FromHours(0);
                BreakOutPicker.Value = DateTime.Today + TimeSpan.FromHours(0);
                BreakInPicker.Enabled = false;
                BreakOutPicker.Enabled = false;
                BreakInLabel.Enabled = false;
                BreakOutLabel.Enabled = false;
            }
            else
            {
                BreakInPicker.Enabled = true;
                BreakOutPicker.Enabled = true;
                BreakInLabel.Enabled = true;
                BreakOutLabel.Enabled = true;
            }

        }

        private void DutyRadBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadBtnChecked();
        }
        private void DutyRadBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadBtnChecked();
        }
        private void WorkRadBtnYes_CheckedChanged(object sender, EventArgs e)
        {
           UpdateRadBtnChecked();
        }

        private void WorkRadBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadBtnChecked();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinutesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

      

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
