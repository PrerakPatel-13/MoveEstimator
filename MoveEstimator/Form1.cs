using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double baseRate = 200;
            double hourlyCharge = 150;
            double per_mile_charge = 2;

            double hours, miles;
            double estimate;

            
            hours = Convert.ToDouble(HoursGetter.Text);
           
            miles = Convert.ToDouble(MilesGetter.Text);
            estimate = baseRate + (hours * hourlyCharge) + (miles * per_mile_charge);
            MessageBox.Show("For " + miles + " miles and " + hours + " hours, total estimate is " + estimate);

        }


    }
}
