using System;
using Projectgui.Convert2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Projectgui
{
    public partial class Form1 : Form
    {
        Boolean zipbox=false;
        Boolean barbox=false;
        int size = 8;
        String fontstyle = "R";
        
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            comboBox1.Items.Add("Zip+4");
            comboBox1.Items.Add("Barcode");
            comboBox1.SelectedIndex = 0;
            textBox1.MaxLength = 5;
            textBox2.MaxLength = 4;
            numericUpDown1.Value = size;
          


        }

        /// <summary>
        /// to set up input text in bold style and selected or unselected
        /// </summary>
       
        public void button1_Click(object sender, EventArgs e)
        {

            if (button1.BackColor == Color.LightGray)
            {
                button1.BackColor = Color.LightBlue;
                button2.BackColor = Color.LightGray;

                textBox1.Font = new Font("Arial", size, FontStyle.Bold);
                textBox2.Font = new Font("Arial", size, FontStyle.Bold);
                textBox3.Font = new Font("Arial", size, FontStyle.Bold);
                textBox4.Font = new Font("Arial", size, FontStyle.Bold);

                fontstyle = "B";

            }
            else if (button1.BackColor == Color.LightBlue)
            {
                button1.BackColor = Color.LightGray;
                textBox1.Font = new Font("Arial", size, FontStyle.Regular);
                textBox2.Font = new Font("Arial", size, FontStyle.Regular);
                textBox3.Font = new Font("Arial", size, FontStyle.Regular);
                textBox4.Font = new Font("Arial", size, FontStyle.Regular);
                fontstyle = "R";
            }

        }
       /// <summary>
       /// to set up input text in italic style and selected or unselected
       /// </summary>
       

        public void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightGray)
            {
                button2.BackColor = Color.LightBlue;
                button1.BackColor = Color.LightGray;
                textBox1.Font = new Font("Arial", size, FontStyle.Italic);
                textBox2.Font = new Font("Arial", size, FontStyle.Italic);
                textBox3.Font = new Font("Arial", size, FontStyle.Italic);
                textBox4.Font = new Font("Arial", size, FontStyle.Italic);
                fontstyle = "I";
            }
            else if (button2.BackColor == Color.LightBlue)
            {
                button2.BackColor = Color.LightGray;
                textBox1.Font = new Font("Arial", size, FontStyle.Regular);
                textBox2.Font = new Font("Arial", size, FontStyle.Regular);
                textBox3.Font = new Font("Arial", size, FontStyle.Regular);
                textBox4.Font = new Font("Arial", size, FontStyle.Regular);
                fontstyle = "R";
            }
        }
        /// <summary>
        /// Select size of input text
        /// </summary>
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(numericUpDown1.Value);
            if (fontstyle.Equals("R"))
            {

                textBox1.Font = new Font(textBox1.Font.FontFamily, size);
                textBox2.Font = new Font(textBox2.Font.FontFamily, size);
                textBox3.Font = new Font(textBox3.Font.FontFamily, size);
                textBox4.Font = new Font(textBox3.Font.FontFamily, size);
            }
            else if (fontstyle.Equals("B"))
            {
                textBox1.Font = new Font("Arial", size, FontStyle.Bold);
                textBox2.Font = new Font("Arial", size, FontStyle.Bold);
                textBox3.Font = new Font("Arial", size, FontStyle.Bold);
                textBox4.Font = new Font("Arial", size, FontStyle.Bold);
            }
            else if (fontstyle.Equals("I"))
            {
                textBox1.Font = new Font("Arial", size, FontStyle.Italic);
                textBox2.Font = new Font("Arial", size, FontStyle.Italic);
                textBox3.Font = new Font("Arial", size, FontStyle.Italic);
                textBox4.Font = new Font("Arial", size, FontStyle.Italic);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get selecting which combobox is
            string current = (string)comboBox1.SelectedItem;
            //check to see if it is zip+4 or barcode and then process according to which one is choosen.
            if (current.Equals("Zip+4"))
            {
                groupBox1.Text = "Enter Zip+4";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Enabled = false;
                textBox4.Text = "";
                button3.Text = "Generate Barcode";
                zipbox = true;
                barbox = false;
            }
            else {
                groupBox1.Text = "Enter Barcode";

                textBox1.Visible= false;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox4.Enabled = false;
                textBox4.Text = "";
                button3.Text = "Generate Zip+4";
                barbox = true;
                zipbox = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// textbox1 input barcode check statement if input in format of number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                
            }
        }
        /// <summary>
        /// textbox2 input barcode check statement if input in format of number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                
            }
        }
        /// <summary>
        /// Throw input in to the function that its need
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
                //check to see if it is zipbox input or not. If it is, it will do the action
                if (zipbox)
                {
                    //Check to see if textbox1 and textbox2 is empty or not, and the length of textbox1 and textbox2 is 5 and 4 or not. If not, it will display error message.
                    //if yes, it will process and display the barcode
                    if (textBox1.Text == "" || textBox2.Text == ""|| textBox1.TextLength != 5||textBox2.TextLength
                    !=4)
                        MessageBox.Show("Zipcode not in correct format", "Zipcode input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string s = textBox1.Text;
                        StringBuilder sb = new StringBuilder();
                        sb.Append(s);
                        sb.Append(textBox2.Text);
                        textBox4.Text = convertZiptoBar.convertToBarCode(sb.ToString());
                    }
                }
                else if (barbox)
                {
                //check to see if the textbox3 is empty or not, and if the length is 52 or not. 
                //if not, it will display error message
                //if yes, it will process and display zipcode
                    if (textBox3.Text == ""||textBox3.TextLength !=52)
                        MessageBox.Show("Barcode not in correct format", "Barcode input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string s1 = "";
                        s1 = textBox3.Text;
                    //check the barcode is right or wrong. If right, it will process and display zipcoe, otehrwise will display error message
                        if(CheckDigitValidation.CheckandValidation(s1))
                            textBox4.Text = ConvertBartoZip.convertToZipCode(s1);
                        else
                            MessageBox.Show("Barcode is wrong", "Barcode input error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
                textBox2.Text = "";
                textBox1.Text = "";
                textBox3.Text = "";

        }
        /// <summary>
        /// textbox3 input barcode check statement if input in format of |:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^|,:]"))
            {
                MessageBox.Show("Please enter only Barcode.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
