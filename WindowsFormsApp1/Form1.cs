using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib1;
using Humanizer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int sum = MathLibrary.Add(firstNumTextBox.Text, seconfNumTextBox.Text);
            sumLabel.Text = sum.ToWords();
        }
    }
}
