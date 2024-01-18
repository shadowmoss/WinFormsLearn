namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            FrmAddStudent frmAdd = new FrmAddStudent();
            OpenForm(frmAdd);
        }

        private void btnStuManage_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            FrmStudentManage frmStudentManage = new FrmStudentManage();
            OpenForm(frmStudentManage);
        }
        #region 关闭之前的窗体嵌入新窗体
        // 判断当前容器右侧是否存在窗体，有就关闭
        private void ClosePreForm() {
            // 首先判断当前容器中是否已经存在窗体
            foreach (Control item in this.spContainer.Panel2.Controls) {
                if (item is Form) {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }
        private void OpenForm(Form frmAdd) {
            frmAdd.TopLevel = false; // 将子窗体设置成非顶级控件
            frmAdd.WindowState = FormWindowState.Maximized; // 将子窗体最大化
            frmAdd.FormBorderStyle = FormBorderStyle.None; // 去掉窗体的边框
            frmAdd.Parent = this.spContainer.Panel2;   // 指定子窗体显示的容器
            frmAdd.Show();
        }
        #endregion
    }
}
