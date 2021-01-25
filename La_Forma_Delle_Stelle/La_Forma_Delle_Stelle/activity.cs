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
    public partial class activity : UserControl
    {
        public Main parentForm { get; set; }
        public activity()
        {
            InitializeComponent();
        }

        private void activity_Load(object sender, EventArgs e)
        {

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

    }
}
