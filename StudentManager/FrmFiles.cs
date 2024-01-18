using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//引入文件IO命名空间
using System.IO;
namespace StudentManager
{
    public partial class FrmFiles : Form
    {
        public FrmFiles()
        {
            InitializeComponent();
        }

        private void btnWriteAll_Click_Click(object sender, EventArgs e)
        {
            // [1] 创建文件流
            FileStream fs = new FileStream("..\\myfile.txt", FileMode.Create);
            // [2] 创建写入器
            StreamWriter sw = new StreamWriter(fs);
            // [3] 以流的方式写入数据
            sw.Write(this.txContent.Text.Trim());
            // [4] 关闭写入器
            sw.Close();
            // [5] 关闭文件流
            fs.Close();
        }

        private void btnReadAll_Click_Click(object sender, EventArgs e)
        {
            // [1] 创建文件流
            FileStream fs = new FileStream("..\\myfile.txt", FileMode.Open);
            // [2] 创建读取器
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            // [3] 以流的方式读取数据
            this.txContent.Text = sr.ReadToEnd();
            // [4] 关闭读取器
            sr.Close();
            // [5] 关闭文件流
            fs.Close();
        }

        private void btnWriteLine_Click_Click(object sender, EventArgs e)
        {
            // [1] 创建文件流
            FileStream fs = new FileStream("..\\myfile.txt", FileMode.Append);
            // [2] 创建写入器
            StreamWriter sw = new StreamWriter(fs);
            // [3] 以流的方式"逐行"写入数据
            sw.WriteLine(DateTime.Now.ToString() + "[文件操作正常!]");
            // [4] 关闭写入器
            sw.Close();
            // [5] 关闭文件流
            fs.Close();
        }

        // 删除文件
        private void btnDel_Click_Click(object sender, EventArgs e)
        {
            File.Delete(this.txtFrom.Text);
        }
        // 复制文件
        private void btnCopy_Click_Click(object sender, EventArgs e)
        {
            // 首先判断目标文件是否存在
            if (File.Exists(this.txtTo.Text.Trim()))
            {
                // 然后将文件删掉
                File.Delete(this.txtTo.Text);
            }
            File.Copy(this.txtFrom.Text.Trim(), this.txtTo.Text.Trim());// 复制文件
        }
        // 显示一个目录下的所有文件
        private void btnShowAllFiles_Click_Click(object sender, EventArgs e)
        {
            // Directory目录类型
            string[] files = Directory.GetFiles("..\\");
            this.txContent.Clear();
            foreach (string item in files)
            {
                this.txContent.Text += item + "\r\n";
            }
        }
        // 获取一个目录下的子目录
        private void btnShowSubDirectory_Click(object sender,EventArgs e) {
            string[] subDirectory = Directory.GetDirectories("..\\");
            this.txContent.Clear();
            foreach(string item in subDirectory) {
                this.txContent.Text += item + "\r\n";
            }
        }
        // 创建一个目录
        private void btnCreateDirectory_Click() {
            DirectoryInfo directoryInfo = Directory.CreateDirectory("..\\MyDirectory");
        }
        // 删除指定目录下的所有目录和文件
        private void btnDelAllFiles_Click(object sender,EventArgs e) {
            Directory.Delete("..\\MyDirectory");
            // 使用DirectoryInfo对象，可以删除不为空的目录,可以删除目录及其子目录
            DirectoryInfo dir = new DirectoryInfo("..\\MyDirectory");
            dir.Delete(true);
        }
    }
}
