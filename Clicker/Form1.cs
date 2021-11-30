using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private Thread clickThread;
        private bool moreClicks;

        public Form1()
        {
            InitializeComponent();
        }

        public void DoMouseClick()
        {
            if (ActiveForm != null)
            {
                return;
            }

            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;

            if (rightClick.Checked)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)X, (uint)Y, 0, 0);
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)X, (uint)Y, 0, 0);
            }
        }

        public void Clicks()
        {
            while (moreClicks)
            {
                DoMouseClick();

                Thread.Sleep((int) threadSleepTime.Value);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;

            clickThread = new Thread(Clicks);
            moreClicks = true;

            clickThread.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            moreClicks = false;
            start.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            moreClicks = false;
        }
    }
}
