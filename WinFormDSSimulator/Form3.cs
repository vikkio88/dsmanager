using DsManager.Models;
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
    public partial class FixtureForm : Form
    {
       
        public FixtureForm()
        {
            InitializeComponent();
        }

        private void FixtureForm_Load(object sender, EventArgs e)
        {
            txtFixture.Text = MainForm.l.getStringFixture();
        }

    }
}
