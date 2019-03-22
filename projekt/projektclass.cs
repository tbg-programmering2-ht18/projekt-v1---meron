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
    public partial class projektclass : Form
    {
        static private string[] url = new string[] {"http://www.google.com", "http://www.facebook.se", "http://www.samarbeta.se", "http://www.w3schools.se", "file://webbprojekt/smorgasbordet" } ;

        public projektclass()
        {
            InitializeComponent(); //wwbvwrbv
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string iteamText = comboBox1.SelectedItem.ToString();
            MessageBox.Show(iteamText);
            this.webBrowser1.Navigate(url[comboBox1.SelectedIndex]);



        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(textBox1.Text);

        }

    }
}
