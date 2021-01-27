namespace La_Forma_Delle_Stelle
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.activity1 = new La_Forma_Delle_Stelle.activity();
            this.interaction1 = new La_Forma_Delle_Stelle.Interaction();
            this.initial1 = new La_Forma_Delle_Stelle.Initial();
            this.ursa1 = new La_Forma_Delle_Stelle.Ursa();
            this.SuspendLayout();
            // 
            // activity1
            // 
            this.activity1.BackColor = System.Drawing.Color.Transparent;
            this.activity1.Location = new System.Drawing.Point(523, 12);
            this.activity1.Name = "activity1";
            this.activity1.parentForm = null;
            this.activity1.Size = new System.Drawing.Size(904, 477);
            this.activity1.TabIndex = 2;
            // 
            // interaction1
            // 
            this.interaction1.BackColor = System.Drawing.Color.Transparent;
            this.interaction1.Location = new System.Drawing.Point(307, 31);
            this.interaction1.Name = "interaction1";
            this.interaction1.parentForm = null;
            this.interaction1.Size = new System.Drawing.Size(879, 390);
            this.interaction1.TabIndex = 1;
            // 
            // initial1
            // 
            this.initial1.BackColor = System.Drawing.Color.Transparent;
            this.initial1.Location = new System.Drawing.Point(3, -1);
            this.initial1.Name = "initial1";
            this.initial1.parentForm = null;
            this.initial1.Size = new System.Drawing.Size(880, 364);
            this.initial1.TabIndex = 0;
            // 
            // ursa1
            // 
            this.ursa1.BackColor = System.Drawing.Color.Transparent;
            this.ursa1.Location = new System.Drawing.Point(-7, -1);
            this.ursa1.Name = "ursa1";
            this.ursa1.parentForm = null;
            this.ursa1.Size = new System.Drawing.Size(761, 364);
            this.ursa1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::La_Forma_Delle_Stelle.Properties.Resources.Cielo_Stellato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ursa1);
            this.Controls.Add(this.activity1);
            this.Controls.Add(this.interaction1);
            this.Controls.Add(this.initial1);
            this.Name = "Main";
            this.Text = "La Forma Delle Stelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Initial initial1;
        private Interaction interaction1;
        private activity activity1;
        private Ursa ursa1;
    }
}

