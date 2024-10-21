place a combobox,and a label
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pen");
            comboBox1.Items.Add("Pencil");
            comboBox1.Items.Add("Book");
            comboBox1.Items.Add("Eraser");
            comboBox1.Items.Add("Scale");
            comboBox1.Text = "Book";  // Default selected item
            label1.Text = "";  // Clear the label text initially

            // Subscribe to the SelectedIndexChanged event
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
    }
}
