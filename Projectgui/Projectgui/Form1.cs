using System;
using Projectgui.Convert;
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
           
        }

        /// <summary>
        /// to set up input text in bold style and selected or unselected
        /// </summary>
       
        public void button1_Click(object sender, EventArgs e)
        {

            if (button1.BackColor == Color.LightGray) {
                button1.BackColor = Color.LightBlue;
                button2.BackColor = Color.LightGray;
                textBox1.Font = new Font("Arial", 8, FontStyle.Bold);
                textBox2.Font = new Font("Arial", 8, FontStyle.Bold);
                textBox3.Font = new Font("Arial", 8, FontStyle.Bold);
                textBox4.Font = new Font("Arial", 8, FontStyle.Bold);

            }
            else if(button1.BackColor == Color.LightBlue)
            {
                button1.BackColor = Color.LightGray;
                textBox1.Font = new Font("Arial", 8, FontStyle.Regular);
                textBox2.Font = new Font("Arial", 8, FontStyle.Regular);
                textBox3.Font = new Font("Arial", 8, FontStyle.Regular);
                textBox4.Font = new Font("Arial", 8, FontStyle.Regular);
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
                textBox1.Font = new Font("Arial", 8, FontStyle.Italic);
                textBox2.Font = new Font("Arial", 8, FontStyle.Italic);
                textBox3.Font = new Font("Arial", 8, FontStyle.Italic);
                textBox4.Font = new Font("Arial", 8, FontStyle.Italic);

            }
            else if (button2.BackColor == Color.LightBlue)
            {
                button2.BackColor = Color.LightGray;
                textBox1.Font = new Font("Arial", 8, FontStyle.Regular);
                textBox2.Font = new Font("Arial", 8, FontStyle.Regular);
                textBox3.Font = new Font("Arial", 8, FontStyle.Regular);
                textBox4.Font = new Font("Arial", 8, FontStyle.Regular);
            }
        }
        /// <summary>
        /// Select size of input text
        /// </summary>
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;
            textBox4.Font = new Font(textBox4.Font.FontFamily, i);
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
                button3.Text = "Generate Zip+4";
                zipbox = true;
                barbox = false;
            }
            else {
                groupBox1.Text = "Enter Barcode";

                textBox1.Visible= false;
                textBox2.Visible = false;
                textBox3.Visible = true;
                textBox4.Enabled = false;
                button3.Text = "Generate Barcode";
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
                textBox1.Text = "";
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
                textBox2.Text = "";
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
                    if (textBox1.Text == "" || textBox2.Text == "")
                        MessageBox.Show("Zipcode cannot empty", "Zipcode input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string s = textBox1.Text;
                        StringBuilder sb = new StringBuilder();
                        sb.Append(s);
                        sb.Append(textBox2.Text);
                        textBox4.Text = PostalBarCode.convertToBarCode(sb.ToString());
                    }
                }
                else if (barbox)
                {
                    if (textBox3.Text == "")
                        MessageBox.Show("barcode cannot empty", "Barcode input error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string s1 = "";
                        s1 = textBox3.Text;


                        textBox4.Text = PostalBarCode.convertToZipCode(s1);
                    }
                }
            
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
                textBox3.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
