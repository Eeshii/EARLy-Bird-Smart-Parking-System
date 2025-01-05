namespace ParkingReservationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Loginbtn = new Label();
            Addcustomerbtn = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Loginbtn
            // 
            Loginbtn.AutoSize = true;
            Loginbtn.BackColor = Color.Transparent;
            Loginbtn.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginbtn.ForeColor = SystemColors.ButtonHighlight;
            Loginbtn.Location = new Point(257, 326);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(75, 29);
            Loginbtn.TabIndex = 0;
            Loginbtn.Text = "Admin";
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Addcustomerbtn
            // 
            Addcustomerbtn.AutoSize = true;
            Addcustomerbtn.BackColor = Color.Transparent;
            Addcustomerbtn.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addcustomerbtn.ForeColor = SystemColors.ButtonHighlight;
            Addcustomerbtn.Location = new Point(75, 327);
            Addcustomerbtn.Name = "Addcustomerbtn";
            Addcustomerbtn.Size = new Size(109, 29);
            Addcustomerbtn.TabIndex = 1;
            Addcustomerbtn.Text = "Customer";
            Addcustomerbtn.Click += Addcustomerbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(724, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 29);
            label1.TabIndex = 2;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Form1design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 430);
            Controls.Add(label1);
            Controls.Add(Addcustomerbtn);
            Controls.Add(Loginbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Loginbtn;
        private Label Addcustomerbtn;
        private Label label1;
    }
}
