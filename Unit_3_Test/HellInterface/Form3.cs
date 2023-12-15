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
    public partial class BrainOffBox : Form
    {
        private Label label;
        public BrainOffBox(ref Label label)
        {
            InitializeComponent();

            this.label = label;

            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer__Tick);
            timer.Start();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 10 ) 
            {
                label.Visible = true;
                timer.Stop();
                this.Close();
            }
        }
    }
}
