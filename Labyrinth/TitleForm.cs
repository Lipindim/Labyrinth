using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MasterForm _masterForm = new MasterForm();
            _masterForm.ShowDialog();
        }

        private void cbIsSound_CheckedChanged(object sender, EventArgs e)
        {
            PlaySound.MusicOn = cbIsSound.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
