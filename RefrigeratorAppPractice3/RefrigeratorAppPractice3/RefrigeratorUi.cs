using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrrigerators refrigerator = new Refrrigerators();
        public int t = 1 ;

        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (t>=1)
            {

                refrigerator.MaxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
                maxWeightTakeTextBox.Clear();
                t--;
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Maximum Wight can take once only");
            }

           


        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int noOfitems = Convert.ToInt32(itemTextBox.Text);
            double unitWeight = Convert.ToDouble(weightTextBox.Text);
            refrigerator.Weight(noOfitems, unitWeight);
            refrigerator.remainingWeight = refrigerator.MaxWeight - refrigerator.currentWeight;
            currentWeightTextBox.Text = refrigerator.currentWeight.ToString();
            remainingWeightTextBox.Text = refrigerator.remainingWeight.ToString();
            currentWeightTextBox.ReadOnly = true;
            remainingWeightTextBox.ReadOnly = true;

        }
    }
}
