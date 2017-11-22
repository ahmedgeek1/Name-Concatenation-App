using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {   //Conditions on the textboxes - Name should be in Letters (no numbers accepted for example)
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxTitle.Text, "^[a-zA-Z]"))
                {
                    MessageBox.Show("You should enter a valid Title (No numbers or empty fields are accepted)");
                    txtBoxTitle.Text.Remove(txtBoxTitle.Text.Length - 1);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxLastName.Text, "^[a-zA-Z]"))
                {
                    MessageBox.Show("You should enter a valid Last Name (No numbers or empty fields are accepted)");
                    txtBoxLastName.Text.Remove(txtBoxLastName.Text.Length - 1);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxFirstName.Text, "^[a-zA-Z]"))
                {   MessageBox.Show("You should enter a valid First Name (No numbers or empty fields are accepted)");
                txtBoxFirstName.Text.Remove(txtBoxFirstName.Text.Length - 1);
                } else if (!System.Text.RegularExpressions.Regex.IsMatch(txtBoxMiddleName.Text, "^[a-zA-Z]"))
                {   MessageBox.Show("You should enter a valid Middle Name (No numbersor empty fields are accepted)");
                    txtBoxMiddleName.Text.Remove(txtBoxMiddleName.Text.Length - 1);
                }
                else { 
                //display Title First Middle Last
                lblOutPut1.Text = txtBoxTitle.Text + " " + txtBoxFirstName.Text + " " + txtBoxMiddleName.Text + " " + txtBoxLastName.Text;
                //display Last, First Middle
                lblOutPut2.Text = txtBoxLastName.Text + ", " + txtBoxFirstName.Text + " " + txtBoxMiddleName.Text;
                //display Title Last
                lblOutPut3.Text = txtBoxTitle.Text + " " + txtBoxLastName.Text;
                //display Last, First, Title    
                lblOutPut4.Text = txtBoxLastName.Text + ", " + txtBoxFirstName.Text + ", " + txtBoxTitle.Text;
                }
            }
            catch(Exception ex) {
                //display the default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all textboxes to blank
            txtBoxTitle.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxMiddleName.Text = "";
            txtBoxLastName.Text = "";

            //Reset all output labels to blank
            lblOutPut1.Text = "";
            lblOutPut2.Text = "";
            lblOutPut3.Text = "";
            lblOutPut4.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
