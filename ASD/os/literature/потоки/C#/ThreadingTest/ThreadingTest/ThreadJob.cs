using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingTest
{
    public class ThreadArgs : EventArgs
    {
        public bool isSuccess;
        public ThreadArgs(bool success)
        {
            isSuccess = success;
        }
    }

    class ThreadJob
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        public event EventHandler ThreadCompleted;
        public void Job()
        {
            GUIController.appendLog(Thread.CurrentThread.Name, "Started!");

            int s = random.Next(3, 20);
            GUIController.appendLog(Thread.CurrentThread.Name, "Sleep " + s + " seconds.");
            Thread.Sleep(s * 1000);

            
            GUIController.appendLog(Thread.CurrentThread.Name, "Done, exiting");

            
            if (ThreadCompleted != null)
            {
                ThreadCompleted(Thread.CurrentThread, new ThreadArgs( (random.Next(0, 2) == 0) ? true : false));
            }
        }
    }
}
