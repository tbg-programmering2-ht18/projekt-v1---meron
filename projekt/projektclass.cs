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

        //den kod visar de webbsidor man kan välja som aternativ
        static private string[] url = new string[] {"http://www.google.com", "https://www.facebook.com/", "http://www.w3schools.com", "https://www.youtube.com/",} ;


        //information för varje webbsida man väljer
        static private string[] urlBeskrivning = new string[] { "Google är ett multinationellt internetföretag inriktat på Internetrelaterade produkter och tjänster som omfattar annonsering på nätet, en sökmotor",
            "Facebook är ett socialt medium eller en social nätverkstjänst som grundades i februari 2004 och i juni 2017 hade Facebook mer än 2 miljarder månatligt aktiva användare. Användarna kan skapa en personlig profil, lägga till andra användare som vänner och utbyta meddelanden.",
            "W3Schools är en pedagogisk webbplats för att lära sig hur man gör webbsidor på nätet. Innehållet innehåller handledning och referenser relaterade till HTML, CSS, JavaScript, , PHP, Python, och Java mm.",
            "Youtube är en videogemenskap, det vill säga en webbplats med videoklipp som laddas upp av dess användare"
        };


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

        //koppling till hur webbsidor ska placeras och vilken information som ska komma på skärmen 
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.webBrowser2.Navigate(url[comboBox2.SelectedIndex]);
            richTextBox1.Text = urlBeskrivning[comboBox2.SelectedIndex];
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
