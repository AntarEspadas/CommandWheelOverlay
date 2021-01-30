using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Linearstar.Windows.RawInput;

namespace CommandWheelForms
{
    partial class Form1 : Form
    {
        public event EventHandler<RawInputEventArgs> OnInputRecieved;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_INPUT = 0x00FF;
            if (m.Msg == WM_INPUT)
            {
                var data = RawInputData.FromHandle(m.LParam);
                if (data is RawInputMouseData)
                {
                    OnInputRecieved?.Invoke(this, new RawInputEventArgs(data));
                }
                else if (data is RawInputKeyboardData)
                {
                    OnInputRecieved?.Invoke(this, new RawInputEventArgs(data));
                }
            }

            base.WndProc(ref m);
        }
    }
}
