﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        public FrmStudentManage()
        {
            InitializeComponent();
        }

        private void studentManageClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
