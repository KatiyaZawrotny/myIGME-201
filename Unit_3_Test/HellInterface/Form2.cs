using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellInterface
{
    public partial class ClownBox : Form
    {
        private PictureBox pictureBox;
        public ClownBox(ref PictureBox pictureBox)
        {
            InitializeComponent();
            this.pictureBox = pictureBox;
            exitButton.Click += new EventHandler(ExitButton__Click);
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
            pictureBox.Image = Properties.Resources.clown;
        }
    }
}
