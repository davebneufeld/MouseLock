using System;
using System.Windows.Forms;

namespace MouseLock
{
    public partial class MouseLockForm : Form
    {

        public MouseLockForm()
        {
            InitializeComponent();
            eventProvider.Enabled = false;
            label.Text = "Unlocked";
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(eventProvider.Enabled)
                Unlock();
            else
            {
                Lock();
            }
        }

        private void Lock()
        {
            eventProvider.Enabled = true;
            label.Text = "Locked";

        }

        private void Unlock()
        {
            eventProvider.Enabled = false;
            label.Text = "Unlocked";
        }

        private void event_MouseMoveExt(object sender, MouseKeyboardActivityMonitor.MouseEventExtArgs e)
        {
            e.Handled = true;
        }


    }
}
