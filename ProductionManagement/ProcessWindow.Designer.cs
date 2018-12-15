namespace ProductionManagement
{
    partial class ProcessWindow
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlForm = new System.Windows.Forms.TabControl();
            this.tabPageDepart = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatorUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.bChangeRoleInDepart = new System.Windows.Forms.Button();
            this.bDeleteDepart = new System.Windows.Forms.Button();
            this.bChangeDepart = new System.Windows.Forms.Button();
            this.bCreateDepart = new System.Windows.Forms.Button();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.IDUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoginUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bChangeSalary = new System.Windows.Forms.Button();
            this.bDeleteUser = new System.Windows.Forms.Button();
            this.bChangeUser = new System.Windows.Forms.Button();
            this.bAddUser = new System.Windows.Forms.Button();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.IDTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.bMoreInfo = new System.Windows.Forms.Button();
            this.bDeleteTask = new System.Windows.Forms.Button();
            this.bChangeTask = new System.Windows.Forms.Button();
            this.bCreateTask = new System.Windows.Forms.Button();
            this.tabPageNowTask = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.IDBusyTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameBusyTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusyTaskCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusyTaskDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.departamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bToTakeTask = new System.Windows.Forms.Button();
            this.cVisibleBusyTask = new System.Windows.Forms.CheckBox();
            this.BusyTaskCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalaryUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlForm.SuspendLayout();
            this.tabPageDepart.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageTask.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageNowTask.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 41);
            this.panel1.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bExit.Location = new System.Drawing.Point(0, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(584, 41);
            this.bExit.TabIndex = 0;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControlForm);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 370);
            this.panel2.TabIndex = 1;
            // 
            // tabControlForm
            // 
            this.tabControlForm.Controls.Add(this.tabPageDepart);
            this.tabControlForm.Controls.Add(this.tabPageUser);
            this.tabControlForm.Controls.Add(this.tabPageTask);
            this.tabControlForm.Controls.Add(this.tabPageNowTask);
            this.tabControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlForm.Location = new System.Drawing.Point(0, 0);
            this.tabControlForm.Name = "tabControlForm";
            this.tabControlForm.SelectedIndex = 0;
            this.tabControlForm.Size = new System.Drawing.Size(584, 370);
            this.tabControlForm.TabIndex = 0;
            // 
            // tabPageDepart
            // 
            this.tabPageDepart.Controls.Add(this.listView1);
            this.tabPageDepart.Controls.Add(this.panel4);
            this.tabPageDepart.Location = new System.Drawing.Point(4, 22);
            this.tabPageDepart.Name = "tabPageDepart";
            this.tabPageDepart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepart.Size = new System.Drawing.Size(576, 344);
            this.tabPageDepart.TabIndex = 0;
            this.tabPageDepart.Text = "Список отделов";
            this.tabPageDepart.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDDepart,
            this.NameDepart,
            this.NumberUser,
            this.CreatorUser});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 332);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDDepart
            // 
            this.IDDepart.Text = "№";
            this.IDDepart.Width = 24;
            // 
            // NameDepart
            // 
            this.NameDepart.Text = "Название";
            this.NameDepart.Width = 93;
            // 
            // NumberUser
            // 
            this.NumberUser.Text = "Кол. сотр-ов";
            this.NumberUser.Width = 75;
            // 
            // CreatorUser
            // 
            this.CreatorUser.Text = "Создатель отдела";
            this.CreatorUser.Width = 137;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.bChangeRoleInDepart);
            this.panel4.Controls.Add(this.bDeleteDepart);
            this.panel4.Controls.Add(this.bChangeDepart);
            this.panel4.Controls.Add(this.bCreateDepart);
            this.panel4.Location = new System.Drawing.Point(375, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 338);
            this.panel4.TabIndex = 1;
            // 
            // bChangeRoleInDepart
            // 
            this.bChangeRoleInDepart.Location = new System.Drawing.Point(7, 302);
            this.bChangeRoleInDepart.Name = "bChangeRoleInDepart";
            this.bChangeRoleInDepart.Size = new System.Drawing.Size(186, 33);
            this.bChangeRoleInDepart.TabIndex = 3;
            this.bChangeRoleInDepart.Text = "Изменить роли в отделе";
            this.bChangeRoleInDepart.UseVisualStyleBackColor = true;
            this.bChangeRoleInDepart.Click += new System.EventHandler(this.bChangeRoleInDepart_Click);
            // 
            // bDeleteDepart
            // 
            this.bDeleteDepart.Location = new System.Drawing.Point(7, 90);
            this.bDeleteDepart.Name = "bDeleteDepart";
            this.bDeleteDepart.Size = new System.Drawing.Size(186, 33);
            this.bDeleteDepart.TabIndex = 2;
            this.bDeleteDepart.Text = "Удалить отдел";
            this.bDeleteDepart.UseVisualStyleBackColor = true;
            this.bDeleteDepart.Click += new System.EventHandler(this.bDeleteDepart_Click);
            // 
            // bChangeDepart
            // 
            this.bChangeDepart.Location = new System.Drawing.Point(7, 51);
            this.bChangeDepart.Name = "bChangeDepart";
            this.bChangeDepart.Size = new System.Drawing.Size(186, 33);
            this.bChangeDepart.TabIndex = 1;
            this.bChangeDepart.Text = "Изменить отдел";
            this.bChangeDepart.UseVisualStyleBackColor = true;
            this.bChangeDepart.Click += new System.EventHandler(this.bChangeDepart_Click);
            // 
            // bCreateDepart
            // 
            this.bCreateDepart.Location = new System.Drawing.Point(7, 12);
            this.bCreateDepart.Name = "bCreateDepart";
            this.bCreateDepart.Size = new System.Drawing.Size(186, 33);
            this.bCreateDepart.TabIndex = 0;
            this.bCreateDepart.Text = "Создать отдел";
            this.bCreateDepart.UseVisualStyleBackColor = true;
            this.bCreateDepart.Click += new System.EventHandler(this.bCreateDepart_Click);
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.listView2);
            this.tabPageUser.Controls.Add(this.panel3);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(576, 344);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "Список сотрудников";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDUser,
            this.NameUser,
            this.LoginUser,
            this.SalaryUser});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(5, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(363, 332);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // IDUser
            // 
            this.IDUser.Text = "№";
            this.IDUser.Width = 28;
            // 
            // NameUser
            // 
            this.NameUser.Text = "Имя";
            this.NameUser.Width = 153;
            // 
            // LoginUser
            // 
            this.LoginUser.Text = "Логин";
            this.LoginUser.Width = 96;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.bChangeSalary);
            this.panel3.Controls.Add(this.bDeleteUser);
            this.panel3.Controls.Add(this.bChangeUser);
            this.panel3.Controls.Add(this.bAddUser);
            this.panel3.Location = new System.Drawing.Point(374, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 338);
            this.panel3.TabIndex = 3;
            // 
            // bChangeSalary
            // 
            this.bChangeSalary.Location = new System.Drawing.Point(7, 302);
            this.bChangeSalary.Name = "bChangeSalary";
            this.bChangeSalary.Size = new System.Drawing.Size(186, 33);
            this.bChangeSalary.TabIndex = 3;
            this.bChangeSalary.Text = "Изменить зарплату сотруднику";
            this.bChangeSalary.UseVisualStyleBackColor = true;
            this.bChangeSalary.Click += new System.EventHandler(this.bChangeSalary_Click);
            // 
            // bDeleteUser
            // 
            this.bDeleteUser.Location = new System.Drawing.Point(7, 90);
            this.bDeleteUser.Name = "bDeleteUser";
            this.bDeleteUser.Size = new System.Drawing.Size(186, 33);
            this.bDeleteUser.TabIndex = 2;
            this.bDeleteUser.Text = "Удалить сотрудника";
            this.bDeleteUser.UseVisualStyleBackColor = true;
            this.bDeleteUser.Click += new System.EventHandler(this.bDeleteUser_Click);
            // 
            // bChangeUser
            // 
            this.bChangeUser.Location = new System.Drawing.Point(7, 51);
            this.bChangeUser.Name = "bChangeUser";
            this.bChangeUser.Size = new System.Drawing.Size(186, 33);
            this.bChangeUser.TabIndex = 1;
            this.bChangeUser.Text = "Изменить инфо. сотрудника";
            this.bChangeUser.UseVisualStyleBackColor = true;
            this.bChangeUser.Click += new System.EventHandler(this.bChangeUser_Click);
            // 
            // bAddUser
            // 
            this.bAddUser.Location = new System.Drawing.Point(7, 12);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(186, 33);
            this.bAddUser.TabIndex = 0;
            this.bAddUser.Text = "Добавить сотрудника";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // tabPageTask
            // 
            this.tabPageTask.Controls.Add(this.listView3);
            this.tabPageTask.Controls.Add(this.panel5);
            this.tabPageTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Size = new System.Drawing.Size(576, 344);
            this.tabPageTask.TabIndex = 2;
            this.tabPageTask.Text = "Список задач";
            this.tabPageTask.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDTask,
            this.NameTask,
            this.TaskCost,
            this.TaskDeadline,
            this.NameCreator});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(5, 6);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(363, 332);
            this.listView3.TabIndex = 4;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // IDTask
            // 
            this.IDTask.Text = "№";
            this.IDTask.Width = 25;
            // 
            // NameTask
            // 
            this.NameTask.Text = "Название";
            this.NameTask.Width = 116;
            // 
            // TaskCost
            // 
            this.TaskCost.Text = "Стоимость";
            this.TaskCost.Width = 69;
            // 
            // TaskDeadline
            // 
            this.TaskDeadline.Text = "Срок";
            this.TaskDeadline.Width = 79;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.cVisibleBusyTask);
            this.panel5.Controls.Add(this.bToTakeTask);
            this.panel5.Controls.Add(this.bMoreInfo);
            this.panel5.Controls.Add(this.bDeleteTask);
            this.panel5.Controls.Add(this.bChangeTask);
            this.panel5.Controls.Add(this.bCreateTask);
            this.panel5.Location = new System.Drawing.Point(374, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(198, 338);
            this.panel5.TabIndex = 3;
            // 
            // bMoreInfo
            // 
            this.bMoreInfo.Location = new System.Drawing.Point(7, 263);
            this.bMoreInfo.Name = "bMoreInfo";
            this.bMoreInfo.Size = new System.Drawing.Size(186, 33);
            this.bMoreInfo.TabIndex = 3;
            this.bMoreInfo.Text = "Подробнее о задаче";
            this.bMoreInfo.UseVisualStyleBackColor = true;
            this.bMoreInfo.Click += new System.EventHandler(this.bMoreInfo_Click);
            // 
            // bDeleteTask
            // 
            this.bDeleteTask.Location = new System.Drawing.Point(7, 90);
            this.bDeleteTask.Name = "bDeleteTask";
            this.bDeleteTask.Size = new System.Drawing.Size(186, 33);
            this.bDeleteTask.TabIndex = 2;
            this.bDeleteTask.Text = "Удалить задачу";
            this.bDeleteTask.UseVisualStyleBackColor = true;
            this.bDeleteTask.Click += new System.EventHandler(this.bDeleteTask_Click);
            // 
            // bChangeTask
            // 
            this.bChangeTask.Location = new System.Drawing.Point(7, 51);
            this.bChangeTask.Name = "bChangeTask";
            this.bChangeTask.Size = new System.Drawing.Size(186, 33);
            this.bChangeTask.TabIndex = 1;
            this.bChangeTask.Text = "Изменить задачу";
            this.bChangeTask.UseVisualStyleBackColor = true;
            this.bChangeTask.Click += new System.EventHandler(this.bChangeTask_Click);
            // 
            // bCreateTask
            // 
            this.bCreateTask.Location = new System.Drawing.Point(7, 12);
            this.bCreateTask.Name = "bCreateTask";
            this.bCreateTask.Size = new System.Drawing.Size(186, 33);
            this.bCreateTask.TabIndex = 0;
            this.bCreateTask.Text = "Создать задачу";
            this.bCreateTask.UseVisualStyleBackColor = true;
            this.bCreateTask.Click += new System.EventHandler(this.bCreateTask_Click);
            // 
            // tabPageNowTask
            // 
            this.tabPageNowTask.Controls.Add(this.listView4);
            this.tabPageNowTask.Controls.Add(this.panel6);
            this.tabPageNowTask.Location = new System.Drawing.Point(4, 22);
            this.tabPageNowTask.Name = "tabPageNowTask";
            this.tabPageNowTask.Size = new System.Drawing.Size(576, 344);
            this.tabPageNowTask.TabIndex = 3;
            this.tabPageNowTask.Text = "Выполняемые задачи";
            this.tabPageNowTask.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDBusyTask,
            this.NameBusyTask,
            this.BusyTaskCost,
            this.BusyTaskDeadline,
            this.BusyTaskCreator});
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.Location = new System.Drawing.Point(5, 6);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(363, 332);
            this.listView4.TabIndex = 4;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // IDBusyTask
            // 
            this.IDBusyTask.Text = "№";
            this.IDBusyTask.Width = 27;
            // 
            // NameBusyTask
            // 
            this.NameBusyTask.Text = "Название";
            this.NameBusyTask.Width = 106;
            // 
            // BusyTaskCost
            // 
            this.BusyTaskCost.Text = "Стоимость";
            this.BusyTaskCost.Width = 68;
            // 
            // BusyTaskDeadline
            // 
            this.BusyTaskDeadline.Text = "Срок";
            this.BusyTaskDeadline.Width = 83;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.button9);
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button11);
            this.panel6.Controls.Add(this.button12);
            this.panel6.Location = new System.Drawing.Point(374, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(198, 338);
            this.panel6.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 129);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(186, 33);
            this.button9.TabIndex = 3;
            this.button9.Text = "Изменить роли в отделе";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(7, 90);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(186, 33);
            this.button10.TabIndex = 2;
            this.button10.Text = "Удалить отдел";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 51);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(186, 33);
            this.button11.TabIndex = 1;
            this.button11.Text = "Изменить отдел";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(7, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(186, 33);
            this.button12.TabIndex = 0;
            this.button12.Text = "Создать отдел";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // NameCreator
            // 
            this.NameCreator.Text = "Создатель";
            this.NameCreator.Width = 70;
            // 
            // bToTakeTask
            // 
            this.bToTakeTask.Location = new System.Drawing.Point(7, 302);
            this.bToTakeTask.Name = "bToTakeTask";
            this.bToTakeTask.Size = new System.Drawing.Size(186, 33);
            this.bToTakeTask.TabIndex = 4;
            this.bToTakeTask.Text = "Взять задачу";
            this.bToTakeTask.UseVisualStyleBackColor = true;
            this.bToTakeTask.Click += new System.EventHandler(this.bToTakeTask_Click);
            // 
            // cVisibleBusyTask
            // 
            this.cVisibleBusyTask.AutoSize = true;
            this.cVisibleBusyTask.Location = new System.Drawing.Point(26, 228);
            this.cVisibleBusyTask.Name = "cVisibleBusyTask";
            this.cVisibleBusyTask.Size = new System.Drawing.Size(161, 17);
            this.cVisibleBusyTask.TabIndex = 5;
            this.cVisibleBusyTask.Text = "Скрыть свободные задачи";
            this.cVisibleBusyTask.UseVisualStyleBackColor = true;
            this.cVisibleBusyTask.CheckedChanged += new System.EventHandler(this.cVisibleBusyTask_CheckedChanged);
            // 
            // BusyTaskCreator
            // 
            this.BusyTaskCreator.Text = "Создатель";
            this.BusyTaskCreator.Width = 75;
            // 
            // SalaryUser
            // 
            this.SalaryUser.Text = "Зарплата";
            this.SalaryUser.Width = 81;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Скрыть занятые задачи";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ProcessWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "ProcessWindow";
            this.Text = "ProcessWindow";
            this.Load += new System.EventHandler(this.ProcessWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControlForm.ResumeLayout(false);
            this.tabPageDepart.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPageTask.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageNowTask.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departamentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TabControl tabControlForm;
        private System.Windows.Forms.TabPage tabPageDepart;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.TabPage tabPageNowTask;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bCreateDepart;
        private System.Windows.Forms.BindingSource departamentBindingSource;
        private System.Windows.Forms.Button bChangeRoleInDepart;
        private System.Windows.Forms.Button bDeleteDepart;
        private System.Windows.Forms.Button bChangeDepart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDDepart;
        private System.Windows.Forms.ColumnHeader NameDepart;
        private System.Windows.Forms.ColumnHeader NumberUser;
        private System.Windows.Forms.ColumnHeader CreatorUser;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader IDUser;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.ColumnHeader LoginUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bChangeSalary;
        private System.Windows.Forms.Button bDeleteUser;
        private System.Windows.Forms.Button bChangeUser;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader IDTask;
        private System.Windows.Forms.ColumnHeader NameTask;
        private System.Windows.Forms.ColumnHeader TaskCost;
        private System.Windows.Forms.ColumnHeader TaskDeadline;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bMoreInfo;
        private System.Windows.Forms.Button bDeleteTask;
        private System.Windows.Forms.Button bChangeTask;
        private System.Windows.Forms.Button bCreateTask;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader IDBusyTask;
        private System.Windows.Forms.ColumnHeader NameBusyTask;
        private System.Windows.Forms.ColumnHeader BusyTaskCost;
        private System.Windows.Forms.ColumnHeader BusyTaskDeadline;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ColumnHeader NameCreator;
        private System.Windows.Forms.CheckBox cVisibleBusyTask;
        private System.Windows.Forms.Button bToTakeTask;
        private System.Windows.Forms.ColumnHeader SalaryUser;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ColumnHeader BusyTaskCreator;
    }
}