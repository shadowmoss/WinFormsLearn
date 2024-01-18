namespace StudentManager
{
    partial class FrmStudentManage
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            studentManageClose = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button10 = new Button();
            dataGridView1 = new DataGridView();
            StudentId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20F);
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 0;
            label1.Text = "学员信息管理";
            // 
            // studentManageClose
            // 
            studentManageClose.Location = new Point(699, 40);
            studentManageClose.Name = "studentManageClose";
            studentManageClose.Size = new Size(75, 23);
            studentManageClose.TabIndex = 1;
            studentManageClose.Text = "关闭窗口";
            studentManageClose.UseVisualStyleBackColor = true;
            studentManageClose.Click += studentManageClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(42, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "按照班级查询";
            // 
            // button4
            // 
            button4.Location = new Point(488, 46);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 10;
            button4.Text = "姓名降序";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(388, 46);
            button3.Name = "button3";
            button3.Size = new Size(94, 23);
            button3.TabIndex = 10;
            button3.Text = "姓名排序";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(290, 46);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 10;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(84, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 45);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 8;
            label5.Text = "所在班级:";
            // 
            // button5
            // 
            button5.Location = new Point(672, 78);
            button5.Name = "button5";
            button5.Size = new Size(102, 38);
            button5.TabIndex = 10;
            button5.Text = "修改学员";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(672, 122);
            button6.Name = "button6";
            button6.Size = new Size(102, 39);
            button6.TabIndex = 10;
            button6.Text = "删除学员";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(42, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "按学号查询";
            // 
            // button7
            // 
            button7.Location = new Point(488, 46);
            button7.Name = "button7";
            button7.Size = new Size(102, 23);
            button7.TabIndex = 10;
            button7.Text = "姓名降序";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(388, 46);
            button8.Name = "button8";
            button8.Size = new Size(94, 23);
            button8.TabIndex = 10;
            button8.Text = "姓名排序";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(290, 46);
            button9.Name = "button9";
            button9.Size = new Size(92, 23);
            button9.TabIndex = 10;
            button9.Text = "提交查询";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(84, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 45);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 8;
            label2.Text = "请输入学号:";
            // 
            // button10
            // 
            button10.Location = new Point(652, 219);
            button10.Name = "button10";
            button10.Size = new Size(122, 38);
            button10.TabIndex = 10;
            button10.Text = "打印当前学员信息";
            button10.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentId, Column1, Column2, Column3, Column4 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(43, 295);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(731, 266);
            dataGridView1.TabIndex = 11;
            // 
            // StudentId
            // 
            StudentId.HeaderText = "学号";
            StudentId.Name = "StudentId";
            StudentId.ReadOnly = true;
            StudentId.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "姓名";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "性别";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "出生日期";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "所在班级";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // FrmStudentManage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(studentManageClose);
            Controls.Add(label1);
            Name = "FrmStudentManage";
            Text = "学员信息管理";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button studentManageClose;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox2;
        private Label label5;
        private Button button5;
        private Button button6;
        private GroupBox groupBox2;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox1;
        private Label label2;
        private Button button10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}