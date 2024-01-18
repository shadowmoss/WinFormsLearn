namespace StudentManager
{
    partial class FrmFiles
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
            groupBox1 = new GroupBox();
            btnWriteLine_Click = new Button();
            btnReadAll_Click = new Button();
            btnWriteAll_Click = new Button();
            groupBox2 = new GroupBox();
            btnMove_Click = new Button();
            btnCopy_Click = new Button();
            btnDel_Click = new Button();
            label2 = new Label();
            txtTo = new TextBox();
            txtFrom = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            button8 = new Button();
            button10 = new Button();
            button9 = new Button();
            btnShowAllFiles_Click = new Button();
            txContent = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnWriteLine_Click);
            groupBox1.Controls.Add(btnReadAll_Click);
            groupBox1.Controls.Add(btnWriteAll_Click);
            groupBox1.Location = new Point(301, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "文本文件读写";
            // 
            // btnWriteLine_Click
            // 
            btnWriteLine_Click.Location = new Point(336, 31);
            btnWriteLine_Click.Name = "btnWriteLine_Click";
            btnWriteLine_Click.Size = new Size(134, 41);
            btnWriteLine_Click.TabIndex = 0;
            btnWriteLine_Click.Text = "模拟写入系统日志";
            btnWriteLine_Click.UseVisualStyleBackColor = true;
            btnWriteLine_Click.Click += btnWriteLine_Click_Click;
            // 
            // btnReadAll_Click
            // 
            btnReadAll_Click.Location = new Point(183, 31);
            btnReadAll_Click.Name = "btnReadAll_Click";
            btnReadAll_Click.Size = new Size(134, 41);
            btnReadAll_Click.TabIndex = 0;
            btnReadAll_Click.Text = "从文本文件中读取";
            btnReadAll_Click.UseVisualStyleBackColor = true;
            btnReadAll_Click.Click += btnReadAll_Click_Click;
            // 
            // btnWriteAll_Click
            // 
            btnWriteAll_Click.Location = new Point(24, 31);
            btnWriteAll_Click.Name = "btnWriteAll_Click";
            btnWriteAll_Click.Size = new Size(134, 41);
            btnWriteAll_Click.TabIndex = 0;
            btnWriteAll_Click.Text = "写入文本文件";
            btnWriteAll_Click.UseVisualStyleBackColor = true;
            btnWriteAll_Click.Click += btnWriteAll_Click_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMove_Click);
            groupBox2.Controls.Add(btnCopy_Click);
            groupBox2.Controls.Add(btnDel_Click);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTo);
            groupBox2.Controls.Add(txtFrom);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(301, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "文件操作";
            // 
            // btnMove_Click
            // 
            btnMove_Click.Location = new Point(336, 55);
            btnMove_Click.Name = "btnMove_Click";
            btnMove_Click.Size = new Size(75, 23);
            btnMove_Click.TabIndex = 3;
            btnMove_Click.Text = "移动文件";
            btnMove_Click.UseVisualStyleBackColor = true;
            // 
            // btnCopy_Click
            // 
            btnCopy_Click.Location = new Point(183, 55);
            btnCopy_Click.Name = "btnCopy_Click";
            btnCopy_Click.Size = new Size(75, 23);
            btnCopy_Click.TabIndex = 3;
            btnCopy_Click.Text = "复制文件";
            btnCopy_Click.UseVisualStyleBackColor = true;
            btnCopy_Click.Click += btnCopy_Click_Click;
            // 
            // btnDel_Click
            // 
            btnDel_Click.Location = new Point(24, 55);
            btnDel_Click.Name = "btnDel_Click";
            btnDel_Click.Size = new Size(75, 23);
            btnDel_Click.TabIndex = 3;
            btnDel_Click.Text = "删除文件";
            btnDel_Click.UseVisualStyleBackColor = true;
            btnDel_Click.Click += btnDel_Click_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 29);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 2;
            label2.Text = "目的文件路径:";
            // 
            // txtTo
            // 
            txtTo.BorderStyle = BorderStyle.FixedSingle;
            txtTo.Location = new Point(336, 27);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(138, 23);
            txtTo.TabIndex = 1;
            // 
            // txtFrom
            // 
            txtFrom.BorderStyle = BorderStyle.FixedSingle;
            txtFrom.Location = new Point(95, 26);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(138, 23);
            txtFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "源文件路径:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(btnShowAllFiles_Click);
            groupBox3.Location = new Point(301, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(487, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "文件目录操作";
            // 
            // button8
            // 
            button8.Location = new Point(247, 22);
            button8.Name = "button8";
            button8.Size = new Size(209, 23);
            button8.TabIndex = 0;
            button8.Text = "显示指定目录下的所有子目录";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnShowSubDirectory_Click;
            // 
            // button10
            // 
            button10.Location = new Point(247, 60);
            button10.Name = "button10";
            button10.Size = new Size(209, 23);
            button10.TabIndex = 0;
            button10.Text = "删除指定目录下的所有子目录和文件";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(24, 60);
            button9.Name = "button9";
            button9.Size = new Size(209, 23);
            button9.TabIndex = 0;
            button9.Text = "在指定目录下创建一个子目录";
            button9.UseVisualStyleBackColor = true;
            // 
            // btnShowAllFiles_Click
            // 
            btnShowAllFiles_Click.Location = new Point(24, 22);
            btnShowAllFiles_Click.Name = "btnShowAllFiles_Click";
            btnShowAllFiles_Click.Size = new Size(209, 23);
            btnShowAllFiles_Click.TabIndex = 0;
            btnShowAllFiles_Click.Text = "显示指定目录下的所有文件";
            btnShowAllFiles_Click.UseVisualStyleBackColor = true;
            btnShowAllFiles_Click.Click += btnShowAllFiles_Click_Click;
            // 
            // txContent
            // 
            txContent.Location = new Point(12, 26);
            txContent.Name = "txContent";
            txContent.Size = new Size(283, 360);
            txContent.TabIndex = 3;
            txContent.Text = "";
            // 
            // FrmFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(txContent);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmFiles";
            Text = "FrmFiles";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnWriteLine_Click;
        private Button btnReadAll_Click;
        private Button btnWriteAll_Click;
        private GroupBox groupBox2;
        private Button btnMove_Click;
        private Button btnCopy_Click;
        private Button btnDel_Click;
        private Label label2;
        private TextBox txtTo;
        private TextBox txtFrom;
        private Label label1;
        private GroupBox groupBox3;
        private Button button8;
        private Button button10;
        private Button button9;
        private Button btnShowAllFiles_Click;
        private RichTextBox txContent;
    }
}