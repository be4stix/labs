using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ThreadingTest
{
    public partial class Form1 : Form
    {
        List<Thread> threads = new List<Thread>();
        public int successJobs = 0;
        public int failJobs = 0;
        public object lockobj = new object();

        public Form1()
        {
            InitializeComponent();
            GUIController.setForm(this);
        }


        public void ThreadCompleted(object sender, EventArgs e)
        {
            lock (lockobj)
            {
                ThreadArgs TA = (ThreadArgs)e;
                threads.Remove((Thread)sender);

                if (TA.isSuccess)
                {
                    successJobs++;
                    GUIController.updateSuccessLabel(successJobs);

                }
                else
                {
                    failJobs++;
                    GUIController.updateFailsLabel(failJobs);
                }

                GUIController.updateProgressBar(1);
                GUIController.updateAliveThreadsLabel(threads.Count);

                if (threads.Count == 0)
                {
                    GUIController.appendLog("MAIN", "ALL JOB COMPLETED");
                    GUIController.startButtonEnabled(true);
                    GUIController.stopButtonEnabled(false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thrCount = Convert.ToInt32(numericUpDown1.Value);

            progressBar1.Value = 0;
            progressBar1.Maximum = thrCount;

            GUIController.appendLog("MAIN", "RUNNING " + thrCount + " THREADS");
            for (int i = 0; i < thrCount; i++)
            {
                ThreadJob TJ = new ThreadJob();
                TJ.ThreadCompleted += ThreadCompleted;

                Thread thr = new Thread(TJ.Job);
                thr.Name = (i + 1).ToString();
                thr.Start();

                threads.Add(thr);

            }

            GUIController.startButtonEnabled(false);
            GUIController.stopButtonEnabled(true);
            GUIController.updateAliveThreadsLabel(thrCount);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < threads.Count; i++)
            {
                Thread thrd = threads[i];
                thrd.Abort();
                threads.Remove(thrd);
            }

            GUIController.updateAliveThreadsLabel(threads.Count);
            GUIController.startButtonEnabled(true);
            GUIController.stopButtonEnabled(false);

        }


    }
}
