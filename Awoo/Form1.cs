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
    public partial class Form1 : Form
    {
        int i;
        int Number = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }
        async Task PutTaskDelay()
        {
            await Task.Delay(1000);
        }

        private async void AwooButton_Click(object sender, EventArgs e)
        {
            MsgLabel.Text = "Awooing...";
            spinner.Visible = true;
            ProgBarText.Text = "Initializing";
            await PutTaskDelay();
            ProgBarText.Text = "Loading Waffs...";
            Progbar.PerformStep();
            await PutTaskDelay();
            ProgBarText.Text = "Disabling Fines...";
            Progbar.PerformStep();
            await PutTaskDelay();
            ProgBarText.Text = "*Inhales*";
            Progbar.PerformStep();
            await PutTaskDelay();
            ProgBarText.Text = "Awoooooooooo!";
            Progbar.PerformStep();
            await PutTaskDelay();
            await PutTaskDelay();

            while (i < Number)
            {
                i++;
                Awoo open_form = new Awoo();
                open_form.Visible = true;
            }

            if (i == Number)
            {
                i = 0;
            }

            //MessageBox.Show("I am back");
        }

        public void Reset()
        {
            spinner.Visible = false;
            MsgLabel.Text = "Click To Start A Howl";
            ProgBarText.Text = "Ready";
            Progbar.Value = 0;
        }
    }
}
