namespace ASM2_DDD
{
    partial class StudentForm
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
            label1 = new Label();
            btnLogout = new Button();
            dgvStudentTab = new DataGridView();
            ScheduleID = new DataGridViewTextBoxColumn();
            CourseID = new DataGridViewTextBoxColumn();
            ClassroomName = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewTextBoxColumn();
            DayOfWeek = new DataGridViewTextBoxColumn();
            lblSID = new Label();
            lblSname = new Label();
            lblSemail = new Label();
            lblMajor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentTab).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(473, 19);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 3;
            label1.Text = "Weekly Timeable";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkViolet;
            btnLogout.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1068, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvStudentTab
            // 
            dgvStudentTab.BackgroundColor = SystemColors.InactiveBorder;
            dgvStudentTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentTab.Columns.AddRange(new DataGridViewColumn[] { ScheduleID, CourseID, ClassroomName, StartTime, EndTime, Instructor, DayOfWeek });
            dgvStudentTab.Location = new Point(5, 279);
            dgvStudentTab.Name = "dgvStudentTab";
            dgvStudentTab.RowHeadersWidth = 51;
            dgvStudentTab.RowTemplate.Height = 29;
            dgvStudentTab.Size = new Size(1165, 360);
            dgvStudentTab.TabIndex = 6;
            // 
            // ScheduleID
            // 
            ScheduleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ScheduleID.DataPropertyName = "ScheduleID";
            ScheduleID.HeaderText = "Schedule ID";
            ScheduleID.MinimumWidth = 6;
            ScheduleID.Name = "ScheduleID";
            // 
            // CourseID
            // 
            CourseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseID.DataPropertyName = "CourseID";
            CourseID.HeaderText = "Course ID";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            // 
            // ClassroomName
            // 
            ClassroomName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassroomName.DataPropertyName = "ClassroomName";
            ClassroomName.HeaderText = "Classroom Name";
            ClassroomName.MinimumWidth = 6;
            ClassroomName.Name = "ClassroomName";
            // 
            // StartTime
            // 
            StartTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StartTime.DataPropertyName = "StartTime";
            StartTime.HeaderText = "Start Time";
            StartTime.MinimumWidth = 6;
            StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            EndTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EndTime.DataPropertyName = "EndTime";
            EndTime.HeaderText = "End Time";
            EndTime.MinimumWidth = 6;
            EndTime.Name = "EndTime";
            // 
            // Instructor
            // 
            Instructor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Instructor.DataPropertyName = "Instructor";
            Instructor.HeaderText = "Instructor";
            Instructor.MinimumWidth = 6;
            Instructor.Name = "Instructor";
            // 
            // DayOfWeek
            // 
            DayOfWeek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DayOfWeek.DataPropertyName = "Day_Of_Week";
            DayOfWeek.HeaderText = "Day Of Week";
            DayOfWeek.MinimumWidth = 6;
            DayOfWeek.Name = "DayOfWeek";
            // 
            // lblSID
            // 
            lblSID.AutoSize = true;
            lblSID.Location = new Point(269, 87);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(0, 20);
            lblSID.TabIndex = 7;
            // 
            // lblSname
            // 
            lblSname.AutoSize = true;
            lblSname.Location = new Point(269, 136);
            lblSname.Name = "lblSname";
            lblSname.Size = new Size(0, 20);
            lblSname.TabIndex = 8;
            // 
            // lblSemail
            // 
            lblSemail.AutoSize = true;
            lblSemail.Location = new Point(269, 183);
            lblSemail.Name = "lblSemail";
            lblSemail.Size = new Size(0, 20);
            lblSemail.TabIndex = 9;
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Location = new Point(269, 234);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(0, 20);
            lblMajor.TabIndex = 10;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1174, 651);
            Controls.Add(lblMajor);
            Controls.Add(lblSemail);
            Controls.Add(lblSname);
            Controls.Add(lblSID);
            Controls.Add(dgvStudentTab);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentTab).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private DataGridView dgvStudentTab;
        private DataGridViewTextBoxColumn ScheduleID;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn ClassroomName;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn DayOfWeek;
        private Label lblSID;
        private Label lblSname;
        private Label lblSemail;
        private Label lblMajor;
    }
}