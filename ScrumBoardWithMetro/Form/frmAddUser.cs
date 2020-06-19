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
    public partial class frmAddUser : MetroFramework.Forms.MetroForm
    {
        private static frmAddUser Instance;
        public Users currentUser;
        public frmAddUser()
        {

            InitializeComponent();
            frmMain frm = frmMain.GetInstance;
            List<UserProject> thisuserprojects = new List<UserProject>();
            thisuserprojects = SQLHelper.GetUserProjectsbyProject(frm.currentProject.ProjectID);
            pnlUsers.Controls.Clear();
            Point location = new Point();
            location.X = 23;
            location.Y = 0;
            foreach (UserProject userproject in thisuserprojects)
            {
                Button PB = new Button();
                Label LB = new Label();
                PB.Margin = new Padding(0);
                PB.Font = new Font("Arial", 10, FontStyle.Regular);
                PB.BackColor = Color.Black;
                PB.Text = SQLHelper.GetUserbyID(userproject.UserID).UserName;
                PB.ForeColor = Color.White;
                PB.Location = location;

                LB.Margin = new Padding(0);
                LB.Font = new Font("Arial", 10, FontStyle.Regular);
                //LB.BackColor = Color.Nonn;
                LB.Text = SQLHelper.GetUserbyID(userproject.UserID).UserName;
                LB.ForeColor = Color.White;
                LB.Location = location;

                location.Y += 20;
                pnlUsers.Controls.Add(LB);
            }

        }

        public static frmAddUser GetInstance
        {
            get
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new frmAddUser();
                }
                return Instance;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //incuir users atraves do mail
            //este user nao pode ja estar associado a este projeto

            //escrever mensagem a dizer quem foi adicionado

            Users newuser = SQLHelper.GetUserbyMail(AddMail.Text);
            if (newuser.UserName != null)
            {
                frmMain frm = frmMain.GetInstance;
                List<UserProject> thisuserprojects = new List<UserProject>();
                thisuserprojects = SQLHelper.GetUserProjectsbyProject(frm.currentProject.ProjectID);
                foreach (UserProject userproject in thisuserprojects)//so meto os projetos que estao ligados ao user q deu log, ou users ligados ao projeto
                {
                    if (userproject.ProjectID == frm.currentProject.ProjectID && userproject.UserID == newuser.UserID)
                    {
                        MetroMessageBox.Show(this, "User already in this project!\n", "User found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                UserProject userproject1 = new UserProject();
                userproject1.UserID = newuser.UserID;
                userproject1.ProjectID = frm.currentProject.ProjectID;
                SQLHelper.InsertUserProject(userproject1);
                AddMail.Text = "";
                MetroMessageBox.Show(this, "New user added to the project!\n", "User added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MetroMessageBox.Show(this, "Please give a valid mail!\n", "No User found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
