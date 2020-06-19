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
    public partial class frmLog : MetroFramework.Forms.MetroForm
    {
        private static frmLog Instance;
        public Users currentUser;
        public frmLog()
        {
            
            InitializeComponent();
            LogInNameNew.Text = "";
            LogInPSWNew.Text = "";
            LogInName.Text = "";
            LogInPSW.Text = "";

        }

        public static frmLog GetInstance
        {
            get
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new frmLog();
                }
                return Instance;
            }
        }
        private void btnLogIN_Click(object sender, EventArgs e)
        {
            
            
            if (LogInName.Text == "")
            {
                MetroMessageBox.Show(this, "Please select the User details!\n", "No User Details!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Users LogUser = SQLHelper.GetUser(LogInName.Text);
                if(LogUser == null || LogUser.UserPSW != LogInPSW.Text)
                {
                    MetroMessageBox.Show(this, "Please select a valid User!\n", "No User Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    frmMain frm1 = frmMain.GetInstance;//dá o log e vai para a pagina dos projetos, fecha esta janela
                    frm1.currentUser = LogUser;
                    frmProjects frm = frmProjects.GetInstance;
                    frm.currentUser = LogUser;
                    currentUser = LogUser;
                    //this.Close();
                    frm.Show();
                    frm.Focus();
                }

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Users UserPass = new Users();
            UserPass.UserName = LogInNameNew.Text;
            UserPass.UserPSW = LogInPSWNew.Text;
            UserPass.UserMail = tbnewmail.Text;
            SQLHelper.InsertUser(UserPass);
            LogInNameNew.Text = "";
            LogInPSWNew.Text = "";
            LogInName.Text = "";
            LogInPSW.Text = "";
            tbnewmail.Text = "";
            this.Refresh();
        }

        public string actualuser()
        {
            return LogInName.Text;
        }
    }
}
