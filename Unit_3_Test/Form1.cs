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
    /*
     * 
harrison
franklinRoosevelt
clinton
buchanan
pierce
bush
obama
kennedy
mckinley
reagan
eisenhower
vanburen
washington
adams
theodoreRoosevelt
jefferson
     * 
     */
    public partial class Form1 : Form
    {
        bool testPassed = false;
        public Form1()
        {
            InitializeComponent();

            //start form with harrison's information going
            harrisonRadioButton.Checked = true;
            pictureBox.Image = Unit_3_Test.Properties.Resources.BenjaminHarrison;

            //set up tooltips for each president's text box
            toolTip.SetToolTip(harrisonTextBox, "Which # President?");
            toolTip.SetToolTip(franklinRooseveltTextBox, "Which # President?");
            toolTip.SetToolTip(clintonTextBox, "Which # President?");
            toolTip.SetToolTip(buchananTextBox, "Which # President?");
            toolTip.SetToolTip(pierceTextBox, "Which # President?");
            toolTip.SetToolTip(bushTextBox, "Which # President?");
            toolTip.SetToolTip(obamaTextBox, "Which # President?");
            toolTip.SetToolTip(kennedyTextBox, "Which # President?");
            toolTip.SetToolTip(mckinleyTextBox, "Which # President?");
            toolTip.SetToolTip(reaganTextBox, "Which # President?");
            toolTip.SetToolTip(eisenhowerTextBox, "Which # President?");
            toolTip.SetToolTip(vanburenTextBox, "Which # President?");
            toolTip.SetToolTip(washingtonTextBox, "Which # President?");
            toolTip.SetToolTip(adamsTextBox, "Which # President?");
            toolTip.SetToolTip(theodoreRooseveltTextBox, "Which # President?");
            toolTip.SetToolTip(jeffersonTextBox, "Which # President?");

            //set up pictureBox 
            pictureBox.MouseHover += new EventHandler(pictureBox__MouseHover);
            pictureBox.MouseLeave += new EventHandler(pictureBox__MouseLeave);

            //set up president radio buttons
            harrisonRadioButton.CheckedChanged += new EventHandler(harrisonRadioButton__CheckChanged);
            franklinRooseveltRadioButton.CheckedChanged += new EventHandler(franklinRooseveltRadioButton__CheckChanged);
            clintonRadioButton.CheckedChanged += new EventHandler(clintonRadioButton__CheckChanged);
            buchananRadioButton.CheckedChanged += new EventHandler(buchananRadioButton__CheckChanged);
            pierceRadioButton.CheckedChanged += new EventHandler(pierceRadioButton__CheckChanged);
            bushRadioButton.CheckedChanged += new EventHandler(bushRadioButton__CheckChanged);
            obamaRadioButton.CheckedChanged += new EventHandler(obamaRadioButton__CheckChanged);
            kennedyRadioButton.CheckedChanged += new EventHandler(kennedyRadioButton__CheckChanged);
            mckinleyRadioButton.CheckedChanged += new EventHandler(mckinleyRadioButton__CheckChanged);
            reaganRadioButton.CheckedChanged += new EventHandler(reaganRadioButton__CheckChanged);
            eisenhowerRadioButton.CheckedChanged += new EventHandler(eisenhowerRadioButton__CheckChanged);
            vanburenRadioButton.CheckedChanged += new EventHandler(vanburenRadioButton__CheckChanged);
            washingtonRadioButton.CheckedChanged += new EventHandler(washingtonRadioButton__CheckChanged);
            adamsRadioButton.CheckedChanged += new EventHandler(adamsRadioButton__CheckChanged);
            theodoreRooseveltRadioButton.CheckedChanged += new EventHandler(theodoreRooseveltRadioButton__CheckChanged);
            jeffersonRadioButton.CheckedChanged += new EventHandler(jeffersonRadioButton__CheckChanged);

            //Set up timer
            timer.Tick += new EventHandler(timer__Tick);

            //Set up progress bar
            progressBar.Value = 180;

            //initialize exitButton as disabled
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
                case "Bill_Clinton":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.WilliamJClinton;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "James_Buchanan":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.JamesBuchanan;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Franklin_Pierce":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.FranklinPierce;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "George_W._Bush":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.GeorgeWBush;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Barack_Obama":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.BarackObama;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "John_F._Kennedy":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.JohnFKennedy;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "William_McKinley":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.WilliamMcKinley;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Ronald_Reagan":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.RonaldReagan;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Dwight_D._Eisenhower":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.DwightDEisenhower;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Martin_Van_Buren":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.MartinVanBuren;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "George_Washington":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.GeorgeWashington;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "John_Adams":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.JohnAdams;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Theodore_Roosevelt":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.TheodoreRoosevelt;
                    webBrowserGroupBox.Text = url;
                    webBrowser.Url = new System.Uri(url);
                    break;
                case "Thomas_Jefferson":
                    pictureBox.Image = Unit_3_Test.Properties.Resources.ThomasJefferson;
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
