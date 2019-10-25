using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageSasha
{
    public partial class frmRunningAverage : Form
    {
        double value = 0, numberOfValues = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

       private void BtnCalculate_Click(object sender, EventArgs e)
       {
            double average, sum = 0 ; 

            sum = double.Parse(this.txtNumber.Text);

            numberOfValues++;

            sum = value + sum; 

            average = sum / numberOfValues;

            lblAverage.Text = Convert.ToString(average);
       }
    }
}