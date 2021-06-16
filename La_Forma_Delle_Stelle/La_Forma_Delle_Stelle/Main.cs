using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

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
        public Main()
        {
            InitializeComponent();
            idle_status = "https://www.sagosoft.it/_API_/cpim/luda/www/luda_20210111_1500//api/uda/put/?i=2&k=0";
            Business_Logic BL = new Business_Logic(this);
            initial1.parentForm = this;
            interaction1.parentForm = this;
            initial1.Visible = false;
            interaction1.Visible = false;
            activity1.parentForm = this;
            activity1.Visible = false;
            ursa1.parentForm = this;
            ursa1.Visible = false;
            home();

        }
        public string Status_Changed(string k)
        {
            this.BeginInvoke((Action)delegate ()
            {
                int status = int.Parse(k);
                if (status == 6)
                {
                    onStart(activity_form);
                }
                if (status == 8)
                {


                }
                if (status == 9)
                {


                }
                if (status == 11 || status == 12)
                {

                    Application.Exit();
                    Environment.Exit(0);

                }
                if (status == 15)
                {

                }

            });
            return k;
        }

        public async void Abort_UDA()
        {
            await uda_server_communication.Server_Request(idle_status);
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
            while (true)
            {
                string k = activity_form;
                int status = int.Parse(k);
                if (status == 6 || status == 7)
                {
                    break;
                }
            }
        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
        }
        public void onStart(string k)
        {
            initial1.Visible = false;
            interaction1.Visible = true;
            currUC = interaction1;
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
            currUC = ursa1;
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
