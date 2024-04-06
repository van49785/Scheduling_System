namespace ASM2_DDD
{
    partial class AdminForm
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
            tabControl1 = new TabControl();
            StudentTab = new TabPage();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            textBox3 = new TextBox();
            tbxSName = new TextBox();
            tbxSID = new TextBox();
            label4 = new Label();
            cbxMajor = new ComboBox();
            tbxEmail = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvStudentTab = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Major = new DataGridViewTextBoxColumn();
            CoursesTab = new TabPage();
            btnCInsert = new Button();
            btnCUpdate = new Button();
            btnCDelete = new Button();
            btnCSearch = new Button();
            btnCCancel = new Button();
            tbxCSearch = new TextBox();
            dgvCourse = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Credits = new DataGridViewTextBoxColumn();
            DepartmentID = new DataGridViewTextBoxColumn();
            cbxDep = new ComboBox();
            tbxCredit = new TextBox();
            tbxCName = new TextBox();
            tbxCID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            ClassroomTab = new TabPage();
            btnRSearch = new Button();
            btnRDelete = new Button();
            btnRUpdate = new Button();
            btnRInsert = new Button();
            btnRCancel = new Button();
            tbxRSearch = new TextBox();
            tbxCap = new TextBox();
            tbxRName = new TextBox();
            dgvClassroom = new DataGridView();
            ClassroomName = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            label11 = new Label();
            label10 = new Label();
            ScheduleTab = new TabPage();
            tbxEID = new TextBox();
            label18 = new Label();
            btnESearch = new Button();
            btnEDelete = new Button();
            btnEUpdate = new Button();
            btnEInsert = new Button();
            btnECancel = new Button();
            textBox1 = new TextBox();
            label17 = new Label();
            cbxDay = new ComboBox();
            dgvSchedule = new DataGridView();
            ScheduleID = new DataGridViewTextBoxColumn();
            CourseN = new DataGridViewTextBoxColumn();
            ClassroomN = new DataGridViewTextBoxColumn();
            StartTime = new DataGridViewTextBoxColumn();
            EndTime = new DataGridViewTextBoxColumn();
            Instructor = new DataGridViewTextBoxColumn();
            DayOfWeek = new DataGridViewTextBoxColumn();
            tbxInstructor = new TextBox();
            tbxETime = new TextBox();
            tbxSTime = new TextBox();
            tbxERoom = new TextBox();
            tbxECID = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label9 = new Label();
            btnLogout = new Button();
            tabControl1.SuspendLayout();
            StudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentTab).BeginInit();
            CoursesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            ClassroomTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassroom).BeginInit();
            ScheduleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(StudentTab);
            tabControl1.Controls.Add(CoursesTab);
            tabControl1.Controls.Add(ClassroomTab);
            tabControl1.Controls.Add(ScheduleTab);
            tabControl1.Location = new Point(2, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1213, 633);
            tabControl1.TabIndex = 0;
            // 
            // StudentTab
            // 
            StudentTab.BackColor = Color.Lavender;
            StudentTab.Controls.Add(tbxSearch);
            StudentTab.Controls.Add(btnSearch);
            StudentTab.Controls.Add(btnCancel);
            StudentTab.Controls.Add(btnDelete);
            StudentTab.Controls.Add(btnUpdate);
            StudentTab.Controls.Add(btnInsert);
            StudentTab.Controls.Add(textBox3);
            StudentTab.Controls.Add(tbxSName);
            StudentTab.Controls.Add(tbxSID);
            StudentTab.Controls.Add(label4);
            StudentTab.Controls.Add(cbxMajor);
            StudentTab.Controls.Add(tbxEmail);
            StudentTab.Controls.Add(label2);
            StudentTab.Controls.Add(label1);
            StudentTab.Controls.Add(dgvStudentTab);
            StudentTab.Location = new Point(4, 29);
            StudentTab.Name = "StudentTab";
            StudentTab.Padding = new Padding(3);
            StudentTab.Size = new Size(1205, 600);
            StudentTab.TabIndex = 0;
            StudentTab.Text = "Student";
            StudentTab.Click += StudentTab_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(635, 26);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(235, 27);
            tbxSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(876, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Yellow;
            btnCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(125, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 42);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(980, 523);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 42);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(815, 523);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 42);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LimeGreen;
            btnInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(650, 523);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 42);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 27);
            textBox3.TabIndex = 8;
            // 
            // tbxSName
            // 
            tbxSName.Location = new Point(17, 179);
            tbxSName.Name = "tbxSName";
            tbxSName.Size = new Size(303, 27);
            tbxSName.TabIndex = 7;
            // 
            // tbxSID
            // 
            tbxSID.Location = new Point(17, 96);
            tbxSID.Name = "tbxSID";
            tbxSID.Size = new Size(303, 27);
            tbxSID.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 324);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Major";
            // 
            // cbxMajor
            // 
            cbxMajor.FormattingEnabled = true;
            cbxMajor.Items.AddRange(new object[] { "Computing ", "Graphic Design ", "Business" });
            cbxMajor.Location = new Point(17, 347);
            cbxMajor.Name = "cbxMajor";
            cbxMajor.Size = new Size(303, 28);
            cbxMajor.TabIndex = 4;
            // 
            // tbxEmail
            // 
            tbxEmail.AutoSize = true;
            tbxEmail.Location = new Point(17, 243);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(46, 20);
            tbxEmail.TabIndex = 3;
            tbxEmail.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 156);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 73);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // dgvStudentTab
            // 
            dgvStudentTab.BackgroundColor = SystemColors.InactiveBorder;
            dgvStudentTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentTab.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Email, Major });
            dgvStudentTab.Location = new Point(407, 68);
            dgvStudentTab.Name = "dgvStudentTab";
            dgvStudentTab.RowHeadersWidth = 51;
            dgvStudentTab.RowTemplate.Height = 29;
            dgvStudentTab.Size = new Size(790, 430);
            dgvStudentTab.TabIndex = 0;
            dgvStudentTab.CellClick += dgvStudentTab_CellClick;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "Student ID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentName.DataPropertyName = "studentName";
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Major
            // 
            Major.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Major.DataPropertyName = "Major";
            Major.HeaderText = "Major";
            Major.MinimumWidth = 6;
            Major.Name = "Major";
            // 
            // CoursesTab
            // 
            CoursesTab.BackColor = Color.Lavender;
            CoursesTab.Controls.Add(btnCInsert);
            CoursesTab.Controls.Add(btnCUpdate);
            CoursesTab.Controls.Add(btnCDelete);
            CoursesTab.Controls.Add(btnCSearch);
            CoursesTab.Controls.Add(btnCCancel);
            CoursesTab.Controls.Add(tbxCSearch);
            CoursesTab.Controls.Add(dgvCourse);
            CoursesTab.Controls.Add(cbxDep);
            CoursesTab.Controls.Add(tbxCredit);
            CoursesTab.Controls.Add(tbxCName);
            CoursesTab.Controls.Add(tbxCID);
            CoursesTab.Controls.Add(label7);
            CoursesTab.Controls.Add(label6);
            CoursesTab.Controls.Add(label5);
            CoursesTab.Controls.Add(label3);
            CoursesTab.Location = new Point(4, 29);
            CoursesTab.Name = "CoursesTab";
            CoursesTab.Padding = new Padding(3);
            CoursesTab.Size = new Size(1205, 600);
            CoursesTab.TabIndex = 1;
            CoursesTab.Text = "Courses";
            CoursesTab.Click += CoursesTab_Click;
            // 
            // btnCInsert
            // 
            btnCInsert.BackColor = Color.Chartreuse;
            btnCInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCInsert.Location = new Point(582, 519);
            btnCInsert.Name = "btnCInsert";
            btnCInsert.Size = new Size(94, 39);
            btnCInsert.TabIndex = 14;
            btnCInsert.Text = "Insert";
            btnCInsert.UseVisualStyleBackColor = false;
            btnCInsert.Click += btnCInsert_Click;
            // 
            // btnCUpdate
            // 
            btnCUpdate.BackColor = Color.SkyBlue;
            btnCUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCUpdate.Location = new Point(763, 519);
            btnCUpdate.Name = "btnCUpdate";
            btnCUpdate.Size = new Size(94, 39);
            btnCUpdate.TabIndex = 13;
            btnCUpdate.Text = "Update";
            btnCUpdate.UseVisualStyleBackColor = false;
            btnCUpdate.Click += btnCUpdate_Click;
            // 
            // btnCDelete
            // 
            btnCDelete.BackColor = Color.Tomato;
            btnCDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCDelete.Location = new Point(930, 519);
            btnCDelete.Name = "btnCDelete";
            btnCDelete.Size = new Size(94, 39);
            btnCDelete.TabIndex = 12;
            btnCDelete.Text = "Delete";
            btnCDelete.UseVisualStyleBackColor = false;
            btnCDelete.Click += btnCDelete_Click;
            // 
            // btnCSearch
            // 
            btnCSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnCSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCSearch.Location = new Point(916, 25);
            btnCSearch.Name = "btnCSearch";
            btnCSearch.Size = new Size(94, 29);
            btnCSearch.TabIndex = 11;
            btnCSearch.Text = "Search";
            btnCSearch.UseVisualStyleBackColor = false;
            btnCSearch.Click += btnCSearch_Click;
            // 
            // btnCCancel
            // 
            btnCCancel.BackColor = Color.Khaki;
            btnCCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCCancel.Location = new Point(120, 426);
            btnCCancel.Name = "btnCCancel";
            btnCCancel.Size = new Size(94, 39);
            btnCCancel.TabIndex = 10;
            btnCCancel.Text = "Cancel";
            btnCCancel.UseVisualStyleBackColor = false;
            btnCCancel.Click += btnCCancel_Click;
            // 
            // tbxCSearch
            // 
            tbxCSearch.Location = new Point(676, 25);
            tbxCSearch.Name = "tbxCSearch";
            tbxCSearch.Size = new Size(234, 27);
            tbxCSearch.TabIndex = 9;
            // 
            // dgvCourse
            // 
            dgvCourse.BackgroundColor = SystemColors.InactiveBorder;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Credits, DepartmentID });
            dgvCourse.Location = new Point(415, 58);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.RowTemplate.Height = 29;
            dgvCourse.Size = new Size(782, 423);
            dgvCourse.TabIndex = 8;
            dgvCourse.CellClick += dgvCourse_CellClick;
            // 
            // CourseID
            // 
            CourseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseID.DataPropertyName = "CourseID";
            CourseID.HeaderText = "Course ID";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseName.DataPropertyName = "CourseName";
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            // 
            // Credits
            // 
            Credits.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Credits.DataPropertyName = "Credits";
            Credits.HeaderText = "Credits";
            Credits.MinimumWidth = 6;
            Credits.Name = "Credits";
            // 
            // DepartmentID
            // 
            DepartmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepartmentID.DataPropertyName = "DepartmentID";
            DepartmentID.HeaderText = "Department ID";
            DepartmentID.MinimumWidth = 6;
            DepartmentID.Name = "DepartmentID";
            // 
            // cbxDep
            // 
            cbxDep.FormattingEnabled = true;
            cbxDep.Items.AddRange(new object[] { "Computing ", "Graphic Design", "Business" });
            cbxDep.Location = new Point(25, 369);
            cbxDep.Name = "cbxDep";
            cbxDep.Size = new Size(269, 28);
            cbxDep.TabIndex = 7;
            // 
            // tbxCredit
            // 
            tbxCredit.Location = new Point(25, 274);
            tbxCredit.Name = "tbxCredit";
            tbxCredit.Size = new Size(269, 27);
            tbxCredit.TabIndex = 6;
            // 
            // tbxCName
            // 
            tbxCName.Location = new Point(25, 186);
            tbxCName.Name = "tbxCName";
            tbxCName.Size = new Size(269, 27);
            tbxCName.TabIndex = 5;
            // 
            // tbxCID
            // 
            tbxCID.Location = new Point(25, 92);
            tbxCID.Name = "tbxCID";
            tbxCID.Size = new Size(269, 27);
            tbxCID.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 335);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 3;
            label7.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 237);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 2;
            label6.Text = "Credits";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 150);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 1;
            label5.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 58);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Course ID";
            // 
            // ClassroomTab
            // 
            ClassroomTab.BackColor = Color.Lavender;
            ClassroomTab.Controls.Add(btnRSearch);
            ClassroomTab.Controls.Add(btnRDelete);
            ClassroomTab.Controls.Add(btnRUpdate);
            ClassroomTab.Controls.Add(btnRInsert);
            ClassroomTab.Controls.Add(btnRCancel);
            ClassroomTab.Controls.Add(tbxRSearch);
            ClassroomTab.Controls.Add(tbxCap);
            ClassroomTab.Controls.Add(tbxRName);
            ClassroomTab.Controls.Add(dgvClassroom);
            ClassroomTab.Controls.Add(label11);
            ClassroomTab.Controls.Add(label10);
            ClassroomTab.Location = new Point(4, 29);
            ClassroomTab.Name = "ClassroomTab";
            ClassroomTab.Padding = new Padding(3);
            ClassroomTab.Size = new Size(1205, 600);
            ClassroomTab.TabIndex = 2;
            ClassroomTab.Text = "Classroom";
            ClassroomTab.Click += ClassroomTab_Click;
            // 
            // btnRSearch
            // 
            btnRSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnRSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRSearch.Location = new Point(895, 24);
            btnRSearch.Name = "btnRSearch";
            btnRSearch.Size = new Size(94, 29);
            btnRSearch.TabIndex = 15;
            btnRSearch.Text = "Search";
            btnRSearch.UseVisualStyleBackColor = false;
            btnRSearch.Click += btnRSearch_Click;
            // 
            // btnRDelete
            // 
            btnRDelete.BackColor = Color.OrangeRed;
            btnRDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRDelete.Location = new Point(986, 521);
            btnRDelete.Name = "btnRDelete";
            btnRDelete.Size = new Size(94, 43);
            btnRDelete.TabIndex = 14;
            btnRDelete.Text = "Delete";
            btnRDelete.UseVisualStyleBackColor = false;
            btnRDelete.Click += btnRDelete_Click;
            // 
            // btnRUpdate
            // 
            btnRUpdate.BackColor = Color.SkyBlue;
            btnRUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRUpdate.Location = new Point(756, 521);
            btnRUpdate.Name = "btnRUpdate";
            btnRUpdate.Size = new Size(94, 43);
            btnRUpdate.TabIndex = 13;
            btnRUpdate.Text = "Update";
            btnRUpdate.UseVisualStyleBackColor = false;
            btnRUpdate.Click += btnRUpdate_Click;
            // 
            // btnRInsert
            // 
            btnRInsert.BackColor = Color.LightGreen;
            btnRInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRInsert.Location = new Point(527, 521);
            btnRInsert.Name = "btnRInsert";
            btnRInsert.Size = new Size(94, 43);
            btnRInsert.TabIndex = 12;
            btnRInsert.Text = "Insert";
            btnRInsert.UseVisualStyleBackColor = false;
            btnRInsert.Click += btnRInsert_Click;
            // 
            // btnRCancel
            // 
            btnRCancel.BackColor = Color.Khaki;
            btnRCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRCancel.Location = new Point(119, 295);
            btnRCancel.Name = "btnRCancel";
            btnRCancel.Size = new Size(94, 42);
            btnRCancel.TabIndex = 11;
            btnRCancel.Text = "Cancel";
            btnRCancel.UseVisualStyleBackColor = false;
            btnRCancel.Click += btnRCancel_Click;
            // 
            // tbxRSearch
            // 
            tbxRSearch.Location = new Point(638, 26);
            tbxRSearch.Name = "tbxRSearch";
            tbxRSearch.Size = new Size(251, 27);
            tbxRSearch.TabIndex = 10;
            // 
            // tbxCap
            // 
            tbxCap.Location = new Point(18, 232);
            tbxCap.Name = "tbxCap";
            tbxCap.Size = new Size(309, 27);
            tbxCap.TabIndex = 9;
            // 
            // tbxRName
            // 
            tbxRName.Location = new Point(17, 140);
            tbxRName.Name = "tbxRName";
            tbxRName.Size = new Size(309, 27);
            tbxRName.TabIndex = 8;
            // 
            // dgvClassroom
            // 
            dgvClassroom.BackgroundColor = SystemColors.InactiveBorder;
            dgvClassroom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassroom.Columns.AddRange(new DataGridViewColumn[] { ClassroomName, Capacity });
            dgvClassroom.Location = new Point(406, 59);
            dgvClassroom.Name = "dgvClassroom";
            dgvClassroom.RowHeadersWidth = 51;
            dgvClassroom.RowTemplate.Height = 29;
            dgvClassroom.Size = new Size(796, 441);
            dgvClassroom.TabIndex = 5;
            dgvClassroom.CellClick += dgvClassroom_CellClick;
            // 
            // ClassroomName
            // 
            ClassroomName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClassroomName.DataPropertyName = "ClassroomName";
            ClassroomName.HeaderText = "Classroom Name";
            ClassroomName.MinimumWidth = 6;
            ClassroomName.Name = "ClassroomName";
            // 
            // Capacity
            // 
            Capacity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Capacity.DataPropertyName = "Capacity";
            Capacity.HeaderText = "Capacity";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 96);
            label11.Name = "label11";
            label11.Size = new Size(122, 20);
            label11.TabIndex = 3;
            label11.Text = "Classroom Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 189);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 2;
            label10.Text = "Capacity";
            // 
            // ScheduleTab
            // 
            ScheduleTab.BackColor = Color.Lavender;
            ScheduleTab.Controls.Add(tbxEID);
            ScheduleTab.Controls.Add(label18);
            ScheduleTab.Controls.Add(btnESearch);
            ScheduleTab.Controls.Add(btnEDelete);
            ScheduleTab.Controls.Add(btnEUpdate);
            ScheduleTab.Controls.Add(btnEInsert);
            ScheduleTab.Controls.Add(btnECancel);
            ScheduleTab.Controls.Add(textBox1);
            ScheduleTab.Controls.Add(label17);
            ScheduleTab.Controls.Add(cbxDay);
            ScheduleTab.Controls.Add(dgvSchedule);
            ScheduleTab.Controls.Add(tbxInstructor);
            ScheduleTab.Controls.Add(tbxETime);
            ScheduleTab.Controls.Add(tbxSTime);
            ScheduleTab.Controls.Add(tbxERoom);
            ScheduleTab.Controls.Add(tbxECID);
            ScheduleTab.Controls.Add(label16);
            ScheduleTab.Controls.Add(label15);
            ScheduleTab.Controls.Add(label14);
            ScheduleTab.Controls.Add(label13);
            ScheduleTab.Controls.Add(label9);
            ScheduleTab.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ScheduleTab.Location = new Point(4, 29);
            ScheduleTab.Name = "ScheduleTab";
            ScheduleTab.Padding = new Padding(3);
            ScheduleTab.Size = new Size(1205, 600);
            ScheduleTab.TabIndex = 3;
            ScheduleTab.Text = "Schedule";
            ScheduleTab.Click += ScheduleTab_Click;
            // 
            // tbxEID
            // 
            tbxEID.Location = new Point(78, 62);
            tbxEID.Name = "tbxEID";
            tbxEID.Size = new Size(294, 28);
            tbxEID.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(78, 29);
            label18.Name = "label18";
            label18.Size = new Size(86, 20);
            label18.TabIndex = 19;
            label18.Text = "Schedule ID";
            // 
            // btnESearch
            // 
            btnESearch.BackColor = Color.FromArgb(255, 192, 192);
            btnESearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnESearch.Location = new Point(694, 210);
            btnESearch.Name = "btnESearch";
            btnESearch.Size = new Size(94, 29);
            btnESearch.TabIndex = 18;
            btnESearch.Text = "Search";
            btnESearch.UseVisualStyleBackColor = false;
            btnESearch.Click += btnESearch_Click;
            // 
            // btnEDelete
            // 
            btnEDelete.BackColor = Color.Tomato;
            btnEDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEDelete.Location = new Point(6, 447);
            btnEDelete.Name = "btnEDelete";
            btnEDelete.Size = new Size(94, 41);
            btnEDelete.TabIndex = 17;
            btnEDelete.Text = "Delete";
            btnEDelete.UseVisualStyleBackColor = false;
            btnEDelete.Click += btnEDelete_Click;
            // 
            // btnEUpdate
            // 
            btnEUpdate.BackColor = Color.SkyBlue;
            btnEUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEUpdate.Location = new Point(6, 376);
            btnEUpdate.Name = "btnEUpdate";
            btnEUpdate.Size = new Size(94, 41);
            btnEUpdate.TabIndex = 16;
            btnEUpdate.Text = "Update";
            btnEUpdate.UseVisualStyleBackColor = false;
            btnEUpdate.Click += btnEUpdate_Click;
            // 
            // btnEInsert
            // 
            btnEInsert.BackColor = Color.LightGreen;
            btnEInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEInsert.Location = new Point(6, 302);
            btnEInsert.Name = "btnEInsert";
            btnEInsert.Size = new Size(94, 41);
            btnEInsert.TabIndex = 15;
            btnEInsert.Text = "Insert";
            btnEInsert.UseVisualStyleBackColor = false;
            btnEInsert.Click += btnEInsert_Click;
            // 
            // btnECancel
            // 
            btnECancel.BackColor = Color.Gold;
            btnECancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnECancel.Location = new Point(6, 515);
            btnECancel.Name = "btnECancel";
            btnECancel.Size = new Size(94, 41);
            btnECancel.TabIndex = 14;
            btnECancel.Text = "Cancel";
            btnECancel.UseVisualStyleBackColor = false;
            btnECancel.Click += btnECancel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(434, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 28);
            textBox1.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(848, 115);
            label17.Name = "label17";
            label17.Size = new Size(94, 20);
            label17.TabIndex = 12;
            label17.Text = "Day Of Week";
            // 
            // cbxDay
            // 
            cbxDay.FormattingEnabled = true;
            cbxDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cbxDay.Location = new Point(848, 151);
            cbxDay.Name = "cbxDay";
            cbxDay.Size = new Size(294, 28);
            cbxDay.TabIndex = 11;
            // 
            // dgvSchedule
            // 
            dgvSchedule.BackgroundColor = SystemColors.InactiveBorder;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { ScheduleID, CourseN, ClassroomN, StartTime, EndTime, Instructor, DayOfWeek });
            dgvSchedule.Location = new Point(113, 260);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new Size(1084, 333);
            dgvSchedule.TabIndex = 10;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            // 
            // ScheduleID
            // 
            ScheduleID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ScheduleID.DataPropertyName = "ScheduleID";
            ScheduleID.HeaderText = "Schedule ID ";
            ScheduleID.MinimumWidth = 6;
            ScheduleID.Name = "ScheduleID";
            // 
            // CourseN
            // 
            CourseN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseN.DataPropertyName = "CourseID";
            CourseN.HeaderText = "Course ID";
            CourseN.MinimumWidth = 6;
            CourseN.Name = "CourseN";
            // 
            // ClassroomN
            // 
            ClassroomN.DataPropertyName = "ClassroomName";
            ClassroomN.HeaderText = "Classroom Name";
            ClassroomN.MinimumWidth = 6;
            ClassroomN.Name = "ClassroomN";
            ClassroomN.Width = 125;
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
            EndTime.HeaderText = "End Time ";
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
            // tbxInstructor
            // 
            tbxInstructor.Location = new Point(848, 62);
            tbxInstructor.Name = "tbxInstructor";
            tbxInstructor.Size = new Size(294, 28);
            tbxInstructor.TabIndex = 9;
            // 
            // tbxETime
            // 
            tbxETime.Location = new Point(632, 151);
            tbxETime.Name = "tbxETime";
            tbxETime.Size = new Size(114, 28);
            tbxETime.TabIndex = 8;
            // 
            // tbxSTime
            // 
            tbxSTime.Location = new Point(452, 151);
            tbxSTime.Name = "tbxSTime";
            tbxSTime.Size = new Size(114, 28);
            tbxSTime.TabIndex = 7;
            // 
            // tbxERoom
            // 
            tbxERoom.Location = new Point(452, 62);
            tbxERoom.Name = "tbxERoom";
            tbxERoom.Size = new Size(294, 28);
            tbxERoom.TabIndex = 6;
            // 
            // tbxECID
            // 
            tbxECID.Location = new Point(78, 138);
            tbxECID.Name = "tbxECID";
            tbxECID.Size = new Size(294, 28);
            tbxECID.TabIndex = 5;
            tbxECID.TextChanged += tbxECID_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(452, 29);
            label16.Name = "label16";
            label16.Size = new Size(49, 20);
            label16.TabIndex = 4;
            label16.Text = "Room";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(452, 115);
            label15.Name = "label15";
            label15.Size = new Size(80, 20);
            label15.TabIndex = 3;
            label15.Text = "Start Time ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(632, 115);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 2;
            label14.Text = "End Time ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(848, 29);
            label13.Name = "label13";
            label13.Size = new Size(71, 20);
            label13.TabIndex = 1;
            label13.Text = "Instructor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(78, 115);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 0;
            label9.Text = "Course ID";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumOrchid;
            btnLogout.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(1127, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(76, 40);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 664);
            Controls.Add(btnLogout);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            tabControl1.ResumeLayout(false);
            StudentTab.ResumeLayout(false);
            StudentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentTab).EndInit();
            CoursesTab.ResumeLayout(false);
            CoursesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ClassroomTab.ResumeLayout(false);
            ClassroomTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassroom).EndInit();
            ScheduleTab.ResumeLayout(false);
            ScheduleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage StudentTab;
        private TabPage CoursesTab;
        private TabPage ClassroomTab;
        private TabPage ScheduleTab;
        private DataGridView dgvStudentTab;
        private Label tbxEmail;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox textBox3;
        private TextBox tbxSName;
        private TextBox tbxSID;
        private Label label4;
        private ComboBox cbxMajor;
        private Button btnLogout;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Major;
        private TextBox tbxSearch;
        private Button btnSearch;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox tbxCSearch;
        private DataGridView dgvCourse;
        private ComboBox cbxDep;
        private TextBox tbxCredit;
        private TextBox tbxCName;
        private TextBox tbxCID;
        private Label label7;
        private Button btnCInsert;
        private Button btnCUpdate;
        private Button btnCDelete;
        private Button btnCSearch;
        private Button btnCCancel;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Credits;
        private DataGridViewTextBoxColumn DepartmentID;
        private Label label11;
        private Label label10;
        private Button btnRSearch;
        private Button btnRDelete;
        private Button btnRUpdate;
        private Button btnRInsert;
        private Button btnRCancel;
        private TextBox tbxRSearch;
        private TextBox tbxCap;
        private TextBox tbxRName;
        private DataGridView dgvClassroom;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label9;
        private DataGridView dgvSchedule;
        private TextBox tbxInstructor;
        private TextBox tbxETime;
        private TextBox tbxSTime;
        private TextBox tbxERoom;
        private TextBox tbxECID;
        private Label label17;
        private ComboBox cbxDay;
        private Button btnEDelete;
        private Button btnEUpdate;
        private Button btnEInsert;
        private Button btnECancel;
        private TextBox textBox1;
        private Button btnESearch;
        private TextBox tbxEID;
        private Label label18;
        private DataGridViewTextBoxColumn ClassroomName;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn ScheduleID;
        private DataGridViewTextBoxColumn CourseN;
        private DataGridViewTextBoxColumn ClassroomN;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn DayOfWeek;
    }
}