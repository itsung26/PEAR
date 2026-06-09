using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEAR
{
    public partial class Form1 : Form
    {
        // The string name of the keybind bound button.
        private String boundButtonName;
        // The string code of the keybind bound button.
        private String boundButtonCode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
