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
namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private static ManualResetEventSlim _reset = new ManualResetEventSlim();
        bool start = false;
        bool stop = false;
        Thread myThread3;
        public Form1()
        {
            InitializeComponent();
        }
        private void Main2(object sender, EventArgs e)
        {
                button1.Click -= Main2;
                richTextBox1.Text = "";
                string n = textBox1.Text;
                stop = false;
                int N;
                try
                {
                    N = int.Parse(n);
                    myThread3 = new(Sum);
                    start = true;
                    myThread3.IsBackground = true;
                    myThread3.Start(N);

                }
                catch
                {
                    richTextBox1.Text = "Неправильный ввод";
                }
            void Sum(object obj)
            {
                double sum = 0;
                if (obj is int n)
                {
                    int i = 0;
                    while (start)
                    {
                        if (myThread3.IsAlive)
                        {
                            sum += 1 / Math.Pow(2, i);
                            Action action = () => richTextBox1.Text += sum.ToString() + '\n';
                            richTextBox1.Invoke(action);
                            Thread.Sleep(1000);
                            i++;
                            while (stop)
                            {

                            }
                        }
                    }
                }
            }
        }

        private void ThreatStop(object sender, EventArgs e)
        {
            if(stop == true )
            {
                button3.Text = "Break";
                stop = true;
            }
            else if (stop == false && start == true)
            {
                button3.Text = "Continue";
                richTextBox1.Text += "Поток остановлен" +'\n';
            }
            stop = !stop;
        }
        private void StopInfinite(object sender, EventArgs e)
        {
            button1.Click += Main2 ;
            start = false;
            ThreatStop(sender,e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
