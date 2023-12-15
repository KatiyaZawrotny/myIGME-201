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
using TextBox = System.Windows.Forms.TextBox;

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

		const int harrison = 23;
		const int franklinRoosevelt = 32;
		const int clinton = 42;
		const int buchanan = 15;
		const int pierce = 14;
		const int bush = 43;
		const int obama = 44;
		const int kennedy = 35;
		const int mckinley = 25;
		const int reagan = 40;
		const int eisenhower = 34;
		const int vanburen = 8;
		const int washington = 1;
		const int adams = 2;
		const int theodoreRoosevelt = 26;
		const int jefferson = 3;

		public Form1()
		{
			InitializeComponent();

			//start form with harrison's information going
			harrisonRadioButton.Checked = true;
			pictureBox.Image = Unit_3_Test.Properties.Resources.BenjaminHarrison;
			filterAllRadioButton.Checked = true;

			//set up tooltips for each president's text box
			foreach (Control control in Controls)
			{
				if (control.GetType() == typeof(System.Windows.Forms.TextBox))
				{
					toolTip.SetToolTip(control, "Which # President?");
				}
			}

			//set up pictureBox 
			pictureBox.MouseHover += new EventHandler(PictureBox__MouseHover);
			pictureBox.MouseLeave += new EventHandler(PictureBox__MouseLeave);

			//set up president radio buttons
			harrisonRadioButton.CheckedChanged += new EventHandler(HarrisonRadioButton__CheckChanged);
			franklinRooseveltRadioButton.CheckedChanged += new EventHandler(FranklinRooseveltRadioButton__CheckChanged);
			clintonRadioButton.CheckedChanged += new EventHandler(ClintonRadioButton__CheckChanged);
			buchananRadioButton.CheckedChanged += new EventHandler(BuchananRadioButton__CheckChanged);
			pierceRadioButton.CheckedChanged += new EventHandler(PierceRadioButton__CheckChanged);
			bushRadioButton.CheckedChanged += new EventHandler(BushRadioButton__CheckChanged);
			obamaRadioButton.CheckedChanged += new EventHandler(ObamaRadioButton__CheckChanged);
			kennedyRadioButton.CheckedChanged += new EventHandler(KennedyRadioButton__CheckChanged);
			mckinleyRadioButton.CheckedChanged += new EventHandler(MckinleyRadioButton__CheckChanged);
			reaganRadioButton.CheckedChanged += new EventHandler(ReaganRadioButton__CheckChanged);
			eisenhowerRadioButton.CheckedChanged += new EventHandler(EisenhowerRadioButton__CheckChanged);
			vanburenRadioButton.CheckedChanged += new EventHandler(VanburenRadioButton__CheckChanged);
			washingtonRadioButton.CheckedChanged += new EventHandler(WashingtonRadioButton__CheckChanged);
			adamsRadioButton.CheckedChanged += new EventHandler(AdamsRadioButton__CheckChanged);
			theodoreRooseveltRadioButton.CheckedChanged += new EventHandler(TheodoreRooseveltRadioButton__CheckChanged);
			jeffersonRadioButton.CheckedChanged += new EventHandler(JeffersonRadioButton__CheckChanged);

			//set up president text boxes 
			harrisonTextBox.KeyPress += new KeyPressEventHandler(HarrisonTextBox__KeyPress);
			franklinRooseveltTextBox.KeyPress += new KeyPressEventHandler(FranklinRooseveltTextBox__KeyPress);
			clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox__KeyPress);
			buchananTextBox.KeyPress += new KeyPressEventHandler(BuchananTextBox__KeyPress);
			pierceTextBox.KeyPress += new KeyPressEventHandler(PierceTextBox__KeyPress);
			bushTextBox.KeyPress += new KeyPressEventHandler(BushTextBox__KeyPress);
			obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox__KeyPress);
			kennedyTextBox.KeyPress += new KeyPressEventHandler(KennedyTextBox__KeyPress);
			mckinleyTextBox.KeyPress += new KeyPressEventHandler(MckinleyTextBox__KeyPress);
			reaganTextBox.KeyPress += new KeyPressEventHandler(ReaganTextBox__KeyPress);
			eisenhowerTextBox.KeyPress += new KeyPressEventHandler(EisenhowerTextBox__KeyPress);
			vanburenTextBox.KeyPress += new KeyPressEventHandler(VanburenTextBox__KeyPress);
			washingtonTextBox.KeyPress += new KeyPressEventHandler(WashingtonTextBox__KeyPress);
			adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox__KeyPress);
			theodoreRooseveltTextBox.KeyPress += new KeyPressEventHandler(TheodoreRooseveltTextBox__KeyPress);
			jeffersonTextBox.KeyPress += new KeyPressEventHandler(JeffersonTextBox__KeyPress);

			//Set up timer
			timer.Tick += new EventHandler(Timer__Tick);
			timer.Interval = 1000;

			//Set up Filter buttons
			filterAllRadioButton.CheckedChanged += new EventHandler(FilterAllRadioButton__CheckChanged);
			filterDemocratRadioButton.CheckedChanged += new EventHandler(FilterDemocratRadioButton__CheckChanged);
			filterRepublicanRadioButton.CheckedChanged += new EventHandler(FilterRepublicanRadioButton__CheckChanged);
			filterDemocraticRepublicanRadioButton.CheckedChanged += new EventHandler(FilterDemocraticRepublicanRadioButton__CheckChanged);
			filterFederalistRadioButton.CheckedChanged += new EventHandler(FilterFederalistRadioButton__CheckChanged);

			//Set up progress bar
			progressBar.Value = 180;

			//initialize exitButton as disabled
			exitButton.Enabled = false;
			exitButton.Click += new EventHandler(ExitButton__Click);
		}

		
        private void ExitButton__Click(object sender, EventArgs e)
        {
			this.Close();
        }

        //Method to update the progress bar as timer ticks, and ends timer if test is successfully passed
        private void Timer__Tick(object sender, EventArgs e)
		{
			progressBar.Value--;
			if (progressBar.Value == progressBar.Minimum)
			{
				timer.Stop();
				progressBar.Value = progressBar.Maximum;
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(System.Windows.Forms.TextBox))
                    {
                        TextBox textBox = (TextBox)control;
						textBox.Text = "0";

                    }
                }

            }
			else if (CheckComplete() == true)
			{
				timer.Stop();
				exitButton.Enabled = true;
				webBrowserGroupBox.Text = "https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif";
                webBrowser.Url = new Uri("https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif");
			}
		}

		//Method to enlarge picture of president when hovered over
		private void PictureBox__MouseHover(object sender, EventArgs e)
		{
			pictureBox.Size = new Size(218, 304);
		}

        //Method to shrink picture of president when not hovered over
        private void PictureBox__MouseLeave(object sender, EventArgs e)
		{
			pictureBox.Size = new Size(153, 224);
		}

		//Radio Check Changed buttons for each Filter button that updates which presidents are shown
		
		private void FilterAllRadioButton__CheckChanged(object sender, EventArgs e)
		{
			harrisonRadioButton.Visible = true;
            franklinRooseveltRadioButton.Visible = true;
            clintonRadioButton.Visible = true;
            buchananRadioButton.Visible = true;
            pierceRadioButton.Visible = true;
            bushRadioButton.Visible = true;
            obamaRadioButton.Visible = true;
            kennedyRadioButton.Visible = true;
            mckinleyRadioButton.Visible = true;
            reaganRadioButton.Visible = true;
            eisenhowerRadioButton.Visible = true;
            vanburenRadioButton.Visible = true;
            washingtonRadioButton.Visible = true;
            adamsRadioButton.Visible = true;
            theodoreRooseveltRadioButton.Visible = true;
            jeffersonRadioButton.Visible = true;

            harrisonRadioButton.Checked = true;
        }

        
        private void FilterDemocratRadioButton__CheckChanged(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = false;
            franklinRooseveltRadioButton.Visible = true;
            clintonRadioButton.Visible = true;
            buchananRadioButton.Visible = true;
            pierceRadioButton.Visible = true;
            bushRadioButton.Visible = false;
            obamaRadioButton.Visible = true;
            kennedyRadioButton.Visible = true;
            mckinleyRadioButton.Visible = false;
            reaganRadioButton.Visible = false;
            eisenhowerRadioButton.Visible = false;
            vanburenRadioButton.Visible = true;
            washingtonRadioButton.Visible = false;
            adamsRadioButton.Visible = false;
            theodoreRooseveltRadioButton.Visible = false;
            jeffersonRadioButton.Visible = false;

            franklinRooseveltRadioButton.Checked = true;
        }
        private void FilterRepublicanRadioButton__CheckChanged(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = true;
            franklinRooseveltRadioButton.Visible = false;
            clintonRadioButton.Visible = false;
            buchananRadioButton.Visible = false;
            pierceRadioButton.Visible = false;
            bushRadioButton.Visible = true;
            obamaRadioButton.Visible = false;
            kennedyRadioButton.Visible = false;
            mckinleyRadioButton.Visible = true;
            reaganRadioButton.Visible = true;
            eisenhowerRadioButton.Visible = true;
            vanburenRadioButton.Visible = false;
            washingtonRadioButton.Visible = false;
            adamsRadioButton.Visible = false;
            theodoreRooseveltRadioButton.Visible = true;
            jeffersonRadioButton.Visible = false;

            harrisonRadioButton.Checked = true;

        }
        private void FilterDemocraticRepublicanRadioButton__CheckChanged(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = false;
            franklinRooseveltRadioButton.Visible = false;
            clintonRadioButton.Visible = false;
            buchananRadioButton.Visible = false;
            pierceRadioButton.Visible = false;
            bushRadioButton.Visible = false;
            obamaRadioButton.Visible = false;
            kennedyRadioButton.Visible = false;
            mckinleyRadioButton.Visible = false;
            reaganRadioButton.Visible = false;
            eisenhowerRadioButton.Visible = false;
            vanburenRadioButton.Visible = false;
            washingtonRadioButton.Visible = false;
            adamsRadioButton.Visible = false;
            theodoreRooseveltRadioButton.Visible = false;
            jeffersonRadioButton.Visible = true;

            jeffersonRadioButton.Checked = true;

        }
        private void FilterFederalistRadioButton__CheckChanged(object sender, EventArgs e)
        {
            harrisonRadioButton.Visible = false;
            franklinRooseveltRadioButton.Visible = false;
            clintonRadioButton.Visible = false;
            buchananRadioButton.Visible = false;
            pierceRadioButton.Visible = false;
            bushRadioButton.Visible = false;
            obamaRadioButton.Visible = false;
            kennedyRadioButton.Visible = false;
            mckinleyRadioButton.Visible = false;
            reaganRadioButton.Visible = false;
            eisenhowerRadioButton.Visible = false;
            vanburenRadioButton.Visible = false;
            washingtonRadioButton.Visible = true;
            adamsRadioButton.Visible = true;
            theodoreRooseveltRadioButton.Visible = false;
            jeffersonRadioButton.Visible = false;

			washingtonRadioButton.Checked = true;

        }

        //Radio Check Changed buttons for each president that updates the text of the web groupbox, the photo in picturebox,
        // and the website displayed in the web browser.
        #region President Button Checkchanged events
        private void HarrisonRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Benjamin_Harrison");
			}

			private void FranklinRooseveltRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Franklin_D._Roosevelt");
			}
			private void ClintonRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Bill_Clinton");
			}
			private void BuchananRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("James_Buchanan");
			}
			private void PierceRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Franklin_Pierce");
			}
			private void BushRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("George_W._Bush");
			}
			private void ObamaRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Barack_Obama");
			}
			private void KennedyRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("John_F._Kennedy");
			}
			private void MckinleyRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("William_McKinley");
			}
			private void ReaganRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Ronald_Reagan");
			}
			private void EisenhowerRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Dwight_D._Eisenhower");
			}
			private void VanburenRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Martin_Van_Buren");
			}
			private void WashingtonRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("George_Washington");
			}
			private void AdamsRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("John_Adams");
			}
			private void TheodoreRooseveltRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Theodore_Roosevelt");
			}
			private void JeffersonRadioButton__CheckChanged(object sender, EventArgs e)
			{
				UpdatePresident("Thomas_Jefferson");
			}
        #endregion
        //adds a popup if the answer is wrong
        
        private void HarrisonTextBox__KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressChecks(e);
            ValidatePresident(harrisonTextBox, harrison);
			
        }

		private void FranklinRooseveltTextBox__KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressChecks(e);
            ValidatePresident(franklinRooseveltTextBox, franklinRoosevelt);
			
        }
		private void ClintonTextBox__KeyPress(object sender, KeyPressEventArgs e)
		{
			KeyPressChecks(e);
            ValidatePresident(clintonTextBox, clinton);
			
        }
        private void BuchananTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(buchananTextBox, buchanan);

        }
        private void PierceTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(pierceTextBox, pierce);

        }
        private void BushTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(bushTextBox, bush);

        }
        private void ObamaTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(obamaTextBox, obama);

        }
        private void KennedyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(kennedyTextBox, kennedy);

        }
        private void MckinleyTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(mckinleyTextBox, mckinley);

        }
        private void ReaganTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(reaganTextBox, reagan);

        }
        private void EisenhowerTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(eisenhowerTextBox, eisenhower);

        }
        private void VanburenTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(vanburenTextBox, vanburen);

        }
        private void WashingtonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(washingtonTextBox, washington);

        }
        private void AdamsTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(adamsTextBox, adams);

        }
        private void TheodoreRooseveltTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(theodoreRooseveltTextBox, theodoreRoosevelt);

        }
        private void JeffersonTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecks(e);
            ValidatePresident(jeffersonTextBox, jefferson);

        }

        #region Helper Methods 
        //Starts timer if it has not already started, and checks that input is a number
        private void KeyPressChecks(KeyPressEventArgs e)
		{
            if (!(timer.Enabled))
            {
                timer.Start();
            }
            // Allow only digits and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }
		//Checks if a president's text box has the correct answer in it, returns bool
        private bool ValidatePresident(System.Windows.Forms.TextBox textBox, int president)
        {
            if (textBox.Text == president.ToString())
            {
                errorProvider.SetError(textBox, string.Empty);
                return true;

            }
            else
            {
                errorProvider.SetError(textBox, "That is the wrong number.");
                return false;
            }
        }

        //method to update the web address, web browser group box text, and image based on which president's name is passed in
        public void UpdatePresident(string president)
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

		//Checks if the quiz has been properly completed
		private bool CheckComplete()
		{
			if (ValidatePresident(harrisonTextBox, harrison) &&
                ValidatePresident(franklinRooseveltTextBox, franklinRoosevelt) &&
                ValidatePresident(clintonTextBox, clinton) &&
                ValidatePresident(buchananTextBox, buchanan) &&
                ValidatePresident(pierceTextBox, pierce) &&
                ValidatePresident(bushTextBox,bush) &&
                ValidatePresident(obamaTextBox,obama) &&
                ValidatePresident(kennedyTextBox,kennedy) &&
                ValidatePresident(mckinleyTextBox,mckinley) &&
                ValidatePresident(reaganTextBox,reagan) &&
                ValidatePresident(eisenhowerTextBox,eisenhower) &&
                ValidatePresident(vanburenTextBox,vanburen) &&
                ValidatePresident(washingtonTextBox,washington) &&
                ValidatePresident(adamsTextBox, adams) &&
                ValidatePresident(theodoreRooseveltTextBox, theodoreRoosevelt) &&
                ValidatePresident(jeffersonTextBox, jefferson)
                )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//auto generated methods I dont know how to get rid of
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void jeffersonTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
