using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLStudio_THHQT.GUI
{
    public partial class background : Form
    {
        public background()
        {
            frmMain f = new frmMain();
            f.ShowDialog();
            InitializeComponent();
        }

        private void background_Load(object sender, EventArgs e)
        {
        }
    }
}
