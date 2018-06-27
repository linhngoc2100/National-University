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
            textBox3.MaxLength = 52;
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
            string current = (string)comboBox1.SelectedItem;
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
                
                if (zipbox)
                {
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
                    if (textBox3.Text == ""||textBox3.TextLength !=52)
                        MessageBox.Show("Barcode not in correct format", "Barcode input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string s1 = "";
                        s1 = textBox3.Text;
                        textBox4.Text = ConvertBartoZip.convertToZipCode(s1);
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
    }
}
