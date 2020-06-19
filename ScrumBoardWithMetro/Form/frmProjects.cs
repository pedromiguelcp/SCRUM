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
    public partial class frmProjects : MetroFramework.Forms.MetroForm
    {
        private static frmProjects Instance;
        public Users currentUser;
        public string actualuser;
        public frmProjects()
        {

            InitializeComponent();
            frmLog frm1 = frmLog.GetInstance;
            frmMain frmMain1 = frmMain.GetInstance;
            actualuser = frm1.actualuser();
            if (actualuser != "")
                frm1.Close();
            else
                actualuser = frmMain1.currentUser.UserName;

            List<UserProject> thisuserprojects = new List<UserProject>();
            //List<string> projects = new List<string>();
            thisuserprojects = SQLHelper.GetUserProjectsbyUser(SQLHelper.GetUser(actualuser).UserID);
            comboProjectName.Items.Clear();
            foreach (UserProject userproject in thisuserprojects)//so meto os projetos que estao ligados ao user q deu log
            {
                //if (!projects.Contains(SQLHelper.GetProjectbyID(userproject.ProjectID).ProjectName))
                //{
                    comboProjectName.Items.Add(SQLHelper.GetProjectbyID(userproject.ProjectID).ProjectName);
                    //projects.Add(SQLHelper.GetProjectbyID(userproject.ProjectID).ProjectName);
                //}
            }
            
            //agora tenho de ir buscar todas as tasks que estão ligadas a um user

            //primeiro tenho de ir buscar todos os projetos ligados ao user -done
            //dps tenho de ir buscar todas as sprints ligadas aos projeto   -done
            //dps acedo a todas a storys através das sprints                -done
            //dps vejo a data de cada uma das tasks                         -done

            List<Sprint> usersprints = new List<Sprint>();
            foreach(Sprint sprint in SQLHelper.GetSprints())
            {
                foreach(UserProject userproject in thisuserprojects)
                {
                    if (sprint.ProjectID == userproject.ProjectID && !usersprints.Contains(sprint))
                    {
                        usersprints.Add(sprint);
                    }
                }
            }

            List<PictureBoxInfo> userstorys = new List<PictureBoxInfo>();
            foreach (PictureBoxInfo story in SQLHelper.SelectAllStorys())
            {
                foreach (Sprint sprint in usersprints)
                { 
                    if (story.Sprint_ID == sprint.Sprint_ID && !userstorys.Contains(story))
                    {
                        userstorys.Add(story);
                    }
                }
            }

            List<PictureBoxInfo> usertasks = new List<PictureBoxInfo>();
            foreach (PictureBoxInfo task in SQLHelper.SelectTask())
            {
                foreach (PictureBoxInfo story in userstorys)
                {
                    if (task.Story_ID == story.Story_ID && !usertasks.Contains(task))
                    {
                        if(task.Task_Author == actualuser && task.Task_Status != 2)
                            usertasks.Add(task);
                    }
                }
            }

            DateTime today = new DateTime();
            today = DateTime.Today;
            List<PictureBoxInfo> priousertasks = new List<PictureBoxInfo>();
            pnlpriotasks.Controls.Clear();
            Point location = new Point();
            location.X = 0;
            location.Y = 0;
            foreach (PictureBoxInfo task in usertasks)
            {
                if ((task.Task_DeadLine1 - today).TotalDays < 3)
                {
                    priousertasks.Add(task);
                    Button PB = new Button();
                    PB.Margin = new Padding(0);
                    PB.Font = new Font("Arial", 10, FontStyle.Regular);
                    PB.Size = task.PB_Size;
                    PB.BackColor = Color.FromArgb(Int32.Parse(task.PB_BackColor));
                    PB.Tag = task.Task_ID;
                    PB.Text = task.Task_Header;
                    PB.ForeColor = Color.White;
                    PB.MouseDown += Task_RightClicked;
                    PB.Location = location;
                    location.Y += 30; 
                    pnlpriotasks.Controls.Add(PB);
                }
            }


            ProjectNameNew.Text = "";
        }

        public static frmProjects GetInstance
        {
            get
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new frmProjects();
                }
                return Instance;
            }
        }

        private void Task_RightClicked(object sender, MouseEventArgs e)
        {
            string[] R;
            string status = "";
            Task mytask = new Task();
            Story mystory = new Story();
            Sprint mysprint = new Sprint();
            Project myproject = new Project();
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(SenderValue, 0).Split('/');
                if (R[5] == "0")
                    status = "Not started";
                else if (R[5] == "1")
                    status = "In progress";


                //falta dizer qual é o projeto associado
                mytask = SQLHelper.GetTaskByID(SenderValue.ToString());
                mystory = SQLHelper.GetStoryByID(mytask.Story_ID.ToString());
                mysprint = SQLHelper.GetSprintByID(mystory.Sprint_ID.ToString());
                myproject = SQLHelper.GetProjectbyID(mysprint.ProjectID);
                MetroMessageBox.Show(this, "" + " Project: " + myproject.ProjectName + "\n" + R[0] + "\n " + "Status: " + status + "\n" + R[1] + "\n" + R[3] + "\n" + R[7] + "/" + R[8] + "/" + R[9].Substring(0, 4), "TASK Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnterProject_Click(object sender, EventArgs e)
        {
            frmMain frm = frmMain.GetInstance;
            if (comboProjectName.Text == "")
            {
                MetroMessageBox.Show(this, "Please select a Project!\n", "No Project selected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Project Project = SQLHelper.GetProject(comboProjectName.Text);
                if (Project == null)
                {
                    MetroMessageBox.Show(this, "Please select a valid Project!\n", "No Project Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //dá o log e vai para a pagina scrum board, fecha esta janela

                    frm.currentProject = Project;
                    this.Close();
                    frm.RefreshEvent(null);
                    frm.Show();
                    frm.Focus();
                }

            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Project ProjectPass = new Project();
            ProjectPass.ProjectName = ProjectNameNew.Text;
            SQLHelper.InsertProject(ProjectPass);
            ProjectNameNew.Text = "";
            /*comboProjectName.Items.Clear();
            foreach (Project Sprint in SQLHelper.GetProjects())
            {
                comboProjectName.Items.Add(Sprint.ProjectName);
            }*/
            List<UserProject> thisuserprojects = new List<UserProject>();
            //List<string> projects = new List<string>();
            thisuserprojects = SQLHelper.GetUserProjectsbyUser(SQLHelper.GetUser(actualuser).UserID);
            comboProjectName.Items.Clear();
            foreach (UserProject userproject in thisuserprojects)//so meto os projetos que estao ligados ao user q deu log
            {
                //if (!projects.Contains(SQLHelper.GetProjectbyID(userproject.ProjectID).ProjectName))
                //{
                comboProjectName.Items.Add(SQLHelper.GetProjectbyID(userproject.ProjectID).ProjectName);
                //projects.Add(SQLHelper.GetProjectbyID(userproject.ProjectID).ProjectName);
                //}
            }
            this.Refresh();
        }
    }
}
