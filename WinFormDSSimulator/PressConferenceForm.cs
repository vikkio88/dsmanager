using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDSSimulator
{
    public partial class PressConferenceForm : Form
    {
        public PressConferenceForm()
        {
            InitializeComponent();
        }

        private void PressConferenceForm_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
