using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using Newtonsoft.Json.Linq;

namespace La_Forma_Delle_Stelle
{
    public partial class Interaction : UserControl
    {

        public Main parentForm { get; set; }
        public int timeleft = 6;
        public int counter_responses = 0;
        public int timer_game = 0;
        private int total_seconds;
        public int seconds =4;
        public int minutes=0;
        public int number_star=1;
        public string put_started;
        public string put_wait_data;
        public string get_status_uda;
        public int round_correct;
        public int correct_answers;
        public int control = 1;
        public string completed;
        public int contatore_ts = 5;

        public async void PutStarted()
        {
            await uda_server_communication.Server_Request("api/uda/put/?i=1&k=7&data=" + parentForm.data_start);

        }
        public async void Putwaitdata()
        {
            await uda_server_communication.Server_Request("api/uda/put/?i=1&k=14&data=" + parentForm.data_start);

        }
        public Interaction()
        {
            InitializeComponent();
            correct_answers = 0;
            resetOperations();
            get_status_uda = "api/uda/get/?i=1";
           // put_started = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=1&k=7";
            //put_wait_data = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=1&k=14" + "&data=" + "{\"question\": \"Inserisci il risultato corretto\", \"input_type\":\"\"}";
 
        }

        public void resetOperations()
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

        public void resetTimer()
        {
            timer1.Enabled = true;
            total_seconds = (parentForm.minutes1 * 60) + parentForm.seconds1;
            int timer11= parentForm.timeleft1 = 6;         
            timerLabel.Text = timer11.ToString();
            timerLabel.Enabled = true;
            timerLabel.Visible = true;         
            timer1.Start();
        }
        public void Interaction_Load(object sender, EventArgs e)
        {
            resetOperations();

            //resetTimer();
        }
        public void circles()
        {
            timer2.Start();
            switch (parentForm.number_star1)
            {
                case 1:
                    if (parentForm.round_correct1 == 1)
                    { //12 
                        op1.Text = "15-3";
                        op2.Text = "6+2";
                        op3.Text = "17-1";
                        op4.Text = "7-3";
                        op5.Text = "5+1";
                        op6.Text = "10+2";
                    }
                    else if (parentForm.round_correct1 == 2)
                    { //21 
                        op1.Text = "19+2";
                        op2.Text = "15-6";
                        op3.Text = "14+8";
                        op4.Text = "9+13";
                        op5.Text = "25-4";
                        op6.Text = "10+2";
                    }
                    else if (parentForm.round_correct1 == 3)
                    { //17 
                        op1.Text = "5+4";
                        op2.Text = "8+9";
                        op3.Text = "17-6";
                        op4.Text = "13+7";
                        op5.Text = "21-5";
                        op6.Text = "11+6";
                    }
                    else if (parentForm.round_correct1 == 4)
                    { //13 
                        op1.Text = "15-5";
                        op2.Text = "7+6";
                        op3.Text = "9+3";
                        op4.Text = "16+4";
                        op5.Text = "3+11";
                        op6.Text = "19-6";
                    }
                    else if (parentForm.round_correct1 == 5)
                    { //9 
                        op1.Text = "5+1";
                        op2.Text = "12+9";
                        op3.Text = "6+3";
                        op4.Text = "19-7";
                        op5.Text = "14+5";
                        op6.Text = "15-6";
                    }
                    break;
                case 2:
                    if (parentForm.round_correct1 == 1)
                    {
                        //9
                        op1.Text = "4+5";
                        op2.Text = "3-2";
                        op3.Text = "11+1";
                        op4.Text = "2+2";
                        op5.Text = "7-4";
                        op6.Text = "14-5";
                        break;
                    }
                    else if (parentForm.round_correct1 == 2)
                    {
                        //8
                        op1.Text = "13-9";
                        op2.Text = "5+3";
                        op3.Text = "17-7";
                        op4.Text = "22-14";
                        op5.Text = "15+8";
                        op6.Text = "10-3";
                        break;
                    }
                    else if (parentForm.round_correct1 == 3)
                    {
                        //15
                        op1.Text = "17+3";
                        op2.Text = "8-5";
                        op3.Text = "8+7";
                        op5.Text = "4+7";
                        op6.Text = "18-16";
                        break;
                    }
                    else if (parentForm.round_correct1 == 4)
                    {
                        //11
                        op1.Text = "7+2";
                        op2.Text = "5+3";
                        op3.Text = "10+1";
                        op4.Text = "9+5";
                        op5.Text = "14-3";
                        op6.Text = "21-4";
                        break;
                    }
                    else if (parentForm.round_correct1 == 5)
                    {
                        //10
                        op1.Text = "16-12";
                        op2.Text = "2+4";
                        op3.Text = "5+5";
                        op4.Text = "19+7";
                        op5.Text = "13-4";
                        op6.Text = "10+0";
                        break;
                    }
                    break;
                case 3:
                    if (parentForm.round_correct1 == 1)
                    {
                        //14
                        op1.Text = "15-1";
                        op2.Text = "20-18";
                        op3.Text = "17-11";
                        op4.Text = "9-3";
                        op5.Text = "15+7";
                        op6.Text = "7+7";
                        break;
                    }
                   else if (parentForm.round_correct1 == 2)
                    {
                        //16
                        op1.Text = "24-21";
                        op2.Text = "5+25";
                        op3.Text = "26-10";
                        op4.Text = "11+5";
                        op5.Text = "16+20";
                        op6.Text = "13+5";
                        break;
                    }

                    else if (parentForm.round_correct1 == 3)
                    {
                        //7
                        op1.Text = "30-20";
                        op2.Text = "17-10";
                        op3.Text = "24+2";
                        op4.Text = "14+5";
                        op5.Text = "3+4";
                        op6.Text = "13-2";
                        break;
                    }
                    else if (parentForm.round_correct1 == 4)
                    {
                        //4
                        op1.Text = "6+5";
                        op2.Text = "14-4";
                        op3.Text = "2+2";
                        op4.Text = "11+5";
                        op5.Text = "8-4";
                        op6.Text = "10+2";
                        break;
                    }
                    else if (parentForm.round_correct1 == 5)
                    {
                        //6
                        op1.Text = "10+3";
                        op2.Text = "15-3";
                        op3.Text = "4+2";
                        op4.Text = "5+1";
                        op5.Text = "14+2";
                        op6.Text = "9+0";
                        break;
                    }
                    break;
                case 4:
                    if (parentForm.round_correct1 == 1)
                    {
                        //15
                        op1.Text = "4x6";
                        op2.Text = "9+6";
                        op3.Text = "2x5";
                        op4.Text = "16-5";
                        op5.Text = "4+4";
                        op6.Text = "3x5";
                        break;
                    }
                    if (parentForm.round_correct1 == 2)
                    {
                        //10
                        op1.Text = "5x2";
                        op2.Text = "6+2";
                        op3.Text = "10-3";
                        op4.Text = "5+5";
                        op5.Text = "4x4";
                        op6.Text = "7x5";
                        break;
                    }
                    if (parentForm.round_correct1 == 3)
                    {
                        //8
                        op1.Text = "5x5";
                        op2.Text = "3x7";
                        op3.Text = "4+4";
                        op4.Text = "17+2";
                        op5.Text = "4x2";
                        op6.Text = "6x6";
                        break;
                    }
                    if (parentForm.round_correct1 == 4)
                    {
                        //20
                        op1.Text = "8x8";
                        op2.Text = "3x3";
                        op3.Text = "10x2";
                        op4.Text = "12+12";
                        op5.Text = "11+11";
                        op6.Text = "25-5";
                        break;
                    }
                    if (parentForm.round_correct1 == 5)
                    {
                        //12
                        op1.Text = "18-6";
                        op2.Text = "3+2";
                        op3.Text = "9+4";
                        op4.Text = "20+2";
                        op5.Text = "3x4";
                        op6.Text = "10-6";
                        break;
                    }
                    break;
                case 5:
                    if (parentForm.round_correct1 == 1)
                    {
                        //20
                        op1.Text = "7x5";
                        op2.Text = "3x3";
                        op3.Text = "5x4";
                        op4.Text = "12+3";
                        op5.Text = "10x2";
                        op6.Text = "9x4";
                        break;
                    }
                    if (parentForm.round_correct1 == 2)
                    {
                        //7
                        op1.Text = "9x3";
                        op2.Text = "9-2";
                        op3.Text = "9-9";
                        op4.Text = "6x8";
                        op5.Text = "1+6";
                        op6.Text = "7+10";
                        break;
                    }
                    if (parentForm.round_correct1 == 3)
                    {
                        //9
                        op1.Text = "21+8";
                        op2.Text = "8+3";
                        op3.Text = "3x3";
                        op4.Text = "7x2";
                        op5.Text = "10x3";
                        op6.Text = "16-7";
                        break;
                    }
                    if (parentForm.round_correct1 == 4)
                    {
                        //18
                        op1.Text = "11-5";
                        op2.Text = "9x5";
                        op3.Text = "9x2";
                        op4.Text = "6x4";
                        op5.Text = "8x8";
                        op6.Text = "16+2";
                        break;
                    }
                    if (parentForm.round_correct1 == 5)
                    {
                        //30
                        op1.Text = "28+2";
                        op2.Text = "5x9";
                        op3.Text = "2x20";
                        op4.Text = "6x5";
                        op5.Text = "19-6";
                        op6.Text = "8x9";
                        break;
                    }
                    break;
                case 6:
                    if (parentForm.round_correct1 == 1)
                    { 
                        //8
                     op1.Text = "8x3";
                    op2.Text = "30/5";
                    op3.Text = "64/8";
                    op4.Text = "28/7";
                    op5.Text = "22x3";
                    op6.Text = "72/9";
                     break;
                    }
                    if (parentForm.round_correct1 == 2)
                    {
                        //6
                        op1.Text = "35/7";
                        op2.Text = "3x2";
                        op3.Text = "90/10";
                        op4.Text = "6x1";
                        op5.Text = "27/9";
                        op6.Text = "4x2";
                        break;
                    }
                    if (parentForm.round_correct1 == 3)
                    {
                        //14
                        op1.Text = "18/9";
                        op2.Text = "140/10";
                        op3.Text = "6x2";
                        op4.Text = "7x2";
                        op5.Text = "81/9";
                        op6.Text = "5x5";
                        break;
                    }
                    if (parentForm.round_correct1 == 4)
                    {
                        //24
                        op1.Text = "4x7";
                        op2.Text = "55/5";
                        op3.Text = "3x8";
                        op4.Text = "56/7";
                        op5.Text = "12x2";
                        op6.Text = "36/4";
                        break;
                    }
                    if (parentForm.round_correct1 == 5)
                    {
                        //45
                        op1.Text = "5x9";
                        op2.Text = "42/6";
                        op3.Text = "40/2";
                        op4.Text = "7x9";
                        op5.Text = "3x7";
                        op6.Text = "90/2";
                        break;
                    }
                    break;
                case 7:
                    if (parentForm.round_correct1 == 1)
                    {
                    //24
                    op1.Text = "36/4";
                    op2.Text = "23+1";
                    op3.Text = "9x7";
                    op4.Text = "6x7";
                    op5.Text = "3x8";
                    op6.Text = "42/6";
                        break;
                    }
                    if (parentForm.round_correct1 == 2)
                    {
                        //12
                        op1.Text = "42/6";
                        op2.Text = "18/6";
                        op3.Text = "2x6";
                        op4.Text = "8x9";
                        op5.Text = "2x7";
                        op6.Text = "4x3";
                        break;
                    }
                    if (parentForm.round_correct1 == 3)
                    {
                        //28
                        op1.Text = "7x4";
                        op2.Text = "4/2";
                        op3.Text = "10x5";
                        op4.Text = "14x2";
                        op5.Text = "70/7";
                        op6.Text = "5x3";
                        break;
                    }
                    if (parentForm.round_correct1 == 4)
                    {
                        //16
                        op1.Text = "15/5";
                        op2.Text = "2x8";
                        op3.Text = "11x4";
                        op4.Text = "27/9";
                        op5.Text = "32/2";
                        op6.Text = "9x5";
                        break;
                    }
                    if (parentForm.round_correct1 == 5)
                    {
                        //10
                        op1.Text = "4x8";
                        op2.Text = "36/4";
                        op3.Text = "60/6";
                        op4.Text = "5x2";
                        op5.Text = "28x3";
                        op6.Text = "63/9";
                        break;
                    }
                    break;

            }
            op1.Visible = true;
            op2.Visible = true;
            op3.Visible = true;
            op4.Visible = true;
            op5.Visible = true;
            op6.Visible = true;
            this.Update();
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
            Thread.Sleep(2000);
        }
        public void Wrong_Answer()
        {
            parentForm.playbackResourceAudio("failure");
            Feedback.ForeColor = Color.Red;
            Feedback.Visible = true;
            Feedback.Text = "RISPOSTA SBAGLIATA";
            this.Update();
            Thread.Sleep(1000);
            Feedback.Visible = false;
            parentForm.round_correct1++;
            if (parentForm.round_correct1 == 5)
            {
                parentForm.round_correct1 = 1;
            }
            circles();
            timer2.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (parentForm.timeleft1 > 0)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);

                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            parentForm.Abort_UDA();
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        if (status == 10)
                        {
                         PutStarted();
                        }
                       int timerl= parentForm.timeleft1--;                        
                       timerLabel.Text = timerl.ToString();
                    }
                    break;
                }
            }
            else if (parentForm.timeleft1 == 0)
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
                            PutStarted();
                        }
                        this.timer1.Stop();
                        int timerl = parentForm.timeleft1--;
                        timerLabel.Text = timerl.ToString();
                        timerLabel.Visible = false;
                        timer_game = 1;
                        timer2.Enabled = true;
                        parentForm.contatore_iniziale = 1;
                        await uda_server_communication.Server_Request(parentForm.wait_data());
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
                circles();
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
                    string response = null;
                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            parentForm.Abort_UDA();
                        }
                        if (status == 13)
                        {
                            this.Hide();
                            parentForm.Abort_UDA();
                            break;
                        }
                        //if (status == 10 || status == 7 || status == 14)
                        if (status == 10)
                        {
                            Putwaitdata();
                            //await uda_server_communication.Server_Request(parentForm.wait_data());
                         
                        }


                            lbl_minutes.Visible = true;
                            Circle1.Visible = true;
                            Circle2.Visible = true;
                            total_seconds--;
                            updateCountdown();
                            circles();
                            while (true)
                            {
                            
                                if (status == 14)
                                {

                                    JToken data = await uda_server_communication.Server_Request_datasent(get_status_uda);
                                    if (!(data is JArray))
                                    {
                                        continue;
                                    }
                                    var explorers = data.ToObject<JArray>();

                                    foreach (var explorer in data)
                                    {
                                        Dictionary<string, object> exp = explorer.ToObject<Dictionary<string, object>>();
                                        string timestamp = (string)explorer["timestamp"];
                                        if (timestamp == null || timestamp == "0000-00-00 00:00:00")
                                        {
                                            continue;
                                        }
                                        response = (string)explorer["answer"];
                                        break;
                                    }
                                    if (response == null) { break; }
                                    switch (parentForm.number_star1)
                                    {
                                        case 1:
                                            if (String.Equals(response, "12") && parentForm.round_correct1 == 1)
                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star1.Visible = true;
                                                lbl_Alkaid.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "21") && parentForm.round_correct1 == 2 && control == 1)
                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star1.Visible = true;
                                                lbl_Alkaid.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "17") && parentForm.round_correct1 == 3 && control == 1)
                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star1.Visible = true;
                                                lbl_Alkaid.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "13") && parentForm.round_correct1 == 4 && control == 1)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star1.Visible = true;
                                                lbl_Alkaid.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "9") && parentForm.round_correct1 == 5 && control == 1)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star1.Visible = true;
                                                lbl_Alkaid.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                break;
                                            }
                                        case 2:
                                            if (String.Equals(response, "9") && parentForm.round_correct1 == 1)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star2.Visible = true;
                                                lbl_Mizar.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "8") && parentForm.round_correct1 == 2)

                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star2.Visible = true;
                                                lbl_Mizar.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "15") && parentForm.round_correct1 == 3)

                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star2.Visible = true;
                                                lbl_Mizar.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "11") && parentForm.round_correct1 == 4)

                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star2.Visible = true;
                                                lbl_Mizar.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "10") && parentForm.round_correct1 == 5)

                                            {

                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star2.Visible = true;
                                                this.Update();
                                                lbl_Mizar.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                break;
                                            }
                                        case 3:
                                            if (String.Equals(response, "14") && parentForm.round_correct1 == 1)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star3.Visible = true;
                                                lbl_alioth.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "16") && parentForm.round_correct1 == 2)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star3.Visible = true;
                                                lbl_alioth.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "7") && parentForm.round_correct1 == 3)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star3.Visible = true;
                                                lbl_alioth.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "4") && parentForm.round_correct1 == 4)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star3.Visible = true;
                                                lbl_alioth.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "6") && parentForm.round_correct1 == 5)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star3.Visible = true;
                                                lbl_alioth.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                break;
                                            }

                                        case 4:
                                            if (String.Equals(response, "15") && parentForm.round_correct1 == 1)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star4.Visible = true;
                                                lbl_Megrez.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "10") && parentForm.round_correct1 == 2)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star4.Visible = true;
                                                lbl_Megrez.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "8") && parentForm.round_correct1 == 3)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star4.Visible = true;
                                                lbl_Megrez.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "20") && parentForm.round_correct1 == 4)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star4.Visible = true;
                                                lbl_Megrez.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "12") && parentForm.round_correct1 == 5)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star4.Visible = true;
                                                lbl_Megrez.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                break;
                                            }
                                        case 5:
                                            if (String.Equals(response, "20") && parentForm.round_correct1 == 1)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star5.Visible = true;
                                                lbl_Dubhe.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "7") && parentForm.round_correct1 == 2)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star5.Visible = true;
                                                lbl_Dubhe.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "9") && parentForm.round_correct1 == 3)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star5.Visible = true;
                                                lbl_Dubhe.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "18") && parentForm.round_correct1 == 4)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star5.Visible = true;
                                                lbl_Dubhe.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "30") && parentForm.round_correct1 == 5)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star5.Visible = true;
                                                lbl_Dubhe.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                break;
                                            }
                                        case 6:
                                            if (String.Equals(response, "8") && parentForm.round_correct1 == 1)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star6.Visible = true;
                                                lbl_Merak.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "6") && parentForm.round_correct1 == 2)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star6.Visible = true;
                                                lbl_Merak.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "14") && parentForm.round_correct1 == 3)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star6.Visible = true;
                                                lbl_Merak.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "24") && parentForm.round_correct1 == 4)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star6.Visible = true;
                                                lbl_Merak.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            if (String.Equals(response, "45") && parentForm.round_correct1 == 5)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star6.Visible = true;
                                                lbl_Merak.Visible = true;
                                                this.Update();
                                                circles();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                break;
                                            }
                                        case 7:
                                            if (String.Equals(response, "24") && parentForm.round_correct1 == 1)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star7.Visible = true;
                                                lbl_Phecda.Visible = true;
                                                this.Update();
                                                circles();
                                                Thread.Sleep(1000);
                                                Feedback.ForeColor = Color.Gold;
                                                Feedback.Visible = true;
                                                Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                                parentForm.activity();
                                                parentForm.playbackResourceAudio("clapping1");
                                                Thread.Sleep(5000);                                         
                                            parentForm.indizio_finale();
                                                break;
                                            }
                                            if (String.Equals(response, "12") && parentForm.round_correct1 == 2)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star7.Visible = true;
                                                lbl_Phecda.Visible = true;
                                                this.Update();
                                                circles();
                                                Thread.Sleep(1000);
                                                Feedback.ForeColor = Color.Gold;
                                                Feedback.Visible = true;
                                                Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                                parentForm.activity();
                                            Thread.Sleep(5000);
                                                parentForm.playbackResourceAudio("clapping1");
                                            Thread.Sleep(5000);
                                                parentForm.indizio_finale();
                                                break;
                                            }
                                            if (String.Equals(response, "28") && parentForm.round_correct1 == 3)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star7.Visible = true;
                                                lbl_Phecda.Visible = true;
                                                this.Update();
                                                circles();
                                                Thread.Sleep(1000);
                                                Feedback.ForeColor = Color.Gold;
                                                Feedback.Visible = true;
                                                Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                                parentForm.activity();
                                            Thread.Sleep(5000);
                                                parentForm.playbackResourceAudio("clapping1");

                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                                break;
                                            }
                                            if (String.Equals(response, "16") && parentForm.round_correct1 == 4)
                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star7.Visible = true;
                                                lbl_Phecda.Visible = true;
                                                this.Update();
                                                circles();
                                                Thread.Sleep(1000);
                                                Feedback.ForeColor = Color.Gold;
                                                Feedback.Visible = true;
                                                Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                                parentForm.activity();
                                            Thread.Sleep(5000);
                                                parentForm.playbackResourceAudio("clapping1");
                                            Thread.Sleep(5000);
                               
                                            parentForm.indizio_finale();
                                                break;
                                            }

                                            if (String.Equals(response, "10") && parentForm.round_correct1 == 5)

                                            {
                                                answer(1);
                                                Thread.Sleep(1000);
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                star7.Visible = true;
                                                lbl_Phecda.Visible = true;
                                                this.Update();
                                                circles();
                                                Thread.Sleep(1000);
                                                Feedback.ForeColor = Color.Gold;
                                                Feedback.Visible = true;
                                                Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                                parentForm.activity();
                                            Thread.Sleep(5000);
                                                parentForm.playbackResourceAudio("clapping1");
                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                                break;
                                            }
                                            else
                                            {
                                                Wrong_Answer();
                                                await uda_server_communication.Server_Request(parentForm.wait_data());
                                                break;
                                            }
                                    }


                                }
                                break;
                            }
                        
                        break;
                    }
                }
            }

            else if (total_seconds <= 6 && total_seconds >= 1)
            {
                while (true)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);
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
                        Putwaitdata();
                        //await uda_server_communication.Server_Request(parentForm.wait_data());
                    {
                        /*if (status != 14)
                        {
                            await uda_server_communication.Server_Request(parentForm.wait_data());

                        }*/
                        Thread.Sleep(1000);
                        total_seconds--;
                        updateCountdown();

                        circles();
                           string response = null;
                        while (true)
                        {
                            if (status == 14)
                            {
                                JToken data = await uda_server_communication.Server_Request_datasent(get_status_uda);
                                if (!(data is JArray))
                                {
                                    continue;
                                }
                                var explorers = data.ToObject<JArray>();
                                foreach (var explorer in data)
                                {
                                    Dictionary<string, object> exp = explorer.ToObject<Dictionary<string, object>>();
                                    string timestamp = (string)explorer["timestamp"];
                                    if (timestamp == null || timestamp == "0000-00-00 00:00:00")
                                    {
                                        continue;
                                    }
                                    response = (string)explorer["answer"];
                                    break;
                                }
                                if (response == null) { break; }
                                switch (parentForm.number_star1)
                                {
                                    case 1:
                                        if (String.Equals(response, "12") && parentForm.round_correct1 == 1)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star1.Visible = true;
                                            this.Update();
                                            lbl_Alkaid.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "21") && parentForm.round_correct1 == 2)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star1.Visible = true;
                                            this.Update();
                                            lbl_Alkaid.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "17") && parentForm.round_correct1 == 3)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star1.Visible = true;
                                            this.Update();
                                            lbl_Alkaid.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "13") && parentForm.round_correct1 == 4)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star1.Visible = true;
                                            this.Update();
                                            lbl_Alkaid.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "9") && parentForm.round_correct1 == 5)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star1.Visible = true;
                                            this.Update();
                                            lbl_Alkaid.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            break;
                                        }
                                    case 2:
                                        if (String.Equals(response, "9") && parentForm.round_correct1 == 1)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star2.Visible = true;
                                            lbl_Mizar.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "8") && parentForm.round_correct1 == 2)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star2.Visible = true;
                                            lbl_Mizar.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "15") && parentForm.round_correct1 == 3)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star2.Visible = true;
                                            lbl_Mizar.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "11") && parentForm.round_correct1 == 4)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star2.Visible = true;
                                            lbl_Mizar.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "10") && parentForm.round_correct1 == 5)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star2.Visible = true;
                                            lbl_Mizar.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            break;
                                        }

                                    case 3:
                                        if (String.Equals(response, "14") && parentForm.round_correct1 == 1)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star3.Visible = true;
                                            lbl_alioth.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "16") && parentForm.round_correct1 == 2)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star3.Visible = true;
                                            lbl_alioth.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "7") && parentForm.round_correct1 == 3)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star3.Visible = true;
                                            lbl_alioth.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "4") && parentForm.round_correct1 == 4)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star3.Visible = true;
                                            lbl_alioth.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "6") && parentForm.round_correct1 == 5)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star3.Visible = true;
                                            lbl_alioth.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            break;
                                        }
                                    case 4:
                                        if (String.Equals(response, "15") && parentForm.round_correct1 == 1)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star4.Visible = true;
                                            this.Update();
                                            lbl_Megrez.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "10") && parentForm.round_correct1 == 2)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star4.Visible = true;
                                            this.Update();
                                            lbl_Megrez.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "8") && parentForm.round_correct1 == 3)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star4.Visible = true;
                                            this.Update();
                                            lbl_Megrez.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "20") && parentForm.round_correct1 == 4)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star4.Visible = true;
                                            this.Update();
                                            lbl_Megrez.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "12") && parentForm.round_correct1 == 5)
                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star4.Visible = true;
                                            this.Update();
                                            lbl_Megrez.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            break;
                                        }
                                    case 5:
                                        if (String.Equals(response, "20") && parentForm.round_correct1 == 1)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star5.Visible = true;
                                            this.Update();
                                            lbl_Dubhe.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "7") && parentForm.round_correct1 == 2)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star5.Visible = true;
                                            this.Update();
                                            lbl_Dubhe.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "9") && parentForm.round_correct1 == 3)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star5.Visible = true;
                                            this.Update();
                                            lbl_Dubhe.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "18") && parentForm.round_correct1 == 4)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star5.Visible = true;
                                            this.Update();
                                            lbl_Dubhe.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "30") && parentForm.round_correct1 == 5)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star5.Visible = true;
                                            this.Update();
                                            lbl_Dubhe.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            break;
                                        }
                                    case 6:
                                        if (String.Equals(response, "8") && parentForm.round_correct1 == 1)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star6.Visible = true;
                                            this.Update();
                                            lbl_Merak.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "6") && parentForm.round_correct1 == 2)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star6.Visible = true;
                                            this.Update();
                                            lbl_Merak.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "14") && parentForm.round_correct1 == 3)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star6.Visible = true;
                                            this.Update();
                                            lbl_Merak.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "24") && parentForm.round_correct1 == 4)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star6.Visible = true;
                                            this.Update();
                                            lbl_Merak.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        if (String.Equals(response, "45") && parentForm.round_correct1 == 5)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star6.Visible = true;
                                            this.Update();
                                            lbl_Merak.Visible = true;
                                            this.Update();
                                            circles();
                                            break;
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            break;
                                        }
                                    case 7:
                                        if (String.Equals(response, "24") && parentForm.round_correct1 == 1)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star7.Visible = true;
                                            this.Update();
                                            lbl_Phecda.Visible = true;
                                            this.Update();
                                            circles();
                                            Thread.Sleep(1000);
                                            Feedback.ForeColor = Color.Gold;
                                            Feedback.Visible = true;
                                            Feedback.Text = "GIOCO COMPLETATO!!";
                                            this.Update();
                                            parentForm.contatore_iniziale = 0;
                                            parentForm.activity();
                                            Thread.Sleep(5000);
                                            parentForm.playbackResourceAudio("clapping1");
                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                            break;
                                            //parentForm.playbackResourceAudio("clapping1");
                                        }
                                        if (String.Equals(response, "12") && parentForm.round_correct1 == 2)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star7.Visible = true;
                                            this.Update();
                                            lbl_Phecda.Visible = true;
                                            this.Update();
                                            circles();
                                            Thread.Sleep(1000);
                                            Feedback.ForeColor = Color.Gold;
                                            Feedback.Visible = true;
                                            Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                      
                                            parentForm.activity();
                                            Thread.Sleep(5000);
                                            parentForm.playbackResourceAudio("clapping1");
                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                            break;
                                            //parentForm.playbackResourceAudio("clapping1");
                                        }
                                        if (String.Equals(response, "28") && parentForm.round_correct1 == 3)

                                        {
                                            answer(1);
                                            Thread.Sleep(2000);
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            star7.Visible = true;
                                            this.Update();
                                            lbl_Phecda.Visible = true;
                                            this.Update();
                                            circles();
                                            Thread.Sleep(1000);
                                            Feedback.ForeColor = Color.Gold;
                                            Feedback.Visible = true;
                                            Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();                                            
                                            parentForm.activity();
                                            Thread.Sleep(5000);
                                            parentForm.playbackResourceAudio("clapping1");
                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                            break;
                                            //parentForm.playbackResourceAudio("clapping1");
                                        }
                                        if (String.Equals(response, "16") && parentForm.round_correct1 == 4)

                                        {
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            answer(1);
                                            star7.Visible = true;
                                            this.Update();
                                            lbl_Phecda.Visible = true;
                                            this.Update();
                                            circles();
                                            Thread.Sleep(1000);
                                            Feedback.ForeColor = Color.Gold;
                                            Feedback.Visible = true;
                                            Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                            parentForm.activity();
                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                            break;
                                            //parentForm.playbackResourceAudio("clapping1");
                                        }
                                        if (String.Equals(response, "10") && parentForm.round_correct1 == 5)

                                        {
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            answer(1);
                                            star7.Visible = true;
                                            this.Update();
                                            lbl_Phecda.Visible = true;
                                            this.Update();
                                            circles();
                                            Thread.Sleep(1000);
                                            Feedback.ForeColor = Color.Gold;
                                            Feedback.Visible = true;
                                            Feedback.Text = "GIOCO COMPLETATO!!";
                                            parentForm.contatore_iniziale = 0;
                                            this.Update();
                                            parentForm.activity();
                                            Thread.Sleep(5000);
                                            parentForm.indizio_finale();
                                            break;
                                            //parentForm.playbackResourceAudio("clapping1");
                                        }
                                        else
                                        {
                                            Wrong_Answer();
                                            await uda_server_communication.Server_Request(parentForm.wait_data());
                                            break;
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
            else if (total_seconds < 1)
            {
                parentForm.contatore_iniziale = 0;
                PutStarted();
                final_scenario_time();
                while (contatore_ts>=0)
                {
                    string k = parentForm.Status_Changed(parentForm.activity_form);
                    int status = int.Parse(k);

                    if (status != 9 && status != 8)
                    {
                        if (status == 11 || status == 12)
                        {
                            parentForm.Abort_UDA();
                        }
                        if (status == 10)
                        {
                            PutStarted();
                        }
                        contatore_ts--;
                        Thread.Sleep(1000);
                    }
                 
                  //  break;
                }

                parentForm.activity();
            }
        }
        public void updateCountdown()
        {
            int minutes = total_seconds / 60;
            int seconds = total_seconds - (minutes * 60);
            if (total_seconds <= 5)
            {
                this.lbl_minutes.ForeColor = Color.Red;
            } else {
                this.lbl_minutes.ForeColor = Color.White;
            }
            if (seconds >= 10)
                this.lbl_minutes.Text = minutes.ToString() + ":" + seconds.ToString();
            else
                this.lbl_minutes.Text = minutes.ToString() + ":" + "0" + seconds.ToString();
        }

        public async void answer(int i)
        {
            if (i == 1)
            {
                Correct_Answer();
               PutStarted();
                parentForm.round_correct1 = 1;
                parentForm.number_star1++;
                parentForm.correct_answers1++;
                Feedback.Visible = false;
                parentForm.onStart(parentForm.activity_form);           
            }
            else if (i==0)
            {
                Wrong_Answer();
               PutStarted();
                Feedback.Visible = false;
                parentForm.round_correct1++;
                if (parentForm.round_correct1 == 5)
                {
                    parentForm.round_correct1 = 1;
                } 
                circles();
                timer2.Start();
            }
        }
        public void final_scenario_time()
        {
            timer2.Stop();
            lbl_outoftime.Visible = true;
            parentForm.playbackResourceAudio("failure");           
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
            lbl_minutes.Visible = false;
            Circle1.Visible = false;
            Circle2.Visible = false;
            op1.Visible = false;
            op2.Visible = false;
            op3.Visible = false;
            op4.Visible = false;
            op5.Visible = false;
            op6.Visible = false;
            Feedback.ForeColor = Color.Red;
            Feedback.Visible = false;
            Feedback.Text = "TEMPO SCADUTO!";
            this.Update();
            Thread.Sleep(1000);
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
