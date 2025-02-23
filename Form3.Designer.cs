﻿namespace ParkingReservationApp
{
    partial class Form3
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtCarType = new TextBox();
            txtLicense = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbReservationType = new ComboBox();
            cmbSlot = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            SaveBtn = new Label();
            Exitbtn = new Label();
            dtpDateTime = new DateTimePicker();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 0);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = SystemColors.Window;
            txtName.Location = new Point(125, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(426, 24);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 0);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.Window;
            txtEmail.Location = new Point(125, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(426, 24);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(64, 64, 0);
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = SystemColors.Window;
            txtPhone.Location = new Point(209, 150);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(342, 24);
            txtPhone.TabIndex = 2;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtCarType
            // 
            txtCarType.BackColor = Color.FromArgb(64, 64, 0);
            txtCarType.BorderStyle = BorderStyle.None;
            txtCarType.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarType.ForeColor = SystemColors.Window;
            txtCarType.Location = new Point(164, 183);
            txtCarType.Name = "txtCarType";
            txtCarType.Size = new Size(387, 24);
            txtCarType.TabIndex = 3;
            // 
            // txtLicense
            // 
            txtLicense.BackColor = Color.FromArgb(64, 64, 0);
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicense.ForeColor = SystemColors.Window;
            txtLicense.Location = new Point(222, 215);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(329, 24);
            txtLicense.TabIndex = 4;
            txtLicense.TextChanged += txtLicense_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(41, 79);
            label1.Name = "label1";
            label1.Size = new Size(84, 34);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(80, 34);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 147);
            label3.Name = "label3";
            label3.Size = new Size(162, 29);
            label3.TabIndex = 8;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(41, 177);
            label4.Name = "label4";
            label4.Size = new Size(117, 34);
            label4.TabIndex = 9;
            label4.Text = "Car Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(41, 212);
            label5.Name = "label5";
            label5.Size = new Size(175, 29);
            label5.TabIndex = 10;
            label5.Text = "License Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(41, 284);
            label6.Name = "label6";
            label6.Size = new Size(155, 29);
            label6.TabIndex = 11;
            label6.Text = "Time And Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(41, 246);
            label7.Name = "label7";
            label7.Size = new Size(186, 29);
            label7.TabIndex = 12;
            label7.Text = "Reservation Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(41, 317);
            label8.Name = "label8";
            label8.Size = new Size(156, 34);
            label8.TabIndex = 16;
            label8.Text = "Slot Number:";
            // 
            // cmbReservationType
            // 
            cmbReservationType.BackColor = Color.FromArgb(64, 64, 0);
            cmbReservationType.FlatStyle = FlatStyle.Flat;
            cmbReservationType.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReservationType.ForeColor = SystemColors.Window;
            cmbReservationType.FormattingEnabled = true;
            cmbReservationType.Items.AddRange(new object[] { "PWD", "Pregnant", "Senior Citizen" });
            cmbReservationType.Location = new Point(222, 248);
            cmbReservationType.Name = "cmbReservationType";
            cmbReservationType.Size = new Size(329, 31);
            cmbReservationType.TabIndex = 19;
            // 
            // cmbSlot
            // 
            cmbSlot.BackColor = Color.FromArgb(64, 64, 0);
            cmbSlot.FlatStyle = FlatStyle.Flat;
            cmbSlot.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSlot.ForeColor = SystemColors.Window;
            cmbSlot.FormattingEnabled = true;
            cmbSlot.Items.AddRange(new object[] { "PWD", "Pregnant", "Senior Citizen" });
            cmbSlot.Location = new Point(194, 322);
            cmbSlot.Name = "cmbSlot";
            cmbSlot.Size = new Size(357, 31);
            cmbSlot.TabIndex = 20;
            cmbSlot.SelectedIndexChanged += cmbSlot_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(577, 229);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 73);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Btn_layout_removebg_preview;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(577, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 68);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = true;
            SaveBtn.BackColor = Color.Transparent;
            SaveBtn.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = SystemColors.ButtonHighlight;
            SaveBtn.Image = Properties.Resources.Btn_layout_removebg_preview;
            SaveBtn.Location = new Point(614, 188);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(54, 26);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.AutoSize = true;
            Exitbtn.BackColor = Color.Transparent;
            Exitbtn.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exitbtn.ForeColor = SystemColors.ButtonHighlight;
            Exitbtn.Image = Properties.Resources.Btn_layout_removebg_preview;
            Exitbtn.Location = new Point(618, 252);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(41, 26);
            Exitbtn.TabIndex = 24;
            Exitbtn.Text = "Exit";
            Exitbtn.Click += Exitbtn_Click;
            // 
            // dtpDateTime
            // 
            dtpDateTime.CalendarForeColor = Color.Transparent;
            dtpDateTime.CalendarMonthBackground = Color.Transparent;
            dtpDateTime.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateTime.Location = new Point(194, 285);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(357, 31);
            dtpDateTime.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(181, 42);
            label9.Name = "label9";
            label9.Size = new Size(224, 36);
            label9.TabIndex = 26;
            label9.Text = "Reservation Form";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.REservationDesign_;
            ClientSize = new Size(721, 407);
            Controls.Add(label9);
            Controls.Add(dtpDateTime);
            Controls.Add(Exitbtn);
            Controls.Add(SaveBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cmbSlot);
            Controls.Add(cmbReservationType);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLicense);
            Controls.Add(txtCarType);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtCarType;
        private TextBox txtLicense;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbReservationType;
        private ComboBox cmbSlot;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label SaveBtn;
        private Label Exitbtn;
        private DateTimePicker dtpDateTime;
        private Label label9;
    }
}