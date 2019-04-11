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
        //Inloggning system med användarnamn [Admin] och Lösenord [Admin]
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (edtUsername.Text == "admin")
            {
                if (edtPassword.Text == "admin")
                {
                    new projektclass().Show();
                    this.Hide();
                }

                //meddelande man få om Inloggning information är fel
                else
                {
                    MessageBox.Show("Fel!: Var snäll och  fyll in rätt information!");
                }
            }


            //meddelande man få om Inloggning information är fel med ett liten ruta
            else
            {
                MessageBox.Show("Fel!: Var snäll och  fyll in rätt information!");
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
