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
            MessageBox.Show("�¼�����");
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
           DialogResult result = MessageBox.Show("��Ϣ������","��Ϣ�򵯴�",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("��Ϣ��ȡ��");
            }
            else {
                MessageBox.Show("��Ϣ��ȷ��");
            }
        }
    }
}
