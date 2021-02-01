using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandWheelForms.Forms
{
    public partial class ComfirmationDialog : Form
    {
        public ComfirmationDialog(string message, string title = "")
        {
            InitializeComponent();
            label.Text = message;
            Name = title;
        }
    }
}
