using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 임베디드_어플리케이션_구현_환경구축
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " Connection");
            this.txtArea.Text = "";
            this.txtArea.AppendText(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " Connection");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            this.txtArea.Text = "";
            this.txtArea.AppendText("LED_01 ON SUCCESS");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            this.txtArea.Text = "";
            this.txtArea.AppendText("LED_01 OFF SUCCESS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            this.txtArea.Text = "";
            this.txtArea.AppendText("LED_02 ON SUCCESS");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            this.txtArea.Text = "";
            this.txtArea.AppendText("LED_02 OFF SUCCESS");
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Console.WriteLine("Selected " + cb.Items[cb.SelectedIndex]);
        }

    }
}
