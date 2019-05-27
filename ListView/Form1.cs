using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName, strAge, strWork; //나이, 이릅, 직업 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                strName = this.txtName.Text;
                strAge = this.txtAge.Text;
                strWork = this.txtWork.Text;
                ListViewItem lvi = new ListViewItem(new string[] { this.strName, this.strAge, this.strWork }); //리스트뷰에 들어갈 항목 생성
                this.lvView.Items.Add(lvi);
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
                this.txtName.Focus();
            }

        }

        private void lvView_Click(object sender, EventArgs e)
        {
                ListViewItem lvi = this.lvView.SelectedItems[0];
                MessageBox.Show("이름 : " + lvi.SubItems[0].Text +
                   "\n나이 : " + lvi.SubItems[1].Text +
                   "\n직업 : " + lvi.SubItems[2].Text,
                   "알림",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       private bool TextCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 넣어주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 넣어주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAge.Focus();
                return false;
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("직업을 넣어주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWork.Focus();
                return false;
            }
            return true;
        }
    }
}
