using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;
using System.IO.Pipes;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace La_Forma_Delle_Stelle
{
    public partial class Main : Form
    {
        public static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources";
        private const string background_image = "Cielo_Stellato.png";
        private UserControl currUC = null;
        public SoundPlayer player = null;
        public string activity_form;
        public string idle_status;
        public string data_start;
        public string started_uda;
        public static System.Diagnostics.Process proc;
        public int turno;
         public int number_star1;
        public int round_correct1 ;
        public int correct_answers1;
        public int timeleft1;
        public int seconds1;
        public int minutes1;
        public bool ShouldPause = true;
        public int onactivity;
        public int contatore_iniziale = 0;
        public string MPV = resourcesPath + "\\" + "mpv.com";
        public string initial_video = Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\..\\..\\..\\Video_GAMES\\La_Forma_Delle_Stelle\\iniziale.mov";

        private Business_Logic BL;
        public string wait_data()
        {
            int[] can_answer;
            if (uda_server_communication.explorers.Length == 0)
            {
                can_answer = new int[0];
            }
            else
            {
                can_answer = new int[] { uda_server_communication.explorers[
                    turno % uda_server_communication.explorers.Length] };
            }
            turno += 1;
            Dictionary<String, object> request = new Dictionary<String, object>();
            request.Add("question", "Inserisci il numero comune ai due cerchi");
            request.Add("input_type", 0);
            request.Add("can_answer", can_answer);

            string data = JsonConvert.SerializeObject(request);
            return "api/uda/put/?i=1&k=14&data=" + data;
        }
        private void init()
        {
            initial1.parentForm = this;
            initial1.Visible = false;
            interaction1.parentForm = this;
            interaction1.Visible = false;
            activity1.parentForm = this;
            activity1.Visible = false;
            ursa1.parentForm = this;
            ursa1.Visible = false;
            number_star1 = 1;
            round_correct1 = 1;
            correct_answers1 = 0;
            timeleft1 = 6;
            seconds1 = 0;
            minutes1 = 5;
        }
        public Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            InitializeComponent();
            started_uda = "api/uda/put/?i=1&k=7" + "&data=" + data_start;
            //started_uda =  url_luda + "api/uda/put/?i=3&k=7";
            //get_data_uda = "api/uda/get/?i=3";
            idle_status = "api/uda/put/?i=1&k=0";
            BL = new Business_Logic(this);

            init();
            home();

        }
        public void closemessage()
        {

        }
       static void OnProcessExit(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("ciao");
            var Nicolo = new NamedPipeClientStream("mpv-pipe");
            Nicolo.Connect();
            StreamWriter writer = new StreamWriter(Nicolo);
            writer.WriteLine("quit");
        }
        public void video_reproduction(string video1)
        {
            string mpvcommand = "--fullscreen --ontop " + video1;
            ProcessStartInfo proc = new ProcessStartInfo(MPV);
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Arguments = mpvcommand;
            Process cmd = Process.Start(proc);
            cmd.WaitForExit();
        }
        public string Status_Changed(string k)
        {
            this.BeginInvoke((Action)delegate ()
            {
                int status = int.Parse(k);
                if (status == 0)
                {
                    k = "5";
                    ursa1.Visible = false;
                    BL.firststart = false;
                    init();
                    home();

                }
                if (status == 6)
                {                    
                    ursa1.Visible = false;
                    video_reproduction(initial_video);
                    interaction1.resetOperations();
                    interaction1.resetTimer();
                    interaction1.updateCountdown();
                    onStart(activity_form);
                }

                if (status == 11 || status == 12)
                {

                    System.Diagnostics.Process.GetCurrentProcess().Kill();


                }
                if (status == 8)
                {


                }
                if (status == 9)
                {


                }


            });
            return k;
        }

        public void Abort_UDA()
        {
            while (true)
            {
                string k = activity_form;
                int status = int.Parse(k);
                if (status == 11 || status == 12)
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    break;
                }
            }
        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Visible=true;
            currUC = initial1;
        }
        public void onStart(string k)
        {
            initial1.Visible = false;
            this.Update();
            interaction1.Visible = true;          
            currUC = interaction1;
            Thread.Sleep(1000);
        }
        public void playbackResourceAudio(string audioname)
        {

            string s = resourcesPath + "\\" + audioname + ".wav";
            player = new SoundPlayer(s);
            player.Play();
        }
        public void activity()
        {
            interaction1.Visible = false;
            ursa1.Visible = true;
            while (true)
            {
                string k = activity_form;
                int status = int.Parse(k);
                if (status == 11 || status == 12)
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    ursa1.Visible = false;
                }
                if (status == 13)
                {
                    this.Hide();
                    ursa1.Visible = false;
                    Abort_UDA();
                    break;
                }
                currUC = ursa1;
                ursa1.Ursa_Final();         
                ursa1.indizio();
                break;
            }

        }
        public void activity_indizio()
        {
            interaction1.resetOperations();
            interaction1.Visible = false;
            ursa1.Visible = true;           
            while (true)
            {
                string k = activity_form;
                int status = int.Parse(k);
                if (status == 11 || status == 12)
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    ursa1.Visible = false;
                }
                if (status == 13)
                {
                    this.Hide();
                    ursa1.Visible = false;
                    Abort_UDA();
                    break;
                }
                currUC = ursa1;
                ursa1.indizio();
                break;
            }
        }

        public void indizio_finale()
        {
            ursa1.indizio();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            initial1.setPos(size.Width, size.Height);
            interaction1.setPos(size.Width, size.Height);
            ursa1.setPos(size.Width, size.Height);
        }
    }
}
