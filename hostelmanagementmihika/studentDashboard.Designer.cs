namespace hostelmanagementmihika
{
    partial class studentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentDashboard));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            profile = new Button();
            feepayment = new Button();
            maintenancerequest = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guestlog = new Button();
            academicdetails = new Button();
            attendance = new Button();
            notices = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(426, 81);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1239, 837);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(631, 9);
            label1.Name = "label1";
            label1.Size = new Size(646, 70);
            label1.TabIndex = 2;
            label1.Text = "STUDENT DASHBOARD";
            // 
            // profile
            // 
            profile.BackColor = Color.Lavender;
            profile.BackgroundImageLayout = ImageLayout.Center;
            profile.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profile.ForeColor = Color.DarkSlateBlue;
            profile.Location = new Point(31, 145);
            profile.Name = "profile";
            profile.Size = new Size(361, 63);
            profile.TabIndex = 3;
            profile.Text = "profile";
            profile.TextAlign = ContentAlignment.TopCenter;
            profile.UseVisualStyleBackColor = false;
            profile.Click += profile_Click;
            // 
            // feepayment
            // 
            feepayment.BackColor = Color.Lavender;
            feepayment.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feepayment.ForeColor = Color.DarkSlateBlue;
            feepayment.Location = new Point(31, 604);
            feepayment.Name = "feepayment";
            feepayment.Size = new Size(361, 73);
            feepayment.TabIndex = 4;
            feepayment.Text = "fee payment";
            feepayment.UseVisualStyleBackColor = false;
            feepayment.Click += feepayment_Click;
            // 
            // maintenancerequest
            // 
            maintenancerequest.BackColor = Color.Lavender;
            maintenancerequest.Font = new Font("Segoe UI", 13.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maintenancerequest.ForeColor = Color.DarkSlateBlue;
            maintenancerequest.Location = new Point(31, 716);
            maintenancerequest.Name = "maintenancerequest";
            maintenancerequest.Size = new Size(361, 69);
            maintenancerequest.TabIndex = 5;
            maintenancerequest.Text = "maintenance request";
            maintenancerequest.UseVisualStyleBackColor = false;
            maintenancerequest.Click += maintenancerequest_Click;
            // 
            // guestlog
            // 
            guestlog.BackColor = Color.Lavender;
            guestlog.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guestlog.ForeColor = Color.DarkSlateBlue;
            guestlog.Location = new Point(31, 515);
            guestlog.Name = "guestlog";
            guestlog.Size = new Size(361, 63);
            guestlog.TabIndex = 8;
            guestlog.Text = "guest log";
            guestlog.TextAlign = ContentAlignment.TopCenter;
            guestlog.UseVisualStyleBackColor = false;
            guestlog.Click += guestlog_Click;
            // 
            // academicdetails
            // 
            academicdetails.BackColor = Color.Lavender;
            academicdetails.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            academicdetails.ForeColor = Color.DarkSlateBlue;
            academicdetails.Location = new Point(31, 236);
            academicdetails.Name = "academicdetails";
            academicdetails.Size = new Size(361, 63);
            academicdetails.TabIndex = 9;
            academicdetails.Text = "academic details";
            academicdetails.TextAlign = ContentAlignment.TopCenter;
            academicdetails.UseVisualStyleBackColor = false;
            academicdetails.Click += academicdetails_Click;
            // 
            // attendance
            // 
            attendance.BackColor = Color.Lavender;
            attendance.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendance.ForeColor = Color.DarkSlateBlue;
            attendance.Location = new Point(31, 324);
            attendance.Name = "attendance";
            attendance.RightToLeft = RightToLeft.Yes;
            attendance.Size = new Size(361, 63);
            attendance.TabIndex = 11;
            attendance.Text = "Biometric ";
            attendance.UseVisualStyleBackColor = false;
            attendance.Click += button4_Click;
            // 
            // notices
            // 
            notices.BackColor = Color.Lavender;
            notices.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notices.ForeColor = Color.DarkSlateBlue;
            notices.Location = new Point(31, 423);
            notices.Name = "notices";
            notices.Size = new Size(361, 63);
            notices.TabIndex = 12;
            notices.Text = "notices";
            notices.TextAlign = ContentAlignment.TopCenter;
            notices.UseVisualStyleBackColor = false;
            notices.Click += notices_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Font = new Font("Segoe UI", 13.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkSlateBlue;
            button1.Location = new Point(31, 815);
            button1.Name = "button1";
            button1.Size = new Size(361, 69);
            button1.TabIndex = 13;
            button1.Text = "--";
            button1.UseVisualStyleBackColor = false;
            // 
            // studentDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1674, 929);
            Controls.Add(button1);
            Controls.Add(notices);
            Controls.Add(attendance);
            Controls.Add(academicdetails);
            Controls.Add(guestlog);
            Controls.Add(maintenancerequest);
            Controls.Add(feepayment);
            Controls.Add(profile);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "studentDashboard";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button profile;
        private Button feepayment;
        private Button maintenancerequest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button guestlog;
        private Button academicdetails;
        private Button attendance;
        private Button notices;
        private Button button1;
    }
}
