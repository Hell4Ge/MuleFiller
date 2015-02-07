using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuleFiller
{
    public partial class PathPicker : UserControl
    {
        public PathPicker()
        {
            InitializeComponent();
        }

        private void BTN_PickPath_Click(object sender, EventArgs e)
        {
            var dr = openDiabloExec.ShowDialog();
            if (dr == DialogResult.OK)
                TB_Path.Text = openDiabloExec.FileName;
                
        }
    }
}
