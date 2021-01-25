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
        private int minutes=4;
        public Interaction()
        {
            InitializeComponent();
            lbl_minutes.Visible = false;
            btn_conferma.Visible = false;
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
        private void circles()
        {                   
            total_seconds = (minutes * 60) + seconds;          
            timer2.Enabled = true;
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
            if (total_seconds > 0)
            {
                lbl_minutes.Visible = true;
                btn_conferma.Visible = true;
                total_seconds--;
                int minutes = total_seconds / 60;
                int seconds = total_seconds - (minutes * 60);
                this.lbl_minutes.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer2.Stop();
                MessageBox.Show("Finished");
            }
        }
    }
}
