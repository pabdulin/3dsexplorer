using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace _3DSExplorer.Modules
{
    public partial class ProgressDialog : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get { return progressBar.Value; }
            set { progressBar.Value = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get { return progressBar.Maximum; }
            set { progressBar.Maximum = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Step
        {
            get { return progressBar.Step; }
            set { progressBar.Step = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        public event EventHandler CancelClicked
        {
            add { btnCancel.Click += value; }
            remove { btnCancel.Click -= value; }
        }

        public ProgressDialog(string title, int max)
        {
            InitializeComponent();
            Text = title;
            Maximum = max;
        }

        public void PerformStep()
        {
            progressBar.PerformStep();
        }

        private void ProgressDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCancel.PerformClick();
        }
    }
}
