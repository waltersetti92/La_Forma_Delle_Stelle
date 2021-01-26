namespace La_Forma_Delle_Stelle
{
    partial class Interaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_minutes = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_conferma = new System.Windows.Forms.Button();
            this.txt_answers = new System.Windows.Forms.TextBox();
            this.Circle1 = new System.Windows.Forms.PictureBox();
            this.Circle2 = new System.Windows.Forms.PictureBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.op3 = new System.Windows.Forms.Label();
            this.op4 = new System.Windows.Forms.Label();
            this.op5 = new System.Windows.Forms.Label();
            this.op6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Circle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe Script", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Lime;
            this.timerLabel.Location = new System.Drawing.Point(559, 178);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(279, 317);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "5";
            this.timerLabel.Click += new System.EventHandler(this.timerLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_minutes
            // 
            this.lbl_minutes.AutoSize = true;
            this.lbl_minutes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_minutes.Font = new System.Drawing.Font("Segoe Script", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minutes.ForeColor = System.Drawing.Color.Lime;
            this.lbl_minutes.Location = new System.Drawing.Point(1167, -10);
            this.lbl_minutes.Name = "lbl_minutes";
            this.lbl_minutes.Size = new System.Drawing.Size(123, 49);
            this.lbl_minutes.TabIndex = 2;
            this.lbl_minutes.Text = "00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_conferma
            // 
            this.btn_conferma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.ForeColor = System.Drawing.Color.Blue;
            this.btn_conferma.Location = new System.Drawing.Point(554, 556);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(209, 47);
            this.btn_conferma.TabIndex = 3;
            this.btn_conferma.Text = "CONFERMA ";
            this.btn_conferma.UseVisualStyleBackColor = true;
            // 
            // txt_answers
            // 
            this.txt_answers.Location = new System.Drawing.Point(554, 519);
            this.txt_answers.Name = "txt_answers";
            this.txt_answers.Size = new System.Drawing.Size(211, 20);
            this.txt_answers.TabIndex = 4;
            // 
            // Circle1
            // 
            this.Circle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Circle1.Image = global::La_Forma_Delle_Stelle.Properties.Resources.Circle;
            this.Circle1.Location = new System.Drawing.Point(111, 75);
            this.Circle1.Name = "Circle1";
            this.Circle1.Size = new System.Drawing.Size(379, 441);
            this.Circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle1.TabIndex = 5;
            this.Circle1.TabStop = false;
            // 
            // Circle2
            // 
            this.Circle2.Image = global::La_Forma_Delle_Stelle.Properties.Resources.Circle;
            this.Circle2.Location = new System.Drawing.Point(813, 75);
            this.Circle2.Name = "Circle2";
            this.Circle2.Size = new System.Drawing.Size(379, 441);
            this.Circle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle2.TabIndex = 6;
            this.Circle2.TabStop = false;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(618, 483);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(82, 33);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.Text = "label1";
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.BackColor = System.Drawing.Color.Transparent;
            this.op1.Font = new System.Drawing.Font("Segoe Script", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.ForeColor = System.Drawing.Color.Lime;
            this.op1.Location = new System.Drawing.Point(220, 126);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(144, 60);
            this.op1.TabIndex = 8;
            this.op1.Text = "label1";
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.BackColor = System.Drawing.Color.Transparent;
            this.op2.Font = new System.Drawing.Font("Segoe Script", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.ForeColor = System.Drawing.Color.Lime;
            this.op2.Location = new System.Drawing.Point(101, 249);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(144, 60);
            this.op2.TabIndex = 9;
            this.op2.Text = "label1";
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.BackColor = System.Drawing.Color.Transparent;
            this.op3.Font = new System.Drawing.Font("Segoe Script", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.ForeColor = System.Drawing.Color.Lime;
            this.op3.Location = new System.Drawing.Point(101, 389);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(144, 60);
            this.op3.TabIndex = 10;
            this.op3.Text = "label2";
            // 
            // op4
            // 
            this.op4.AutoSize = true;
            this.op4.BackColor = System.Drawing.Color.Transparent;
            this.op4.Font = new System.Drawing.Font("Segoe Script", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op4.ForeColor = System.Drawing.Color.Lime;
            this.op4.Location = new System.Drawing.Point(1048, 126);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(144, 60);
            this.op4.TabIndex = 11;
            this.op4.Text = "label1";
            // 
            // op5
            // 
            this.op5.AutoSize = true;
            this.op5.BackColor = System.Drawing.Color.Transparent;
            this.op5.Font = new System.Drawing.Font("Segoe Script", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op5.ForeColor = System.Drawing.Color.Lime;
            this.op5.Location = new System.Drawing.Point(1091, 249);
            this.op5.Name = "op5";
            this.op5.Size = new System.Drawing.Size(144, 60);
            this.op5.TabIndex = 12;
            this.op5.Text = "label1";
            // 
            // op6
            // 
            this.op6.AutoSize = true;
            this.op6.BackColor = System.Drawing.Color.Transparent;
            this.op6.Font = new System.Drawing.Font("Segoe Script", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op6.ForeColor = System.Drawing.Color.Lime;
            this.op6.Location = new System.Drawing.Point(1091, 389);
            this.op6.Name = "op6";
            this.op6.Size = new System.Drawing.Size(144, 60);
            this.op6.TabIndex = 13;
            this.op6.Text = "label1";
            // 
            // Interaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.op6);
            this.Controls.Add(this.op5);
            this.Controls.Add(this.op4);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.Circle2);
            this.Controls.Add(this.Circle1);
            this.Controls.Add(this.txt_answers);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.lbl_minutes);
            this.Controls.Add(this.timerLabel);
            this.Name = "Interaction";
            this.Size = new System.Drawing.Size(1303, 762);
            this.Load += new System.EventHandler(this.Interaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Circle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_minutes;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.TextBox txt_answers;
        private System.Windows.Forms.PictureBox Circle1;
        private System.Windows.Forms.PictureBox Circle2;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.Label op3;
        private System.Windows.Forms.Label op4;
        private System.Windows.Forms.Label op5;
        private System.Windows.Forms.Label op6;
    }
}
