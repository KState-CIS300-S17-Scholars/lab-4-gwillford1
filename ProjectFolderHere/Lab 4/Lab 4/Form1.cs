//Grant Willford
//Lab 4
//I was unable to turn this in due to computer problems and really needing to be at the next class.
//Professor Thornton told I could turn it in today once I got a chance, so here it is.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxFindPrimes_Click(object sender, EventArgs e)
        {
            int bound = Convert.ToInt32(uxEntryBox.Text);
            SieveList sieve = new SieveList();

            uxResultsBox.Text = "";

            sieve.BuildList(bound);
            sieve.FindPrimes();

            foreach (int i in sieve)
            {
                
                uxResultsBox.Text += i.ToString() + " ";
                
            }
        }
    }
}
