using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        projektclass frmuser = new projektclass();

        public Form1()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (edtUsername.Text == "admin")
            {
                if (edtPassword.Text == "admin")
                {
                    new projektclass().Show();
                    this.Hide();
                }
                
                else
                {
                    MessageBox.Show("Error: please enter ther correct information");
                }
            }

            else
            {
                MessageBox.Show("Error: please enter ther correct information");
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
