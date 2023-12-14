using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unit_3_Test
{
    public partial class Form1 : Form
    {
        bool testPassed = false;
        public Form1()
        {
            InitializeComponent();

            //start form with harrison's information going
            harrisonRadioButton.Checked = true;
            pictureBox.Image = Unit_3_Test.Properties.Resources.BenjaminHarrison;

            pictureBox.MouseHover += new EventHandler(pictureBox__MouseHover);
            pictureBox.MouseLeave += new EventHandler(pictureBox__MouseLeave);

            harrisonRadioButton.CheckedChanged += new EventHandler(harrisonRadioButton__CheckChanged);
            franklinRooseveltRadioButton.CheckedChanged += new EventHandler(franklinRooseveltRadioButton__CheckChanged);

            timer.Tick += new EventHandler(timer__Tick);
            progressBar.Value = 180;
            exitButton.Enabled = false;
            
        }

        private void timer__Tick(object sender, EventArgs e)
        {
            progressBar.Value--;
            if (progressBar.Value == progressBar.Minimum)
            {
                timer.Stop();
            }
            else if (testPassed)
            {
                timer.Stop();
                exitButton.Enabled = true;
            }
        }

        private void pictureBox__MouseHover(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(218, 304);
        }
        private void pictureBox__MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(153, 224);
        }

        private void harrisonRadioButton__CheckChanged(object sender, EventArgs e)
        {
            updatePresident("Benjamin_Harrison");
        }

        private void franklinRooseveltRadioButton__CheckChanged(object sender, EventArgs e)
        {
            updatePresident("Franklin_D._Roosevelt");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        //method to update the web address, web browser group box text, and image based on which president's name is passed in
        public void updatePresident(string president)
        {
            string url = "https://en.wikipedia.org/wiki/" + president;
            
            switch (president)
            {
                case "Benjamin_Harrison":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.BenjaminHarrison;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Franklin_D._Roosevelt":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.FranklinDRoosevelt;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                default:
                    pictureBox.Image = Unit_3_Test.Properties.Resources.BenjaminHarrison;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
            }

        }
    }
}
