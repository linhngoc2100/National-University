using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectgui
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.LightGray;
            button2.BackColor = Color.LightGray;
            comboBox1.Items.Add("Zip+4");
            comboBox1.Items.Add("Barcode");
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// to set up input text in bold style and selected or unselected
        /// </summary>
       
        public void button1_Click(object sender, EventArgs e)
        {

            if (button1.BackColor == Color.LightGray) {
                button1.BackColor = Color.LightBlue;
            }
            else if(button1.BackColor == Color.LightBlue)
            {
                button1.BackColor = Color.LightGray;
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
            }
            else if (button2.BackColor == Color.LightBlue)
            {
                button2.BackColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Select size of input text
        /// </summary>
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
