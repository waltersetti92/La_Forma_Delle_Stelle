﻿using System;
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
        public Main()
        {
            InitializeComponent();
            initial1.parentForm = this;
            interaction1.parentForm = this;
            initial1.Visible = false;
            interaction1.Visible = false;
            activity1.parentForm = this;
            activity1.Visible = false;
            home();

        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
        }
        public void onStart()
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
            activity1.Visible = true;
            currUC = activity1;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            initial1.setPos(size.Width, size.Height);
            interaction1.setPos(size.Width, size.Height);
            activity1.setPos(size.Width, size.Height);
        }
    }
}
