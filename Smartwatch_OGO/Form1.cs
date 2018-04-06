using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Smartwatch_OGO
{
    public partial class Form1 : Form
    {

        delegate void SetTextCallback(string text, Label label);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOnePressed(object sender, EventArgs e)
        {

        }

        private void buttonTwoPressed(object sender, EventArgs e)
        {

        }

        public void updateTime(String time)
        {
            timeLabel.Text = time;  // Update niet
            Console.WriteLine(timeLabel.Text + "test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }


        public void SetText(string text, Label label)
        {
            if(label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, label });
            }
            else
            {
                Console.WriteLine(text + " voor testen");
                label.Text = text;
            }
        }
    }


}
