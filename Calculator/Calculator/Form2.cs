using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        String keyStrokes = String.Empty;
        
        public Form2()
        {
            InitializeComponent();
        }

       

        private void ButtonConversionClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "Data")
            {

            }

            else if (button.Text == "Length")
            {

            }

            else if (button.Text == "Temperature")
            {

            }

            else if (button.Text == "Volume")
            {

            }

            else
            {

            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
