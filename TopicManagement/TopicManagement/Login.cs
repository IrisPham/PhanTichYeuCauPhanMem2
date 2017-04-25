using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.AcceptButton = null;
            lblError.Visible = false;
            pnlPassword.Visible = true;
            btnOK.Visible = false;
            txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                Validate();
            }
        }

        private void Validate() {
            String sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Visual-Studio\Desktop\Backup\TopicManagement\TopicManagement\TopicManagement.mdf;Integrated Security=True";
            if (!Database.connect(sql))
                MessageBox.Show("Không kết nối được với cơ sở dữ liệu!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List<String> list = Database.getSingelData("Select password from account where username='admin'");
            if (txtPassword.Text == list[0])
            {
                this.Hide();
                new Main().ShowDialog();
            }
            else
            {
                this.AcceptButton = btnOK;
                pnlPassword.Visible = false;
                lblError.Visible = true;
                btnOK.Visible = true;
            }
        }
    }
}
