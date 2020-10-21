using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutonEventsParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            var deserializer = new Deserializer();

            labelByteLength.Text = deserializer.GetByteArrayLength(
                richTextBoxInput.Text).ToString();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/danluck/Auton-Events-Parser");
        }
    }
}
