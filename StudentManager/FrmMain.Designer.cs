namespace StudentManager
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            系统ToolStripMenuItem = new ToolStripMenuItem();
            tsmi_PwdModify = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            退出系统ToolStripMenuItem = new ToolStripMenuItem();
            学员管理ToolStripMenuItem = new ToolStripMenuItem();
            添加学员ToolStripMenuItem = new ToolStripMenuItem();
            批量导入学员ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            学员类别ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            spContainer = new SplitContainer();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnStuManage = new Button();
            button2 = new Button();
            btnAddStudent = new Button();
            monthCalendar1 = new MonthCalendar();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spContainer).BeginInit();
            spContainer.Panel1.SuspendLayout();
            spContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统ToolStripMenuItem, 学员管理ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            系统ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmi_PwdModify, toolStripSeparator1, 退出系统ToolStripMenuItem });
            系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            系统ToolStripMenuItem.Size = new Size(59, 21);
            系统ToolStripMenuItem.Text = "系统(S&)";
            // 
            // tsmi_PwdModify
            // 
            tsmi_PwdModify.Name = "tsmi_PwdModify";
            tsmi_PwdModify.Size = new Size(124, 22);
            tsmi_PwdModify.Text = "密码修改";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(121, 6);
            // 
            // 退出系统ToolStripMenuItem
            // 
            退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            退出系统ToolStripMenuItem.Size = new Size(124, 22);
            退出系统ToolStripMenuItem.Text = "退出系统";
            // 
            // 学员管理ToolStripMenuItem
            // 
            学员管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 添加学员ToolStripMenuItem, 批量导入学员ToolStripMenuItem, toolStripSeparator2, 学员类别ToolStripMenuItem });
            学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            学员管理ToolStripMenuItem.Size = new Size(88, 21);
            学员管理ToolStripMenuItem.Text = "学员管理(M&)";
            // 
            // 添加学员ToolStripMenuItem
            // 
            添加学员ToolStripMenuItem.Name = "添加学员ToolStripMenuItem";
            添加学员ToolStripMenuItem.Size = new Size(148, 22);
            添加学员ToolStripMenuItem.Text = "添加学员";
            // 
            // 批量导入学员ToolStripMenuItem
            // 
            批量导入学员ToolStripMenuItem.Name = "批量导入学员ToolStripMenuItem";
            批量导入学员ToolStripMenuItem.Size = new Size(148, 22);
            批量导入学员ToolStripMenuItem.Text = "批量导入学员";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(145, 6);
            // 
            // 学员类别ToolStripMenuItem
            // 
            学员类别ToolStripMenuItem.Name = "学员类别ToolStripMenuItem";
            学员类别ToolStripMenuItem.Size = new Size(148, 22);
            学员类别ToolStripMenuItem.Text = "学员信息管理";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 598);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1147, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(80, 17);
            toolStripStatusLabel1.Text = "版本号:v0.0.2";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(59, 17);
            toolStripStatusLabel2.Text = "当前用户:";
            // 
            // spContainer
            // 
            spContainer.BorderStyle = BorderStyle.Fixed3D;
            spContainer.Dock = DockStyle.Fill;
            spContainer.FixedPanel = FixedPanel.Panel1;
            spContainer.Location = new Point(0, 25);
            spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            spContainer.Panel1.Controls.Add(button8);
            spContainer.Panel1.Controls.Add(button7);
            spContainer.Panel1.Controls.Add(button6);
            spContainer.Panel1.Controls.Add(button5);
            spContainer.Panel1.Controls.Add(button4);
            spContainer.Panel1.Controls.Add(btnStuManage);
            spContainer.Panel1.Controls.Add(button2);
            spContainer.Panel1.Controls.Add(btnAddStudent);
            spContainer.Panel1.Controls.Add(monthCalendar1);
            spContainer.Size = new Size(1147, 573);
            spContainer.SplitterDistance = 224;
            spContainer.TabIndex = 2;
            // 
            // button8
            // 
            button8.Location = new Point(125, 352);
            button8.Name = "button8";
            button8.Size = new Size(92, 44);
            button8.TabIndex = 2;
            button8.Text = "退出系统";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(10, 352);
            button7.Name = "button7";
            button7.Size = new Size(80, 44);
            button7.TabIndex = 1;
            button7.Text = "密码修改";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(125, 291);
            button6.Name = "button6";
            button6.Size = new Size(92, 44);
            button6.TabIndex = 2;
            button6.Text = "成绩浏览";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(10, 291);
            button5.Name = "button5";
            button5.Size = new Size(80, 44);
            button5.TabIndex = 1;
            button5.Text = "成绩分析";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(125, 241);
            button4.Name = "button4";
            button4.Size = new Size(92, 44);
            button4.TabIndex = 2;
            button4.Text = "考勤打卡";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnStuManage
            // 
            btnStuManage.Location = new Point(10, 241);
            btnStuManage.Name = "btnStuManage";
            btnStuManage.Size = new Size(80, 44);
            btnStuManage.TabIndex = 1;
            btnStuManage.Text = "学员管理";
            btnStuManage.UseVisualStyleBackColor = true;
            btnStuManage.Click += btnStuManage_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 191);
            button2.Name = "button2";
            button2.Size = new Size(92, 44);
            button2.TabIndex = 2;
            button2.Text = "批量导入";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(10, 191);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(80, 44);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "添加学员";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(1, -2);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 620);
            Controls.Add(spContainer);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spContainer).EndInit();
            spContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private ToolStripMenuItem tsmi_PwdModify;
        private ToolStripMenuItem 退出系统ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 学员管理ToolStripMenuItem;
        private ToolStripMenuItem 添加学员ToolStripMenuItem;
        private ToolStripMenuItem 批量导入学员ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 学员类别ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private SplitContainer spContainer;
        private MonthCalendar monthCalendar1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnStuManage;
        private Button button2;
        private Button btnAddStudent;
        private ImageList imageList1;
        private Button button8;
        private Button button7;
    }
}
