using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modem
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
                textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            serialPort.Open();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string comand = "atd" + textBox1.Text + "\r";
            serialPort.Write(comand);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            serialPort.Write("+++");
            Thread.Sleep(1000);
            serialPort.Write("ATH\r");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            serialPort.Write("ata\r");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort.Write(textBox2.Text + "\r");
        }
    }
}
