using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StudentManager
{
    public partial class FrmObjectSave : Form
    {
        public FrmObjectSave()
        {
            InitializeComponent();
        }
        // 封装数据
        private void btnSaveObject_Click_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = this.txName.Text.Trim(),
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Gender = this.txGender.Text.Trim(),
                BirthDay = Convert.ToDateTime(this.txBirthday.Text.Trim())
            };
            System.Console.WriteLine(student);
            // 保存到文件里
            FileStream fs = new FileStream("..\\objStudent.obj", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            // 一行一行写入
            sw.WriteLine(student.Name);
            sw.WriteLine(student.Age);
            sw.WriteLine(student.Gender);
            sw.WriteLine(student.BirthDay);
            // 关闭输入流、文件流
            sw.Close();
            fs.Close();
        }
        // 读取数据
        private void btnLoadObject_Click_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("..\\objStudent.obj", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            // 一行一行读取
            Student student = new Student()
            {
                Name = sr.ReadLine(),
                Age = Convert.ToInt32(sr.ReadLine()),
                Gender = sr.ReadLine(),
                BirthDay = Convert.ToDateTime(sr.ReadLine())
            };
            sr.Close();
            fs.Close();
            // 显示数据
            this.txName.Text = student.Name;
            this.txtAge.Text = student.Age.ToString();
            this.txGender.Text = student.Gender;
            this.txBirthday.Text = student.BirthDay.ToShortDateString();
        }
        // 序列化对象状态
        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = this.txName.Text.Trim(),
                Age = Convert.ToInt32(this.txtAge.Text.Trim()),
                Gender = this.txGender.Text.Trim(),
                BirthDay = Convert.ToDateTime(this.txBirthday.Text.Trim())
            };
            // [1]创建文件流
            FileStream fs = new FileStream("..\\objStudent.stu", FileMode.Create);
            // [2]创建二进制格式化流
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            StreamWriter sr = new StreamWriter(fs);
            // [3]调用序列化 方法
            serializer.Serialize(sr, student);
            // [4]关闭文件流
            fs.Close();
        }
        // 反序列化对象
        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            // [1]创建文件流
            FileStream fs = new FileStream("..\\objStudent.stu", FileMode.Open);
            // [2]创建二进制格式化器
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            // [3] 调用反序列化方法
            Student objStudent = (Student)serializer.Deserialize(fs);
            Console.WriteLine(objStudent);
            // [4]关闭文件流
            fs.Close();
            // 显示数据
            this.txName.Text = objStudent.Name;
            this.txtAge.Text = objStudent.Age.ToString();
            this.txGender.Text = objStudent.Gender;
            this.txBirthday.Text = objStudent.BirthDay.ToShortDateString();
        }
    }
}
