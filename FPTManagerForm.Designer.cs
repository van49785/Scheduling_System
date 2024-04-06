namespace ASM2_DDD
{
    partial class FPTManagerForm
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
            UserTab = new TabControl();
            tabPage1 = new TabPage();
            tbxPass = new TextBox();
            label13 = new Label();
            btnSearch = new Button();
            tbxSearch = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnCancel = new Button();
            cbxRole = new ComboBox();
            dgvUser = new DataGridView();
            userID = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbxUID = new TextBox();
            tbxEmail = new TextBox();
            tbxUName = new TextBox();
            DepartmentTab = new TabPage();
            btnDSearch = new Button();
            tbxDSearch = new TextBox();
            btnDDelete = new Button();
            btnDUpdate = new Button();
            btnDInsert = new Button();
            btnDCancel = new Button();
            dgvDepartment = new DataGridView();
            DepartmentID = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            tbxDepID = new TextBox();
            tbxDepN = new TextBox();
            CourseTab = new TabPage();
            btnCInsert = new Button();
            btnCUpdate = new Button();
            btnCDelete = new Button();
            btnCSearch = new Button();
            btnCCancel = new Button();
            tbxCSearch = new TextBox();
            dgvCourse = new DataGridView();
            cbxDep = new ComboBox();
            tbxCredit = new TextBox();
            tbxCName = new TextBox();
            tbxCID = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnLogout = new Button();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Credits = new DataGridViewTextBoxColumn();
            depID = new DataGridViewTextBoxColumn();
            UserTab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            DepartmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            CourseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // UserTab
            // 
            UserTab.Controls.Add(tabPage1);
            UserTab.Controls.Add(DepartmentTab);
            UserTab.Controls.Add(CourseTab);
            UserTab.Location = new Point(2, 33);
            UserTab.Name = "UserTab";
            UserTab.SelectedIndex = 0;
            UserTab.Size = new Size(1166, 617);
            UserTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Lavender;
            tabPage1.Controls.Add(tbxPass);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(tbxSearch);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnInsert);
            tabPage1.Controls.Add(btnCancel);
            tabPage1.Controls.Add(cbxRole);
            tabPage1.Controls.Add(dgvUser);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbxUID);
            tabPage1.Controls.Add(tbxEmail);
            tabPage1.Controls.Add(tbxUName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1158, 584);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User";
            tabPage1.Click += tabPage1_Click;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(6, 306);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(289, 27);
            tbxPass.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 283);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 29;
            label13.Text = "Password";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(818, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(605, 33);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(207, 27);
            tbxSearch.TabIndex = 27;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(943, 514);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 42);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSkyBlue;
            btnUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(729, 514);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 42);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(498, 514);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 42);
            btnInsert.TabIndex = 24;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gold;
            btnCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(92, 432);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 44);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbxRole
            // 
            cbxRole.FormattingEnabled = true;
            cbxRole.Items.AddRange(new object[] { "Student", "Instructor", "Administrator", "FPT Manager", "Department Head" });
            cbxRole.Location = new Point(6, 379);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(289, 28);
            cbxRole.TabIndex = 22;
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = SystemColors.InactiveBorder;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { userID, userName, email, password, role });
            dgvUser.Location = new Point(365, 66);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(788, 429);
            dgvUser.TabIndex = 21;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // userID
            // 
            userID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userID.DataPropertyName = "user_id";
            userID.HeaderText = "User ID";
            userID.MinimumWidth = 6;
            userID.Name = "userID";
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userName.DataPropertyName = "userName";
            userName.HeaderText = "User Name ";
            userName.MinimumWidth = 6;
            userName.Name = "userName";
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // password
            // 
            password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.DataPropertyName = "role";
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 356);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 20;
            label4.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 200);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 18;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 17;
            label1.Text = "User ID";
            // 
            // tbxUID
            // 
            tbxUID.Location = new Point(6, 66);
            tbxUID.Name = "tbxUID";
            tbxUID.Size = new Size(289, 27);
            tbxUID.TabIndex = 16;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(6, 223);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(289, 27);
            tbxEmail.TabIndex = 15;
            // 
            // tbxUName
            // 
            tbxUName.Location = new Point(6, 141);
            tbxUName.Name = "tbxUName";
            tbxUName.Size = new Size(289, 27);
            tbxUName.TabIndex = 14;
            // 
            // DepartmentTab
            // 
            DepartmentTab.BackColor = Color.Lavender;
            DepartmentTab.Controls.Add(btnDSearch);
            DepartmentTab.Controls.Add(tbxDSearch);
            DepartmentTab.Controls.Add(btnDDelete);
            DepartmentTab.Controls.Add(btnDUpdate);
            DepartmentTab.Controls.Add(btnDInsert);
            DepartmentTab.Controls.Add(btnDCancel);
            DepartmentTab.Controls.Add(dgvDepartment);
            DepartmentTab.Controls.Add(label7);
            DepartmentTab.Controls.Add(label8);
            DepartmentTab.Controls.Add(tbxDepID);
            DepartmentTab.Controls.Add(tbxDepN);
            DepartmentTab.Location = new Point(4, 29);
            DepartmentTab.Name = "DepartmentTab";
            DepartmentTab.Padding = new Padding(3);
            DepartmentTab.Size = new Size(1158, 584);
            DepartmentTab.TabIndex = 1;
            DepartmentTab.Text = "Department";
            DepartmentTab.Click += DepartmentTab_Click;
            // 
            // btnDSearch
            // 
            btnDSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnDSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDSearch.Location = new Point(829, 25);
            btnDSearch.Name = "btnDSearch";
            btnDSearch.Size = new Size(94, 29);
            btnDSearch.TabIndex = 41;
            btnDSearch.Text = "Search";
            btnDSearch.UseVisualStyleBackColor = false;
            btnDSearch.Click += btnDSearch_Click;
            // 
            // tbxDSearch
            // 
            tbxDSearch.Location = new Point(627, 27);
            tbxDSearch.Name = "tbxDSearch";
            tbxDSearch.Size = new Size(196, 27);
            tbxDSearch.TabIndex = 40;
            // 
            // btnDDelete
            // 
            btnDDelete.BackColor = Color.Tomato;
            btnDDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDDelete.Location = new Point(943, 495);
            btnDDelete.Name = "btnDDelete";
            btnDDelete.Size = new Size(94, 42);
            btnDDelete.TabIndex = 39;
            btnDDelete.Text = "Delete";
            btnDDelete.UseVisualStyleBackColor = false;
            btnDDelete.Click += btnDDelete_Click;
            // 
            // btnDUpdate
            // 
            btnDUpdate.BackColor = Color.SkyBlue;
            btnDUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDUpdate.Location = new Point(729, 495);
            btnDUpdate.Name = "btnDUpdate";
            btnDUpdate.Size = new Size(94, 42);
            btnDUpdate.TabIndex = 38;
            btnDUpdate.Text = "Update";
            btnDUpdate.UseVisualStyleBackColor = false;
            btnDUpdate.Click += btnDUpdate_Click;
            // 
            // btnDInsert
            // 
            btnDInsert.BackColor = Color.LightGreen;
            btnDInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDInsert.Location = new Point(498, 495);
            btnDInsert.Name = "btnDInsert";
            btnDInsert.Size = new Size(94, 42);
            btnDInsert.TabIndex = 37;
            btnDInsert.Text = "Insert";
            btnDInsert.UseVisualStyleBackColor = false;
            btnDInsert.Click += btnDInsert_Click;
            // 
            // btnDCancel
            // 
            btnDCancel.BackColor = Color.Yellow;
            btnDCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDCancel.Location = new Point(96, 316);
            btnDCancel.Name = "btnDCancel";
            btnDCancel.Size = new Size(94, 44);
            btnDCancel.TabIndex = 36;
            btnDCancel.Text = "Cancel";
            btnDCancel.UseVisualStyleBackColor = false;
            btnDCancel.Click += btnDCancel_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.BackgroundColor = SystemColors.InactiveBorder;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Columns.AddRange(new DataGridViewColumn[] { DepartmentID, DepartmentName });
            dgvDepartment.Location = new Point(365, 60);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.RowTemplate.Height = 29;
            dgvDepartment.Size = new Size(788, 416);
            dgvDepartment.TabIndex = 34;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            // 
            // DepartmentID
            // 
            DepartmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepartmentID.DataPropertyName = "DepartmentID";
            DepartmentID.HeaderText = "Department ID";
            DepartmentID.MinimumWidth = 6;
            DepartmentID.Name = "DepartmentID";
            // 
            // DepartmentName
            // 
            DepartmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepartmentName.DataPropertyName = "DepartmentName";
            DepartmentName.HeaderText = "Department Name";
            DepartmentName.MinimumWidth = 6;
            DepartmentName.Name = "DepartmentName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 238);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 31;
            label7.Text = "Department Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 147);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 30;
            label8.Text = "Department ID";
            // 
            // tbxDepID
            // 
            tbxDepID.Location = new Point(6, 170);
            tbxDepID.Name = "tbxDepID";
            tbxDepID.Size = new Size(289, 27);
            tbxDepID.TabIndex = 29;
            // 
            // tbxDepN
            // 
            tbxDepN.Location = new Point(6, 261);
            tbxDepN.Name = "tbxDepN";
            tbxDepN.Size = new Size(289, 27);
            tbxDepN.TabIndex = 27;
            // 
            // CourseTab
            // 
            CourseTab.BackColor = Color.Lavender;
            CourseTab.Controls.Add(btnCInsert);
            CourseTab.Controls.Add(btnCUpdate);
            CourseTab.Controls.Add(btnCDelete);
            CourseTab.Controls.Add(btnCSearch);
            CourseTab.Controls.Add(btnCCancel);
            CourseTab.Controls.Add(tbxCSearch);
            CourseTab.Controls.Add(dgvCourse);
            CourseTab.Controls.Add(cbxDep);
            CourseTab.Controls.Add(tbxCredit);
            CourseTab.Controls.Add(tbxCName);
            CourseTab.Controls.Add(tbxCID);
            CourseTab.Controls.Add(label5);
            CourseTab.Controls.Add(label6);
            CourseTab.Controls.Add(label9);
            CourseTab.Controls.Add(label10);
            CourseTab.Location = new Point(4, 29);
            CourseTab.Name = "CourseTab";
            CourseTab.Padding = new Padding(3);
            CourseTab.Size = new Size(1158, 584);
            CourseTab.TabIndex = 2;
            CourseTab.Text = "Course";
            CourseTab.Click += CourseTab_Click;
            // 
            // btnCInsert
            // 
            btnCInsert.BackColor = Color.Chartreuse;
            btnCInsert.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCInsert.Location = new Point(550, 520);
            btnCInsert.Name = "btnCInsert";
            btnCInsert.Size = new Size(94, 39);
            btnCInsert.TabIndex = 29;
            btnCInsert.Text = "Insert";
            btnCInsert.UseVisualStyleBackColor = false;
            btnCInsert.Click += btnCInsert_Click;
            // 
            // btnCUpdate
            // 
            btnCUpdate.BackColor = Color.SkyBlue;
            btnCUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCUpdate.Location = new Point(731, 520);
            btnCUpdate.Name = "btnCUpdate";
            btnCUpdate.Size = new Size(94, 39);
            btnCUpdate.TabIndex = 28;
            btnCUpdate.Text = "Update";
            btnCUpdate.UseVisualStyleBackColor = false;
            btnCUpdate.Click += btnCUpdate_Click;
            // 
            // btnCDelete
            // 
            btnCDelete.BackColor = Color.Tomato;
            btnCDelete.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCDelete.Location = new Point(898, 520);
            btnCDelete.Name = "btnCDelete";
            btnCDelete.Size = new Size(94, 39);
            btnCDelete.TabIndex = 27;
            btnCDelete.Text = "Delete";
            btnCDelete.UseVisualStyleBackColor = false;
            btnCDelete.Click += btnCDelete_Click;
            // 
            // btnCSearch
            // 
            btnCSearch.BackColor = Color.FromArgb(255, 192, 192);
            btnCSearch.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCSearch.Location = new Point(884, 26);
            btnCSearch.Name = "btnCSearch";
            btnCSearch.Size = new Size(94, 29);
            btnCSearch.TabIndex = 26;
            btnCSearch.Text = "Search";
            btnCSearch.UseVisualStyleBackColor = false;
            btnCSearch.Click += btnCSearch_Click;
            // 
            // btnCCancel
            // 
            btnCCancel.BackColor = Color.Yellow;
            btnCCancel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCCancel.Location = new Point(113, 439);
            btnCCancel.Name = "btnCCancel";
            btnCCancel.Size = new Size(94, 39);
            btnCCancel.TabIndex = 25;
            btnCCancel.Text = "Cancel";
            btnCCancel.UseVisualStyleBackColor = false;
            btnCCancel.Click += btnCCancel_Click;
            // 
            // tbxCSearch
            // 
            tbxCSearch.Location = new Point(644, 26);
            tbxCSearch.Name = "tbxCSearch";
            tbxCSearch.Size = new Size(234, 27);
            tbxCSearch.TabIndex = 24;
            // 
            // dgvCourse
            // 
            dgvCourse.BackgroundColor = SystemColors.InactiveBorder;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Credits, depID });
            dgvCourse.Location = new Point(328, 59);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.RowTemplate.Height = 29;
            dgvCourse.Size = new Size(825, 423);
            dgvCourse.TabIndex = 23;
            dgvCourse.CellClick += dgvCourse_CellClick;
            // 
            // cbxDep
            // 
            cbxDep.FormattingEnabled = true;
            cbxDep.Items.AddRange(new object[] { "Computing ", "Graphic Design", "Business" });
            cbxDep.Location = new Point(18, 382);
            cbxDep.Name = "cbxDep";
            cbxDep.Size = new Size(269, 28);
            cbxDep.TabIndex = 22;
            // 
            // tbxCredit
            // 
            tbxCredit.Location = new Point(18, 287);
            tbxCredit.Name = "tbxCredit";
            tbxCredit.Size = new Size(269, 27);
            tbxCredit.TabIndex = 21;
            // 
            // tbxCName
            // 
            tbxCName.Location = new Point(18, 199);
            tbxCName.Name = "tbxCName";
            tbxCName.Size = new Size(269, 27);
            tbxCName.TabIndex = 20;
            // 
            // tbxCID
            // 
            tbxCID.Location = new Point(18, 105);
            tbxCID.Name = "tbxCID";
            tbxCID.Size = new Size(269, 27);
            tbxCID.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 348);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 18;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 250);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 17;
            label6.Text = "Credits";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 167);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 16;
            label9.Text = "Course Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 71);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 15;
            label10.Text = "Course ID";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkOrchid;
            btnLogout.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(1065, 8);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 48);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
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
            // depID
            // 
            depID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            depID.DataPropertyName = "DepartmentID";
            depID.HeaderText = "Department ID";
            depID.MinimumWidth = 6;
            depID.Name = "depID";
            // 
            // FPTManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 651);
            Controls.Add(btnLogout);
            Controls.Add(UserTab);
            Name = "FPTManagerForm";
            Text = "FPTManagerForm";
            Load += FPTManagerForm_Load;
            UserTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            DepartmentTab.ResumeLayout(false);
            DepartmentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            CourseTab.ResumeLayout(false);
            CourseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl UserTab;
        private TabPage tabPage1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnCancel;
        private ComboBox cbxRole;
        private DataGridView dgvUser;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxUID;
        private TextBox tbxEmail;
        private TextBox tbxUName;
        private TabPage DepartmentTab;
        private Button btnDDelete;
        private Button btnDUpdate;
        private Button btnDInsert;
        private Button btnDCancel;
        private ComboBox comboBox2;
        private DataGridView dgvDepartment;
        private Label label7;
        private Label label8;
        private TextBox tbxDepID;
        private TextBox textBox5;
        private TextBox tbxDepN;
        private TabPage CourseTab;
        private Button btnSearch;
        private TextBox tbxSearch;
        private Button btnLogout;
        private TextBox tbxPass;
        private Label label13;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
        private Button btnDSearch;
        private TextBox tbxDSearch;
        private DataGridViewTextBoxColumn DepartmentID;
        private DataGridViewTextBoxColumn DepartmentName;
        private Button btnCInsert;
        private Button btnCUpdate;
        private Button btnCDelete;
        private Button btnCSearch;
        private Button btnCCancel;
        private TextBox tbxCSearch;
        private DataGridView dgvCourse;
        private ComboBox cbxDep;
        private TextBox tbxCredit;
        private TextBox tbxCName;
        private TextBox tbxCID;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Credits;
        private DataGridViewTextBoxColumn depID;
    }
}