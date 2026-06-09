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

        private readonly GlobalKeyboardHook keyboardHook = new GlobalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
            // Wire up the signal.
            keyboardHook.KeyPressed += HandleGlobalKeyPress;
        }

        // Unhook on exit.
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            keyboardHook.Dispose();
            base.OnFormClosed(e);
        }

        private void HandleGlobalKeyPress(string keyName)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => onKeyPressed(keyName)));
                return;
            }

            onKeyPressed(keyName);
        }

        private void onKeyPressed(String keyName)
        {
            Console.WriteLine(keyName);
        }
    }
}
