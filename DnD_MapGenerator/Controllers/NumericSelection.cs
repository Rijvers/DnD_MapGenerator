using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_MapGenerator.Controllers
{
    public partial class NumericSelection : UserControl
    {

        [Description("Description"),Category("Design")]
        public string Description
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [Description("Min selectable value"), Category("Data")]
        public decimal Min
        {
            get { return numericUpDown1.Minimum; }
            set { numericUpDown1.Minimum = value; trackBar1.Minimum = (int)value; }
        }

        [Description("Max selectable value"), Category("Data")]
        public decimal Max
        {
            get { return numericUpDown1.Maximum; }
            set { numericUpDown1.Maximum = value; trackBar1.Maximum = (int)value; }
        }

        [Description("Value"), Category("Data")]
        public decimal Value
        {
            get { return numericUpDown1.Value;  }
            set { numericUpDown1.Value = value; trackBar1.Value = (int)value; }
        }

        public event EventHandler ValueChanged
        {
            add { numericUpDown1.ValueChanged += value; }
            remove { numericUpDown1.ValueChanged -= value; }
        }

        public NumericSelection()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }
    }
}
