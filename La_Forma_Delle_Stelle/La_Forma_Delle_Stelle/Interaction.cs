﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Forma_Delle_Stelle
{
    public partial class Interaction : UserControl
    {
        public Main parentForm { get; set; }
        public int timeleft = 6;
        public int counter_responses = 0;
        public int timer_game = 0;
        private int total_seconds;
        private int seconds=0;
        private int minutes=2;
        public int number_circle;
        public Interaction()
        {
            InitializeComponent();
            resetOperations();
            
        }
        private void resetOperations()
        {
            lbl_minutes.Visible = false;
            btn_conferma.Visible = false;
            txt_answers.Visible = false;
            Circle1.Visible = false;
            Circle2.Visible = false;
            lbl_Error.Visible = false;
            op1.Visible = false;
            op2.Visible = false;
            op3.Visible = false;
            op4.Visible = false;
            op5.Visible = false;
            op6.Visible = false;
            op1.Parent = Circle1;
            op2.Parent = Circle1;
            op3.Parent = Circle1;
            op4.Parent = Circle2;
            op5.Parent = Circle2;
            op6.Parent = Circle2;
            Point up = new Point(120, 90);
            Point middle = new Point(120, 190);
            Point bottom = new Point(120, 290);
            op1.Location = up;
            op2.Location = middle;
            op3.Location = bottom;
            op4.Location = up;
            op5.Location = middle;
            op6.Location = bottom;

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

        private void Interaction_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        public void circles()
        {                      
            total_seconds = (minutes * 60) + seconds;
            timer2.Enabled = true;
            char[] operators = { '+', '-', '*', '/' };
            Random number = new Random();
            number_circle = number.Next(1, 3);
            Circle1.Visible = true;
            Circle2.Visible = true;
            if (number_circle == 1)
            {            
                op1.Visible = true;
                op2.Visible = true;
                op3.Visible = true;
            }
            else 
            {
                op4.Visible = true;
                op5.Visible = true;
                op6.Visible = true;
            }

        }
        public string[] operations1(int i)
        {
            string[] operations = new string[3];

            return operations;
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                timerLabel.Text = timeleft.ToString();
            }
            else if (timeleft == 0)
            {
                this.timer1.Stop();
                timerLabel.Enabled = false;
                timerLabel.Visible = false;
                timer_game = 1;
                circles();
            }
        }
        

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (total_seconds > 10)
            {
                lbl_minutes.Visible = true;
                btn_conferma.Visible = true;
                txt_answers.Visible = true;
                total_seconds--;
                int minutes = total_seconds / 60;
                int seconds = total_seconds - (minutes * 60);
                if (seconds >=10)
                this.lbl_minutes.Text = minutes.ToString() + ":" + seconds.ToString();
                else if (seconds <10)
                this.lbl_minutes.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
            }
            else if (total_seconds<=10)
            {
                total_seconds--;
                int minutes = total_seconds / 60;
                int seconds = total_seconds - (minutes * 60);
                this.lbl_minutes.ForeColor = Color.Red;
                this.lbl_minutes.Text =  minutes.ToString() + ":" + "0" + seconds.ToString();
            }
            else if (total_seconds==0)
            {
                this.timer2.Stop();
                MessageBox.Show("Finished");
            }
        }
    }
}
