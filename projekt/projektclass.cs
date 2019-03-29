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

        List<nameandpass> User = new List<nameandpass>();
     


        static private string[] url = new string[] {"http://www.google.com", "http://www.facebook.com", "http://www.samarbeta.se", "http://www.w3schools.se", "file://webbprojekt/smorgasbordet" } ;

        public projektclass()
        {
            InitializeComponent(); 
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

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string iteamText = comboBox2.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.webBrowser2.Navigate(url[comboBox2.SelectedIndex]);
        }
    }
}
