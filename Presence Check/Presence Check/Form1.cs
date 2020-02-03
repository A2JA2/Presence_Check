using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presence_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.text))
            {
                MessageBox.Show("The input box is emty - input is required.");
                return;
            }
            else
            {
                txtInput.text = "";
                MessageBox.Show("Input accepted");
                return;
            }
        }
    }
}
