using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litstudio
{
    internal partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
            this.cbAutoSave.Checked = Option.option.AutoSave;
        }

        private void cbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            Option.option.AutoSave = this.cbAutoSave.Checked;
            Option.Save();
        }
    }
}
