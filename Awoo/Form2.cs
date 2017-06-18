using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awoo
{
    public partial class Awoo : Form
    {
        public Awoo()
        {
            InitializeComponent();
        }

        private void Awoo_Load(object sender, EventArgs e)
        {
            AwooText.Text = "awooooooooooooooooooo\noooooooooooooooooo...";
            Reset();
        }

        private void Awoo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void Reset()
        {
            //AWOOOOOOOOOOOOOOOOOOOOOOOOO
        }
    }
}
