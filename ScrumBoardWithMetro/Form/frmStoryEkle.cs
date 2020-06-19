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
    public partial class frmStoryEkle : MetroFramework.Forms.MetroForm
    {
        public frmStoryEkle()
        {
            //frmMain frm = frmMain.GetInstance;
            InitializeComponent();
            /*List<UserProject> thisuserprojects = new List<UserProject>();
            thisuserprojects = SQLHelper.GetUserProjectsbyProject(frm.currentProject.ProjectID);
            combotxtStoryAuthor.Items.Clear();
            foreach (UserProject userproject in thisuserprojects)//so meto os projetos que estao ligados ao user q deu log, ou users ligados ao projeto
            {
                combotxtStoryAuthor.Items.Add(SQLHelper.GetUserbyID(userproject.UserID).UserName);
            }*/
        }
        
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            Button PB = new Button();
            List<PictureBoxInfo> Datas = SQLHelper.Select();
            Story StoryPass = new Story();
            frmMain frm = frmMain.GetInstance;
            Random Rnd = new Random();
            PB.BackColor = Color.FromArgb(Rnd.Next(0, 256), Rnd.Next(0, 256), Rnd.Next(0, 256));
            foreach (MetroFramework.Controls.MetroPanel Panel in frm.Controls.OfType<MetroFramework.Controls.MetroPanel>())
            {
                if (Panel.Name == "panel5")
                {
                    foreach (MetroFramework.Controls.MetroPanel Panels in Panel.Controls.OfType<MetroFramework.Controls.MetroPanel>())
                    {
                        if (Panels.Name == "pnlStory")
                        {
                            Panels.Refresh();
                            PB.Location = SQLHelper.GetLastRow(frm.currentSprint); //9,9
                        }
                    }
                }
            }
            
            PB.Location = SQLHelper.GetLastRow(frm.currentSprint);
            StoryPass.StoryLocationX = 5;
            StoryPass.StoryLocationY = PB.Location.Y + 10;
            StoryPass.Story_Color = PB.BackColor.GetHashCode().ToString();
            StoryPass.Story_Task_Count = 0;
            StoryPass.Story_Description = txtDescription.Text;
            StoryPass.Story_Name = txtStory_Name.Text;
            StoryPass.Story_AddDate = DateTime.Now.Date.ToString("dd/MM/yy");
            //StoryPass.Story_Author = combotxtStoryAuthor.Text;
            StoryPass.Story_Author = "";
            StoryPass.Sprint_ID = frm.currentSprint.Sprint_ID;
            SQLHelper.InsertStory(StoryPass);
            frm.RefreshEvent(null);
            this.Close();
            
        }

        

       /* private void btnadduser_Click(object sender, EventArgs e)
        {
            //incuir users atraves do mail
            //este user nao pode ja estar associado a este projeto
            Users newuser = SQLHelper.GetUserbyMail(tbnewusermail.Text);
            if(newuser != null)
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
                combotxtStoryAuthor.Items.Add(newuser.UserName);
                tbnewusermail.Text = "";
            }
            else
            {
                MetroMessageBox.Show(this, "Please give a valid mail!\n", "No User found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }*/
    }
}

