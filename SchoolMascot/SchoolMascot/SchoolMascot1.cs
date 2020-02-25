/*
 * Created by: Adam Meskini
 * Created on: 18 feb, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program displays a menu bar with menu items
 * when you click on a menue item, the label changesaccording
 * to the item you clicked on
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascot
{
    public partial class SchoolMascot1 : Form
    {
        public SchoolMascot1()
        {
            InitializeComponent();
        }

        private void SchoolMascot1_Load(object sender, EventArgs e)
        {

        }

        private void MniImmaculata_Click(object sender, EventArgs e)
        {
            //Change the labels to reflect Immaculata
            this.lblSchool.Text  =  "Immaculata";
            this.lblMascott.Text = "Saints";
        }

        private void MniStPatrick_Click(object sender, EventArgs e)
        {
            //Change the labels to reflect St Patrick's
            this.lblSchool.Text = "St Patrick's";
            this.lblMascott.Text = "St Pat's Fighting Irish";
        }
        //Change the labels to reflect Lisgar
        private void MniLisgar_Click(object sender, EventArgs e)
        {
            this.lblSchool.Text = "Lisgar";
            this.lblMascott.Text = "  ";
        }
        //Change the labels to reflect Glebe
        private void MniGlebe_Click(object sender, EventArgs e)
        {
            this.lblSchool.Text = "Glebe";
            this.lblMascott.Text = " The Gryphon ";
        }
    }
    }

