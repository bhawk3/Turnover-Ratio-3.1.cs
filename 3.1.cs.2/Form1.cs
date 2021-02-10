using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Project: Turnver Ratio Project
 * Programmer: Brendan Hawk
 * Date: 09/28/2020
 * Description: Take the beginning and ending inventories and calculate the average cost of goods sold then calculate the turnover ratio.
 */

namespace _3._1.cs._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
decimal average;
            decimal average2;
            decimal average3;
            decimal turnover;
            decimal turnover2;
            decimal turnover3;
        private void calculateButton_Click(object sender, EventArgs e)
        {

            //Declare the variables

            int beginning;
            int beginning2;
            int beginning3;
            int ending;
            int ending2;
            int ending3;
            int cost;
            int cost2;
            int cost3;
            


            // converting the text box inputs to the variable data types
            beginning = int.Parse(beginningTextBox.Text);
            beginning2 = int.Parse(beginningTextBox2.Text);
            beginning3 = int.Parse(beginningTextBox3.Text);

            ending = int.Parse(endingTextBox.Text);
            ending2 = int.Parse(endingTextBox2.Text);
            ending3 = int.Parse(endingTextBox3.Text);

            cost = int.Parse(cogTextBox.Text);
            cost2 = int.Parse(cogTextBox2.Text);
            cost3 = int.Parse(cogTextBox3.Text);

            try
            {
                // average inventory and turnover ratio calculations
                average = (beginning + ending) / 2;
            }
            catch
            {
                MessageBox.Show("error with row 1 average ");
            }
            try
            {
            average2 = (beginning2 + ending2) / 2;

            }
            catch
            {
                MessageBox.Show("error with row 2 average ");
            }
            try
            {
                average3 = (beginning3 + ending3) / 2;
            }
            catch
            {
                MessageBox.Show("error with row 3 average ");
            }
            try
            {
                turnover = cost / average;
            }
            catch
            {
                MessageBox.Show("error with row 1 turnover");
            }
            try
            {
            turnover2 = cost2 / average2;

            }
            catch
            {
                MessageBox.Show("error with row 2 turnover");
            }
            try
            {
                turnover3 = cost3 / average3;
            }
            catch
            {
                MessageBox.Show("error with row 3 turnover");
            }

            // Convert the average text boxes and turnover text boxes to currency and decimal
            averageTextBox.Text = average.ToString("C");
            averageTextBox2.Text = average2.ToString("C");
            averageTextBox3.Text = average3.ToString("C");
            turnoverTextBox.Text = turnover.ToString("N");
            turnoverTextBox2.Text = turnover2.ToString("N");
            turnoverTextBox3.Text = turnover3.ToString("N");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the average inventory and turnover ratio

            averageTextBox.Clear();
            averageTextBox2.Clear();
            averageTextBox3.Clear();
            turnoverTextBox.Clear();
            turnoverTextBox2.Clear();
            turnoverTextBox3.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program 

            this.Close();
        }
    }
}
