namespace StudentManager
{
    partial class FrmObjectSave
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
            txName = new TextBox();
            label2 = new Label();
            txtAge = new TextBox();
            groupBox1 = new GroupBox();
            btnLoadObject_Click = new Button();
            btnSaveObject_Click = new Button();
            label3 = new Label();
            txGender = new TextBox();
            label4 = new Label();
            txBirthday = new TextBox();
            groupBox2 = new GroupBox();
            btnDeserialize = new Button();
            btnSerialize = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "姓名:";
            // 
            // txName
            // 
            txName.BorderStyle = BorderStyle.FixedSingle;
            txName.Location = new Point(86, 22);
            txName.Name = "txName";
            txName.Size = new Size(142, 23);
            txName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 24);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 0;
            label2.Text = "年龄:";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(313, 22);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(144, 23);
            txtAge.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoadObject_Click);
            groupBox1.Controls.Add(btnSaveObject_Click);
            groupBox1.Location = new Point(45, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "使用文本保存对象状态";
            // 
            // btnLoadObject_Click
            // 
            btnLoadObject_Click.Location = new Point(227, 46);
            btnLoadObject_Click.Name = "btnLoadObject_Click";
            btnLoadObject_Click.Size = new Size(138, 23);
            btnLoadObject_Click.TabIndex = 0;
            btnLoadObject_Click.Text = "从文本文件读取";
            btnLoadObject_Click.UseVisualStyleBackColor = true;
            btnLoadObject_Click.Click += btnLoadObject_Click_Click;
            // 
            // btnSaveObject_Click
            // 
            btnSaveObject_Click.Location = new Point(41, 46);
            btnSaveObject_Click.Name = "btnSaveObject_Click";
            btnSaveObject_Click.Size = new Size(142, 23);
            btnSaveObject_Click.TabIndex = 0;
            btnSaveObject_Click.Text = "保存到文本文件";
            btnSaveObject_Click.UseVisualStyleBackColor = true;
            btnSaveObject_Click.Click += btnSaveObject_Click_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 65);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 0;
            label3.Text = "性别:";
            // 
            // txGender
            // 
            txGender.BorderStyle = BorderStyle.FixedSingle;
            txGender.Location = new Point(86, 63);
            txGender.Name = "txGender";
            txGender.Size = new Size(142, 23);
            txGender.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 65);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 0;
            label4.Text = "出生日期:";
            // 
            // txBirthday
            // 
            txBirthday.BorderStyle = BorderStyle.FixedSingle;
            txBirthday.Location = new Point(313, 63);
            txBirthday.Name = "txBirthday";
            txBirthday.Size = new Size(144, 23);
            txBirthday.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDeserialize);
            groupBox2.Controls.Add(btnSerialize);
            groupBox2.Location = new Point(45, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "使用序列化方法保存对象状态";
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(227, 46);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(138, 23);
            btnDeserialize.TabIndex = 0;
            btnDeserialize.Text = "还原对象";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // btnSerialize
            // 
            btnSerialize.Location = new Point(41, 46);
            btnSerialize.Name = "btnSerialize";
            btnSerialize.Size = new Size(142, 23);
            btnSerialize.TabIndex = 0;
            btnSerialize.Text = "保存对象";
            btnSerialize.UseVisualStyleBackColor = true;
            btnSerialize.Click += btnSerialize_Click;
            // 
            // FrmObjectSave
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 341);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txBirthday);
            Controls.Add(label4);
            Controls.Add(txGender);
            Controls.Add(label3);
            Controls.Add(txName);
            Controls.Add(label1);
            Name = "FrmObjectSave";
            Text = "FrmObjectSave";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txName;
        private Label label2;
        private TextBox txtAge;
        private GroupBox groupBox1;
        private Button btnLoadObject_Click;
        private Button btnSaveObject_Click;
        private Label label3;
        private TextBox txGender;
        private Label label4;
        private TextBox txBirthday;
        private GroupBox groupBox2;
        private Button btnDeserialize;
        private Button btnSerialize;
    }
}