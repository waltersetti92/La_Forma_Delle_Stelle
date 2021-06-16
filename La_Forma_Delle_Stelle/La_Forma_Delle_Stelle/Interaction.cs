using System;
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
        public int number_star=1;
        public string put_started;
        public string put_wait_data;
        public string get_status_uda;
        public int round_correct;
        public Interaction()
        {
            InitializeComponent();
            resetOperations();
            round_correct = 1;
            put_started = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=2&k=7";
            put_wait_data = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=2&k=14";
            get_status_uda = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/get/?i=2";
        }
        private void resetOperations()
        {
            lbl_minutes.Visible = false;
            //btn_conferma.Visible = false;
            //txt_answers.Visible = false;
            Circle1.Visible = false;
            Circle2.Visible = false;
            //lbl_Error.Visible = false;
            op1.Visible = false;
            op2.Visible = false;
            op3.Visible = false;
            op4.Visible = false;
            op5.Visible = false;
            op6.Visible = false;
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            star6.Visible = false;
            star7.Visible = false;
            lbl_Alkaid.Visible = false;
            lbl_Mizar.Visible = false;
            lbl_alioth.Visible = false;
            lbl_Megrez.Visible = false;
            lbl_Dubhe.Visible = false;
            lbl_Merak.Visible = false;
            lbl_Phecda.Visible = false;
            lbl_outoftime.Visible = false;
            Feedback.Visible = false;
            op1.Parent = Circle1;
            op2.Parent = Circle1;
            op3.Parent = Circle1;
            op4.Parent = Circle2;
            op5.Parent = Circle2;
            op6.Parent = Circle2;
            Point up = new Point(90, 90);
            Point middle = new Point(90, 190);
            Point bottom = new Point(90, 290);
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
            total_seconds = (minutes * 60) + seconds;
            timer1.Start();
        }
        public void circles()
        {
            timer2.Start();
            switch (number_star)
            {
                case 1:
                    if (round_correct == 1)
                    { //12 
                        op1.Text = "3+4";
                        this.Update();
                        op2.Text = "6+2";
                        this.Update();
                        op3.Text = "15-3";
                        this.Update();
                        op4.Text = "7-3";
                        this.Update();
                        op5.Text = "5+1";
                        this.Update();
                        op6.Text = "10+2";
                        this.Update();
                    }
                    break;
                case 2:
                    if (round_correct == 1)
                    {
                        op1.Text = "4+5";
                        this.Update();
                        op2.Text = "3-2";
                        this.Update();
                        op3.Text = "11+1";
                        this.Update();
                        op4.Text = "2+2";
                        this.Update();
                        op5.Text = "7-4";
                        this.Update();
                        op6.Text = "14-5";
                        this.Update();
                        break;
                    }
                    else if (round_correct == 2)
                    {
                        // 11
                        op1.Text = "6+1";
                        this.Update();
                        op2.Text = "9-5";
                        this.Update();
                        op3.Text = "12-1";
                        this.Update();
                        op4.Text = "8+3";
                        this.Update();
                        op5.Text = "6-5";
                        this.Update();
                        op6.Text = "19-4";
                        this.Update();
                        break;
                    }
                    else if (round_correct == 3)
                    {
                        //8
                        op1.Text = "13-9";
                        this.Update();
                        op2.Text = "5+3";
                        this.Update();
                        op3.Text = "17-7";
                        this.Update();
                        op4.Text = "22-14";
                        this.Update();
                        op5.Text = "15+8";
                        this.Update();
                        op6.Text = "10-3";
                        this.Update();
                        break;
                    }
                    else if (round_correct == 4)
                    {
                        op1.Text = "4+5";
                        this.Update();
                        op2.Text = "3-2";
                        this.Update();
                        op3.Text = "11+1";
                        this.Update();
                        op4.Text = "2+2";
                        this.Update();
                        op5.Text = "7-4";
                        this.Update();
                        op6.Text = "14-5";
                        this.Update();
                        break;
                    }
                    else if (round_correct == 5)
                    {
                        op1.Text = "4+5";
                        this.Update();
                        op2.Text = "3-2";
                        this.Update();
                        op3.Text = "11+1";
                        this.Update();
                        op4.Text = "2+2";
                        this.Update();
                        op5.Text = "7-4";
                        this.Update();
                        op6.Text = "14-5";
                        this.Update();
                        break;
                    }
                    else if (round_correct == 6)
                    {
                        op1.Text = "4+5";
                        this.Update();
                        op2.Text = "3-2";
                        this.Update();
                        op3.Text = "11+1";
                        this.Update();
                        op4.Text = "2+2";
                        this.Update();
                        op5.Text = "7-4";
                        this.Update();
                        op6.Text = "14-5";
                        this.Update();
                        break;
                    }
                    else if (round_correct == 7)
                    {
                        op1.Text = "4+5";
                        this.Update();
                        op2.Text = "3-2";
                        this.Update();
                        op3.Text = "11+1";
                        this.Update();
                        op4.Text = "2+2";
                        this.Update();
                        op5.Text = "7-4";
                        this.Update();
                        op6.Text = "14-5";
                        this.Update();
                        break;
                    }
                    break;
                case 3:
                    op1.Text = "9-2";
                    this.Update();
                    op2.Text = "6-3";
                    this.Update();
                    op3.Text = "4+2";
                    this.Update();
                    op4.Text = "5+1";
                    this.Update();
                    op5.Text = "10-2";
                    this.Update();
                    op6.Text = "7+6";
                    this.Update();
                    break;
                case 4:
                    op1.Text = "4x6";
                    this.Update();
                    op2.Text = "9+6";
                    this.Update();
                    op3.Text = "2x5";
                    this.Update();
                    op4.Text = "16-5";
                    this.Update();
                    op5.Text = "4+4";
                    this.Update();
                    op6.Text = "3x5";
                    this.Update();
                    break;
                case 5:
                    op1.Text = "7x5";
                    this.Update();
                    op2.Text = "3x3";
                    this.Update();
                    op3.Text = "5x4";
                    this.Update();
                    op4.Text = "12+3";
                    this.Update();
                    op5.Text = "10x2";
                    this.Update();
                    op6.Text = "9x4";
                    this.Update();
                    break;
                case 6:
                    op1.Text = "8x3";
                    this.Update();
                    op2.Text = "30/5";
                    this.Update();
                    op3.Text = "64/8";
                    this.Update();
                    op4.Text = "28/7";
                    this.Update();
                    op5.Text = "22x3";
                    this.Update();
                    op6.Text = "72/9";
                    this.Update();
                    break;
                case 7:
                    op1.Text = "36/4";
                    this.Update();
                    op2.Text = "12x2";
                    this.Update();
                    op3.Text = "9x7";
                    this.Update();
                    op4.Text = "6x7";
                    this.Update();
                    op5.Text = "3x8";
                    this.Update();
                    op6.Text = "42/6";
                    this.Update();
                    break;

            }
            op1.Visible = true;
            op2.Visible = true;
            op3.Visible = true;
            op4.Visible = true;
            op5.Visible = true;
            op6.Visible = true;
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {
            
        }
        public void Correct_Answer()
        {
            parentForm.playbackResourceAudio("success");
            Feedback.ForeColor = Color.Lime;
            Feedback.Visible = true;
            Feedback.Text = "RISPOSTA CORRETTA";
            this.Update();
        }
        public void Wrong_Answer()
        {
            parentForm.playbackResourceAudio("failure");
            Feedback.ForeColor = Color.Red;
            Feedback.Visible = true;
            Feedback.Text = "RISPOSTA SBAGLIATA";
            this.Update();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10)
                        {
                         await uda_server_communication.Server_Request(put_started);
                        }
                        Thread.Sleep(1000);
                        timeleft--;                        
                        timerLabel.Text = timeleft.ToString();

                    }
                    break;
                }
            }
            else if (timeleft == 0)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        //if (status == 13)
                        //{
                        //    this.Hide();
                        //    parentForm.Abort_UDA();
                        //    break;
                        //}
                        if (status == 10)
                        {
                            await uda_server_communication.Server_Request(put_started);
                        }
                        this.timer1.Stop();
                        timerLabel.Enabled = false;
                        timerLabel.Visible = false;
                        timer_game = 1;
                        timer2.Enabled = true;
                        circles();
                    }
                    break;
                }
               
            }
        }
        

        private async void timer2_Tick(object sender, EventArgs e)
        {
            if (total_seconds > 6)
            {
                //circles();
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    circles();
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                           this.Hide();
                           parentForm.Abort_UDA();
                           break;
                        }
                        if (status == 10)
                        {
                            await uda_server_communication.Server_Request(put_started);
                        }
                        Thread.Sleep(1000);
                        lbl_minutes.Visible = true;
                        Circle1.Visible = true;
                        Circle2.Visible = true;
                        total_seconds--;
                        int minutes = total_seconds / 60;
                        int seconds = total_seconds - (minutes * 60);
                        if (seconds >= 10)
                            this.lbl_minutes.Text = minutes.ToString() + ":" + seconds.ToString();
                        else if (seconds < 10)
                            this.lbl_minutes.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
                        //circles();
                        while (true)
                        {
                            if (status == 15)
                            {
                                string data = await uda_server_communication.Server_Request_datasent(get_status_uda);
                                switch (number_star)
                                {
                                    case 1:
                                        if (String.Equals(data, "12") && round_correct == 1)
                                        {
                                            await uda_server_communication.Server_Request(put_wait_data);
                                            answer(1);
                                            star1.Visible = true;
                                            this.Update();
                                            lbl_Alkaid.Visible = true;
                                            this.Update();                                       
                                            circles();
                                            break;
                                        }
                                        else
                                            {
                                            await uda_server_communication.Server_Request(put_wait_data);
                                            answer(0);
                                            break;
                                        }
                                    case 2:
                                        if (String.Equals(data, "9") && round_correct == 1)
                   
                                        {                       
                                            answer(1);                      
                                            star2.Visible = true;                       
                                            this.Update();
                                            lbl_Mizar.Visible = true;
                                            this.Update();
                                            circles();
                                         }
                                                else
                                                {
                                            answer(0);
                                        }
                                        break;

                                }
                               

                            }
                            break;
                        }
                        }
                    break;
                }
            }

            else if (total_seconds <= 6 && total_seconds >= 1)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            Application.Exit();
                            Environment.Exit(0);
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10)
                        {
                            await uda_server_communication.Server_Request(put_started);
                        }
                        Thread.Sleep(1000);
                        total_seconds--;
                        int minutes = total_seconds / 60;
                        int seconds = total_seconds - (minutes * 60);
                        this.lbl_minutes.ForeColor = Color.Red;
                        this.lbl_minutes.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
                        circles();
                    }
                    break;
                }

            }
            else if (total_seconds < 1)
            {
                final_scenario_time();
            }
        }

        public async void answer(int i)
        {
            if (i == 1)
            {
                Correct_Answer();
                Thread.Sleep(4000);
                round_correct = 0;
                number_star++;
                Feedback.Visible = false;
                parentForm.onStart(parentForm.activity_form);           
            }
            else if (i==0)
            {
                Wrong_Answer();
                Thread.Sleep(4000);
                if (round_correct >= 7)
                round_correct = round_correct + 1;
                Feedback.Visible = false;
                circles();
                timer2.Start();

            }
        }
        public void final_scenario_time()
        {
            timer2.Stop();
            lbl_outoftime.Visible = true;
            parentForm.playbackResourceAudio("failure");
            //lbl_Error.Visible = true;
            star1.Visible = true;
            star2.Visible = true;
            star3.Visible = true;
            star4.Visible = true;
            star5.Visible = true;
            star6.Visible = true;
            star7.Visible = true;
            lbl_Alkaid.Visible = true;
            lbl_Mizar.Visible = true;
            lbl_alioth.Visible = true;
            lbl_Megrez.Visible = true;
            lbl_Dubhe.Visible = true;
            lbl_Merak.Visible = true;
            lbl_Phecda.Visible = true;
            lbl_minutes.Visible = false;
            //btn_conferma.Visible = false;
            Circle1.Visible = false;
            Circle2.Visible = false;
            op1.Visible = false;
            op2.Visible = false;
            op3.Visible = false;
            op4.Visible = false;
            op5.Visible = false;
            op6.Visible = false;
        }
        public void final_scenario()
        {
            lbl_minutes.Visible = false;
            this.Update();
            //btn_conferma.Visible = false;
            //txt_answers.Visible = false;
            Circle1.Visible = false;
            Circle2.Visible = false;
            //lbl_Error.Visible = false;
            op1.Visible = false;
            op2.Visible = false;
            op3.Visible = false;
            op4.Visible = false;
            op5.Visible = false;
            op6.Visible = false;
            timer2.Stop();
            //lbl_Error.Visible = true;
        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            //switch (number_star)
            //{

            //    case 1:
            //        if (string.Equals(txt_answers.Text, "12"))
            //        {
            //            answer(1);
            //            star1.Visible = true;
            //            this.Update();
            //            lbl_Alkaid.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //    case 2:
            //        if (string.Equals(txt_answers.Text, "9") && round_correct==1)
            //        {
            //            answer(1);
            //            star2.Visible = true;
            //            this.Update();
            //            lbl_Mizar.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, "11") && round_correct == 2)
            //        {
            //            answer(1);
            //            star2.Visible = true;
            //            this.Update();
            //            lbl_Mizar.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, "8") && round_correct == 3)
            //        {
            //            answer(1);
            //            star2.Visible = true;
            //            this.Update();
            //            lbl_Mizar.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //    case 3:
            //        if (string.Equals(txt_answers.Text, "6"))
            //        {
            //            answer(1);
            //            star3.Visible = true;
            //            this.Update();
            //            lbl_alioth.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //    case 4:
            //        if (string.Equals(txt_answers.Text, "15"))
            //        {
            //            answer(1);
            //            star4.Visible = true;
            //            this.Update();
            //            lbl_Megrez.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //    case 5:
            //        if (string.Equals(txt_answers.Text, "20"))
            //        {
            //            answer(1);
            //            star5.Visible = true;
            //            this.Update();
            //            lbl_Dubhe.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //    case 6:
            //        if (string.Equals(txt_answers.Text, "8"))
            //        {
            //            answer(1);
            //            star6.Visible = true;
            //            this.Update();
            //            lbl_Merak.Visible = true;
            //            this.Update();
            //            circles();
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //    case 7:
            //        if (string.Equals(txt_answers.Text, "24"))
            //        {
            //            answer(1);
            //            star7.Visible = true;
            //            this.Update();
            //            lbl_Phecda.Visible = true;
            //            this.Update();
            //            final_scenario();
                      
            //        }
            //        else if (string.Equals(txt_answers.Text, ""))
            //        {
            //            answer(2);
            //        }
            //        else
            //        {
            //            answer(0);
            //        }
            //        break;
            //}
        }

        private void Circle1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Error_Click(object sender, EventArgs e)
        {           
            parentForm.activity();
            parentForm.playbackResourceAudio("clapping1");
        }
    }
}
