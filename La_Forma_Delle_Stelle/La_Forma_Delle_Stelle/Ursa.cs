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

namespace La_Forma_Delle_Stelle
{
    public partial class Ursa : UserControl
    {
        public string completed;
        public Main parentForm { get; set; }
        public int contatore_ts;
        public Ursa()
        {
            InitializeComponent();
            completed = "api/uda/put/?i=1&k=16";
            contatore_ts = 5;
        }
        public  void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
        public async void Image_Indizio(string a)
        {
            while (true)
            {
              string  k = parentForm.Status_Changed(parentForm.activity_form);
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
                    else if (status == 10 || status == 7 || status == 16)
                    {

                        indizio_box.WaitOnLoad = true;
                        indizio_box.ImageLocation = Main.resourcesPath + "\\" + a + ".png";
                        indizio_box.Visible = true;
                        lbl_Error.Text = "ECCO L'INDIZIO!";
                        lbl_Error.Visible = true;
                        this.Update();
                        break;
                    }
                }
            }
        }

        public async void indizio()
        {
            reset_operations();
            await uda_server_communication.Server_Request(completed);
            Image_Indizio(uda_server_communication.indizio + "_" + uda_server_communication.turno);
            Thread.Sleep(2000);
        }
        public void reset_operations()
        {
            star1.Visible = false;
            star2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            lbl_Alkaid.Visible = false;
            lbl_Mizar.Visible = false;
            lbl_alioth.Visible = false;
            lbl_Megrez.Visible = false;
            lbl_Dubhe.Visible = false;
            lbl_Merak.Visible = false;
            lbl_Phecda.Visible = false;
            lbl_Error.Visible = false;
        }
        public async void PutStarted()
        {
            await uda_server_communication.Server_Request("api/uda/put/?i=1&k=7&data=" + parentForm.data_start);

        }
        public void Ursa_Final()
        {
            indizio_box.Visible = false;
            star1.Visible = true;
            star2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            lbl_Alkaid.Visible = true;
            lbl_Mizar.Visible = true;
            lbl_alioth.Visible = true;
            lbl_Megrez.Visible = true;
            lbl_Dubhe.Visible = true;
            lbl_Merak.Visible = true;
            lbl_Phecda.Visible = true;
            lbl_Error.Visible = true;
            lbl_Error.Visible = true;
            this.Update();
            while (contatore_ts >= 0)
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
            }
            contatore_ts = 5;
        }
        private void Ursa_Load(object sender, EventArgs e)
        {
           
        }
    }
}
