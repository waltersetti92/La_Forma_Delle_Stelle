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
            completed = "api/uda/put/?i=3&k=16";
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
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
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
                        parentForm.playbackResourceAudio("success");
                        Thread.Sleep(2000);
                        this.Update();
                        break;
                    }
                }
            }
        }

        public async void indizio()
        {
            star_invisible();
            await uda_server_communication.Server_Request(completed);
            Image_Indizio(uda_server_communication.indizio + "_" + uda_server_communication.turno);
            
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
            await uda_server_communication.Server_Request("api/uda/put/?i=3&k=7&data=" + parentForm.data_start);

        }
        public void Ursa_Final()
        {
            pictureBox1.WaitOnLoad = true;
            pictureBox1.ImageLocation = Main.resourcesPath + "\\" + "first.png";
            pictureBox1.Visible = true;
            star1.WaitOnLoad = true;
            star1.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            star1.Visible = true;
            lbl_Alkaid.Visible = true;
            pictureBox2.WaitOnLoad = true;
            pictureBox2.ImageLocation = Main.resourcesPath + "\\" + "second.png";
            pictureBox2.Visible = true;
            star2.WaitOnLoad = true;
            star2.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            lbl_Mizar.Visible = true;
            pictureBox3.WaitOnLoad = true;
            pictureBox3.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            pictureBox3.Visible = true;
            pictureBox4.WaitOnLoad = true;
            pictureBox4.ImageLocation = Main.resourcesPath + "\\" + "third.png";
            pictureBox4.Visible = true;
            lbl_alioth.Visible = true;
            pictureBox5.WaitOnLoad = true;
            pictureBox5.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            pictureBox5.Visible = true;
            pictureBox6.WaitOnLoad = true;
            pictureBox6.ImageLocation = Main.resourcesPath + "\\" + "fourth.png";
            lbl_Megrez.Visible = true;
            pictureBox7.WaitOnLoad = true;
            pictureBox7.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            pictureBox7.Visible = true;
            pictureBox8.WaitOnLoad = true;
            pictureBox8.ImageLocation = Main.resourcesPath + "\\" + "fifth.png";
            pictureBox8.Visible = true;
            lbl_Dubhe.Visible = true;
            pictureBox9.WaitOnLoad = true;
            pictureBox9.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            pictureBox9.Visible = true;
            pictureBox10.WaitOnLoad = true;
            pictureBox10.ImageLocation = Main.resourcesPath + "\\" + "sei.png";
            pictureBox10.Visible = true;
            lbl_Merak.Visible = true;
            pictureBox11.WaitOnLoad = true;
            pictureBox11.ImageLocation = Main.resourcesPath + "\\" + "star.png";
            pictureBox11.Visible = true;
            pictureBox12.WaitOnLoad = true;
            pictureBox12.ImageLocation = Main.resourcesPath + "\\" + "seventh.png";
            lbl_Phecda.Visible = true;
            indizio_box.Visible = false;
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
                }
            }
            Thread.Sleep(7000);
            contatore_ts = 5;
        }
        public void star_invisible()
        {
            pictureBox1.Image = null;
            star1.Image = null;
            lbl_Alkaid.Visible = false;
            pictureBox2.Image = null;
            star2.Image = null;
            lbl_Mizar.Visible = false;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            lbl_alioth.Visible = false;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            lbl_Megrez.Visible = false;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            lbl_Dubhe.Visible = false;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            lbl_Merak.Visible = false;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            lbl_Phecda.Visible = false;
            this.Update();
        }
        private void Ursa_Load(object sender, EventArgs e)
        {
           
        }

        private void star1_Click(object sender, EventArgs e)
        {

        }
    }
}
