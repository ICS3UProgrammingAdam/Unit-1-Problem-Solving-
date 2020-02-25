using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatAdam
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void MniCat2_Click(object sender, EventArgs e)
        {
            //changes picture box to cat 2 when cat 2 is clicked
            this.picCat.Image = Properties.Resources.cat2;
        }

       
        private void MniCat1_Click(object sender, EventArgs e)
        {
            //changes picture box to cat 1 when cat 1 is clicked
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void MniR1_Click(object sender, EventArgs e)
        {
            //changes picture box to yamaha r1 when clicked
            this.picBikes.Image = Properties.Resources.yamaha_r1;
        }

        private void Mni1000rr_Click(object sender, EventArgs e)
        {
            //changes picture box to cbr1000rr when clicked
            this.picBikes.Image = Properties.Resources.cbr1000rr;
        }

        private void MnuBikes_Click(object sender, EventArgs e)
        {

        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
