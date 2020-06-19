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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private static frmMain Instance; //Singleton
        public Sprint currentSprint;
        public Project currentProject;
        public Users currentUser;
        public frmMain()
        {
            InitializeComponent();
            //SQLHelper.SQLStart("Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=ScrumTableDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public static frmMain GetInstance
        {
            get
            {
                if (Instance == null || Instance.IsDisposed)
                {
                    Instance = new frmMain(); 
                }
                return Instance;
            }
        }

        Button MouseDownPB;
        void panel_DragDrop(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (MetroFramework.Controls.MetroPanel)sender;
            if (((MetroFramework.Controls.MetroPanel)sender) == pnlNotStarted)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 0);
            }
            else if (((Panel)sender) == pnlInProgress)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 1);
            }
            else if (((Panel)sender) == pnlDone)
            {
                SQLHelper.UpdateTask((int)(MouseDownPB.Tag), 2);
            }
        }

        void panel_DragDropStory(object sender, DragEventArgs e)
        {
            ((Button)e.Data.GetData(typeof(Button))).Parent = (MetroFramework.Controls.MetroPanel)sender;
            if (((MetroFramework.Controls.MetroPanel)sender) == pnlStory)
            {
                //SQLHelper.UpdateStory((int)(MouseDownPB.Tag), 0);
            }
            else if (((Panel)sender) == metroBacklog)
            {
                //SQLHelper.UpdateStory((int)(MouseDownPB.Tag), 1);
            }
        }

        void AllPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                 MouseDownPB = (sender as Button);
                ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Move);
            }
            string[] R;
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(SenderValue, 0).Split('/');
                switch (R[5])
                {
                    case "0":
                        Status = " Not Started ";
                        break;
                    case "1":
                        Status = " In Progress ";
                        break;
                    case "2":
                        Status = " Done! ";
                        break;
                    default:
                        break;
                }
                MetroMessageBox.Show(this, "" + R[0] + "\n" + R[1] + "\n" + R[3] + "\n Task Status : " + Status + "\n" + R[6] + "\n" + R[7] + "/" + R[8] + "/" + R[9].Substring(0, 4), "TASK Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        public void RefreshEvent(Sprint current)
        {
            ClearPanelEvent();
            btnProject.Text = currentProject.ProjectName;
            btnUser.Text = currentUser.UserName;
            if (current == null)
            {
                currentSprint = SQLHelper.GetLastSprint();
                if (currentSprint != null)
                    //metroTileSprint.Text = currentSprint.Sprint_Name;
                    btnSprint.Text = currentSprint.Sprint_Name;
                else
                    //metroTileSprint.Text = "No Sprint";
                    btnSprint.Text = "No Sprint";

            }
            else
            {
                currentSprint = current;
                //metroTileSprint.Text = currentSprint.Sprint_Name;
                btnSprint.Text = currentSprint.Sprint_Name;
            }

            List<int> storysIDs = new List<int>();
            List<PictureBoxInfo> Datas = SQLHelper.Select();
            foreach (PictureBoxInfo PBDatas in Datas)
            { 
                if(PBDatas.Sprint_ID == currentSprint.Sprint_ID)
                {
                    storysIDs.Add(PBDatas.Story_ID);
                    Button PB = new Button();

                    PB.Margin = new Padding(0);
                    PB.Font = new Font("Arial", 10, FontStyle.Regular);
                    PB.Size = PBDatas.PB_Size;
                    PB.MouseDown += Story_RightClicked;
                    PB.BackColor = Color.FromArgb(Int32.Parse(PBDatas.PB_BackColor));
                    pnlStory.Controls.Add(PB);
                    PB.Location = PBDatas.PB_Location;
                    PB.Tag = PBDatas.Story_ID;
                    PB.Text = "Name:"+PBDatas.Story_Name+"\nDate:"+PBDatas.Story_AddDate+ "\nDesc:" + PBDatas.Story_Description;
                    PB.ForeColor = Color.Black;
                }

            }

            List<PictureBoxInfo> Datam = SQLHelper.SelectTask();//.Where(c => c.Story_ID == 2).ToList();
            foreach (PictureBoxInfo PBData in Datam)
            {
                if (storysIDs.Contains(PBData.Story_ID))
                {
                    Button PB = new Button();
                    PB.Margin = new Padding(0);
                    PB.Font = new Font("Arial", 10, FontStyle.Regular);
                    PB.Size = PBData.PB_Size;
                    PB.BackColor = Color.FromArgb(Int32.Parse(PBData.PB_BackColor));
                    PB.Tag = PBData.Task_ID;
                    PB.DragDrop += panel_DragDrop;
                    PB.MouseDown += AllPB_MouseDown;
                    PB.Text = PBData.Task_Header;
                    PB.ForeColor = Color.Black;
                    switch (PBData.Task_Status)
                    {
                        case 0:
                            pnlNotStarted.Controls.Add(PB);
                     
                            break;
                        case 1:
                            pnlInProgress.Controls.Add(PB);
                        
                            break;
                        case 2:
                            pnlDone.Controls.Add(PB);
              
                            break;
                        default:
                            break;
                    }
                    PB.Location = PBData.PB_Location;
                }
            }
            
            pnlNotStarted.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            pnlInProgress.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            pnlDone.Size = new Size(pnlNotStarted.Size.Width, panel5.Size.Height);
            Point location = new Point();
            location.X = 5;
            location.Y = 10;
            Datas = Datas.OrderBy(arentim => arentim.Sprint_ID).Reverse().ToList();
            foreach (PictureBoxInfo PBDatas in Datas)
            {
                storysIDs.Add(PBDatas.Story_ID);
                Button PB1 = new Button();

                PB1.Margin = new Padding(0);
                PB1.Font = new Font("Arial", 10, FontStyle.Regular);
                PB1.Size = PBDatas.PB_Size;
                PB1.MouseDown += Story_RightClicked;
                PB1.BackColor = Color.FromArgb(Int32.Parse(PBDatas.PB_BackColor));
                PB1.DragDrop += panel_DragDropStory;
                PB1.MouseDown += AllPB_MouseDown;

                metroBacklog.Controls.Add(PB1);

                PB1.Location = location;
                PB1.Tag = PBDatas.Story_ID;
                PB1.Text = "Name:" + PBDatas.Story_Name + "\nDate:" + PBDatas.Story_AddDate + "\n" + SQLHelper.GetSprintByID(SQLHelper.GetStoryByID(PBDatas.Story_ID.ToString()).Sprint_ID.ToString()).Sprint_Name;
                PB1.ForeColor = Color.Black;
                location.Y += 150;
            }
        }

        public void ClearPanelEvent()
        {
            pnlStory.Controls.Clear();
            metroBacklog.Controls.Clear();
            pnlNotStarted.Controls.Clear();
            pnlInProgress.Controls.Clear();
            pnlDone.Controls.Clear();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        string Status;
        
        private void Story_RightClicked(object sender, MouseEventArgs e)
        {
            string[] R;
            if (e.Button == MouseButtons.Right)
            {
                int SenderValue = (int)((Button)sender).Tag;
                R = SQLHelper.GetTaskInfo(0, SenderValue).Split('/');
                //if(R[13] == currentSprint.Sprint_ID.ToString())
                MetroMessageBox.Show(this, "" + R[0] + "\n" + R[2] + "\n" + R[8] + "\n" + R[9] + "\n " + SQLHelper.GetSprintByID(R[12]).Sprint_Name + "\n", "STORY Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                   // MetroMessageBox.Show(this, "" + R[0] + "\n" + R[2] + "\n" + R[8] + "\n" + R[9] + "\n", "STORY Infomation", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
        }
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            frmStoryEkle frm = new frmStoryEkle();
            frm.Show();
        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            frmTaskEkle frm = new frmTaskEkle();
            frm.Show();
        }
        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            DialogResult Ans=MetroMessageBox.Show(this, "\n\nAre you sure you want to delete the entire contents of the SCRUM board?", "Delete all?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (Ans == DialogResult.Yes)
            {
                SQLHelper.DeleteAllDB(currentProject.ProjectID);
                RefreshEvent(null);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            RefreshEvent(null);
           
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a software with the objective of supporting a SCRUM environment in academic projects.\n", "SCRUM board purpose ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSprint_Click(object sender, EventArgs e)
        {
            frmSprint frm = new frmSprint();
            frm.Show();
        }

        private void metroTileSprint_Click(object sender, EventArgs e)
        {
            frmSprint frm = new frmSprint();
            frm.Show();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            //voltar para o menu dos projetos
            frmProjects frm1 = new frmProjects();

            frm1.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser includeUser = new frmAddUser();
            includeUser.Show();
        }
    }
}
//mostrar só as priority tasks do user q deu log -done
//meter a dar add a pessoas ao lado do projeto   -done
//melhorar o voltar ao menu de projetos          -done
//meter o nome do user que deu log               -done
//priority tasks -> projeto associado e status   -done
//meter a ver as pessoas que estão associadas ao projeto ?