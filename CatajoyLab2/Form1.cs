using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Gabriel Jay Catajoy
 * October 4, 2022
 * This lab will demonstrate the use of somebasic maths with numbers and multipliers, as well as
   show the features of different events a button can do, such as showing and hiding texts and pictures.
 */

namespace CatajoyLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This will close the form//
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This button click will open the picture box and hide the data label//
        private void btnPicture_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            lblTopic.Visible = false;
        }
        
        //This button will hide everything that is currently shown on the program (picture and/or data)//
        private void btnHide_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            lblTopic.Visible = false;
        }

        //This will blank out the textboxes and the answer label and put the cursor focus on the Number Textbox//
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxNumber.Clear();
            txtBoxMultiplier.Clear();
            lblProduct.Text = string.Empty;
            txtBoxNumber.Focus();
        }

        //This will display the topic label and information about me! :)//
        private void btnData_Click(object sender, EventArgs e)
        {
            //changed topic name
            string lblTopicName = "Son of a Beach";
            pictureBox1.Visible = false;
            lblTopic.Visible = true;
            lblTopic.Text = "My topic is " + lblTopicName +
                            "\n\nI am Gabriel and I came from the Philippines, a tropical country located in Southeast Asia."
                            + "\n\nBeaches in the Philippines are one of the best in the world! There are numerous white sand beaches, combined with the tropical hot n' humid climate that will surely make you crave for Halo-Halo (literal translation is mix-mix), a Filipino dessert made from mixed sweets, ice cream, and shaved ice.";     
        }

        //This will display some info about the picture when you click the image//
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string message = "Beachin' in La Union";
            string title = "Gabriel Jay Catajoy";
            MessageBox.Show(message, title);
        }

        //This will calculate the product of the two numbers and show the result//
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(txtBoxNumber.Text);
            int Multiplier = Convert.ToInt32(txtBoxMultiplier.Text);
            int Product = Number * Multiplier;

            lblProduct.Text = Convert.ToString(Product);

        }
    }
    }

