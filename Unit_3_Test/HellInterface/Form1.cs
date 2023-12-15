using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellInterface
{
    public partial class Form1 : Form
    {
        private string[] words = { "Man ", "seeks ", "not ", "wisdom ", "nor ", "power; ", "he ", "only ", "seeks ", "Snapple ", "Peach ", "Tea ", "and ", "the ", "infinite ", "erasure ", "of ", "the ", "number ", "37", "." };
        public Form1()
        {
            InitializeComponent();

            enterButton.Click += new EventHandler(EnterButton__Click);
            threadButton.Click += new EventHandler(ThreadButton__Click);
            clownButton.Click += new EventHandler(ClownButton__Click);
            studyTopicButton.Click += new EventHandler(StudyTopicButton__Click);
            brainOffButton.Click += new EventHandler(BrainOffButton__Click);


            studyTimer.Interval = 1000;
            studyTimer.Tick += new EventHandler(StudyTimer__Tick);

            checkBox.CheckedChanged += new EventHandler(CheckBox__CheckedChanged);
        }

        private void EnterButton__Click(object sender, EventArgs e)
        {
            studyProgressBar.Maximum = (int)studyTimeNumericUpDown1.Value * 60;
            studyTimer.Start();
        }

        private void ThreadButton__Click(Object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            Thread thread = new Thread(WordDisplayThread);
            thread.Start();
            threadButton.Enabled = false;
            
        }

        private void ClownButton__Click(Object sender, EventArgs e)
        {
            ClownBox clownBox = new ClownBox(ref pictureBox);
            clownBox.ShowDialog();
        }

        private void StudyTopicButton__Click(Object sender, EventArgs e)
        {
            checkBox.Text = studyTextBox.Text;
            checkBox.Visible = true;
        }

        private void BrainOffButton__Click(Object sender, EventArgs e)
        {
            BrainOffBox brainBox = new BrainOffBox(ref patienceLabel);
            brainBox.ShowDialog();
        }

        private void WordDisplayThread()
        {
            int index = 0;
            while (index < words.Length)
            {
                
                Thread.Sleep(1000);

                richTextBox1.AppendText(words[index]);
                index++;
               
            }
            
        }

        private void StudyTimer__Tick(object sender, EventArgs e)
        {
            studyProgressBar.Value ++;
            if (studyProgressBar.Value % 37 == 0)
            {
                try
                {
                    studyProgressBar.Value += 47;
                }
                catch (Exception ex)
                {
                    studyProgressBar.Value = studyProgressBar.Maximum - 1;
                }
                
            }
            else if (studyProgressBar.Value % 76 == 0)
            {
                studyProgressBar.Value -= 18;
            }
            if (studyProgressBar.Value == studyProgressBar.Maximum)
            {
                studyTimer.Stop();
                this.Close();
            }
        }
        private void CheckBox__CheckedChanged(object sender, EventArgs e)
        {
            queenWebBrowser.Visible = checkBox.Checked;
        }
    }

    
}
