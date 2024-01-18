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
        #region �ر�֮ǰ�Ĵ���Ƕ���´���
        // �жϵ�ǰ�����Ҳ��Ƿ���ڴ��壬�о͹ر�
        private void ClosePreForm() {
            // �����жϵ�ǰ�������Ƿ��Ѿ����ڴ���
            foreach (Control item in this.spContainer.Panel2.Controls) {
                if (item is Form) {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }
        private void OpenForm(Form frmAdd) {
            frmAdd.TopLevel = false; // ���Ӵ������óɷǶ����ؼ�
            frmAdd.WindowState = FormWindowState.Maximized; // ���Ӵ������
            frmAdd.FormBorderStyle = FormBorderStyle.None; // ȥ������ı߿�
            frmAdd.Parent = this.spContainer.Panel2;   // ָ���Ӵ�����ʾ������
            frmAdd.Show();
        }
        #endregion
    }
}
