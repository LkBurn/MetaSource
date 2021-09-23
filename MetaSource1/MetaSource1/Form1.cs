using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaSource1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                var res = CharacterFind.Process(textBox1.Text);
                textBox1.ReadOnly = true;
                button1.Enabled = false;
                textBox2.Text = res.Character.ToString();
                textBox3.Text = res.Occurence.ToString();
            } else
            {
                MessageBox.Show("Text cannot be empty!");
            }
     
        }

    }
}
