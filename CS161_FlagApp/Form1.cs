using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_FlagApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void finlandImage_Click(object sender, EventArgs e)
        {
            flagNameLabel.Text = "Finland";
        }

        private void franceImage_Click(object sender, EventArgs e)
        {
            flagNameLabel.Text = "France";
        }

        private void germanyImage_Click(object sender, EventArgs e)
        {
            flagNameLabel.Text = "Germany";
        }
    }
}
