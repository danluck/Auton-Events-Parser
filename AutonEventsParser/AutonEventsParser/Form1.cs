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

            var inputString = richTextBoxInput.Text;
            var inputDataFormat = radioButtonIsHex.Checked ? 
                InputDataFormats.Hex : InputDataFormats.Decimal;
            labelByteLength.Text = deserializer.GetByteArrayLength(
                inputString, inputDataFormat).ToString();

            richTextBoxOutput.Text = deserializer.FindEventClassId(inputString, inputDataFormat);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/danluck/Auton-Events-Parser");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonIsHex.Checked = true;
        }
    }
}
