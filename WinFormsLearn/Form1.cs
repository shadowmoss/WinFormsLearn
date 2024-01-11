namespace WinFormsLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("事件弹窗");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Click -= button1_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Click += button1_Click;
        }

        private void btn_messageBox(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("消息框内容","消息框弹窗",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("消息框取消");
            }
            else {
                MessageBox.Show("消息框确认");
            }
        }
    }
}
