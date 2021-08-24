using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Forma_Delle_Stelle
{
    public partial class Ursa : UserControl
    {
        public Main parentForm { get; set; }
        public Ursa()
        {
            InitializeComponent();
        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

        public void indizio()
        {
            reset_operations();
            this.Update();
            lbl_Error.Text = "ECCO L'INDIZIO!";
            this.Update();
            indizio_box.Visible = true;
            this.Update();

        }
        public void reset_operations()
        {

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
        private void Ursa_Load(object sender, EventArgs e)
        {
     
        }
    }
}
