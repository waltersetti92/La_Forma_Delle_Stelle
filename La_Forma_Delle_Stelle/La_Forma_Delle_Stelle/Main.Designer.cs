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
            this.ursa1 = new La_Forma_Delle_Stelle.Ursa();
            this.activity1 = new La_Forma_Delle_Stelle.activity();
            this.interaction1 = new La_Forma_Delle_Stelle.Interaction();
            this.initial1 = new La_Forma_Delle_Stelle.Initial();
            this.SuspendLayout();
            // 
            // ursa1
            // 
            this.ursa1.BackColor = System.Drawing.Color.Transparent;
            this.ursa1.Location = new System.Drawing.Point(-5, -2);
            this.ursa1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ursa1.Name = "ursa1";
            this.ursa1.parentForm = null;
            this.ursa1.Size = new System.Drawing.Size(1142, 560);
            this.ursa1.TabIndex = 3;
            // 
            // activity1
            // 
            this.activity1.BackColor = System.Drawing.Color.Transparent;
            this.activity1.Location = new System.Drawing.Point(744, 17);
            this.activity1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.activity1.Name = "activity1";
            this.activity1.parentForm = null;
            this.activity1.Size = new System.Drawing.Size(1356, 734);
            this.activity1.TabIndex = 2;
            // 
            // interaction1
            // 
            this.interaction1.AutoSize = true;
            this.interaction1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.interaction1.BackColor = System.Drawing.Color.Transparent;
            this.interaction1.Location = new System.Drawing.Point(460, 48);
            this.interaction1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.interaction1.Name = "interaction1";
            this.interaction1.parentForm = null;
            this.interaction1.Size = new System.Drawing.Size(1131, 606);
            this.interaction1.TabIndex = 1;
            // 
            // initial1
            // 
            this.initial1.AutoSize = true;
            this.initial1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.initial1.BackColor = System.Drawing.Color.Transparent;
            this.initial1.Location = new System.Drawing.Point(4, -2);
            this.initial1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.initial1.Name = "initial1";
            this.initial1.parentForm = null;
            this.initial1.Size = new System.Drawing.Size(1821, 831);
            this.initial1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::La_Forma_Delle_Stelle.Properties.Resources.Cielo_Stellato;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ursa1);
            this.Controls.Add(this.activity1);
            this.Controls.Add(this.interaction1);
            this.Controls.Add(this.initial1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "La Forma Delle Stelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Initial initial1;
        private Interaction interaction1;
        private activity activity1;
        private Ursa ursa1;
    }
}

