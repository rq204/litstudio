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
    internal partial class FrmProject : Form
    {
        private litsdk.Project Project = null;
        public FrmProject(litsdk.Project project)
        {
            InitializeComponent();
            this.Project = project;
            if (this.Project.StartVars != null && this.Project.StartVars.Count > 0)
            {
                this.svApiVariables.VarNames = this.Project.StartVars;
            }
            if (this.Project.ReturnVars != null && this.Project.ReturnVars.Count > 0)
            {
                this.svApiReturn.VarNames = this.Project.ReturnVars;
            }
            if (this.Project.Notes != null) this.tbNotes.Text = this.Project.Notes;
            this.svApiVariables.ShowVarName(true, false, true);
            this.svApiReturn.ShowVarName(true, true, true, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Project.Notes = this.tbNotes.Text.Trim();
            this.Project.StartVars = this.svApiVariables.VarNames;
            this.Project.ReturnVars = this.svApiReturn.VarNames;
            this.DialogResult = DialogResult.OK;
        }
    }
}
