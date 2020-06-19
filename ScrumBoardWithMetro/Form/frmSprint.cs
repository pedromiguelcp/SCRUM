using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using ScrumBoardWithMetro.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Windows;

namespace ScrumBoardWithMetro
{
    public partial class frmSprint : MetroFramework.Forms.MetroForm
    {
frmMain frm = frmMain.GetInstance;
        public frmSprint()
        {
            
            InitializeComponent();
            foreach (PictureBoxInfo Sprint in SQLHelper.SelectSprint())
            {
                if(Sprint.ProjectID == frm.currentProject.ProjectID)
                {
                    comborole.Items.Add(Sprint.Sprint_Name);
                    metroLabel10.Text = frm.currentSprint.Sprint_Name;
                    metroLabel11.Text = frm.currentSprint.Sprint_DeadLine.Substring(0, 9);
                }
            }
        }

        private void btnAddSprint_Click(object sender, EventArgs e)
        {
            Sprint SprintPass = new Sprint();
            SprintPass.Sprint_Name = sprint_Name.Text;
            SprintPass.Sprint_DeadLine = SprintDeadLine.Value.ToString();
            SprintPass.ProjectID = frm.currentProject.ProjectID;
            SQLHelper.InsertSprint(SprintPass);
            comborole.Items.Add(sprint_Name.Text);
            sprint_Name.Text = "";
            this.Refresh();
        }

        private void btnEnterSprint_Click(object sender, EventArgs e)
        {
            frmMain frm = frmMain.GetInstance;
            if(comborole.Text == "")
            {
                MetroMessageBox.Show(this, "Please select the current sprint!\n", "No sprint selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frm.RefreshEvent(SQLHelper.GetSprint(comborole.Text));
            this.Close();
        }

        private void comborole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sprint newSprint = SQLHelper.GetSprint(comborole.Text);
            metroLabel10.Text = newSprint.Sprint_Name;
            metroLabel11.Text = newSprint.Sprint_DeadLine.Substring(0, 9);
        }
    }
}
