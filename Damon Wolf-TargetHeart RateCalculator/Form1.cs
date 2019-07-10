using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damon_Wolf_TargetHeart_RateCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string FirstName = txtFName.Text;
            string LastName = txtLName.Text;
            int BirthYear = Convert.ToInt32(txtBirthYr.Text);
            lblUserName.Text = FirstName + " " + " " + LastName;

            int Age = 2018 - BirthYear;
            int MaxHR = 220 - Age;
            double MinTargetRate = MaxHR * .50;
            double MaxTargetRate = MaxHR * .85;

            lblMaxHeartRate.Text = Convert.ToString(MaxHR);
            lblTargetRange.Text = Convert.ToString(MinTargetRate + " " + " - " + " " + MaxTargetRate);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtFName.Text = "";
            txtLName.Text = "";
            txtBirthYr.Text = "";
            lblMaxHeartRate.Text = "";
            lblTargetRange.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
