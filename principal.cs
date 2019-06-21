using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_WFA
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "usuario" && txt_password.Text == "usuario")
            {
                MessageBox.Show("Se inicio sesion");
                txt_user.Text = "";
                txt_password.Text = "";
                txt_user.Focus();
            }
            else
            {
                MessageBox.Show("Eror en el usuario o la contraseña");
                txt_user.Text = "";
                txt_password.Text = "";
                txt_user.Focus();
            }
        }
    }
}
