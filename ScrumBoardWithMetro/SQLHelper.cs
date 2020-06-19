using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows;
using ScrumBoardWithMetro.Forms;

namespace ScrumBoardWithMetro
{
    public class SQLHelper
    {
        private static string defaultConnectionString;
        public static void SQLStart(string _SqlConnectionString) => defaultConnectionString = _SqlConnectionString;
        public static bool InsertStory(Story S) 
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO Story(Story_Description,StoryLocationX,StoryLocationY,Story_Color,Story_Task_Count,Story_Name,Story_AddDate,Story_Author, Sprint_ID) VALUES ('" + S.Story_Description + "','" + S.StoryLocationX + "','" + S.StoryLocationY + "','" + S.Story_Color + "','" + S.Story_Task_Count + "','" + S.Story_Name + "','" + S.Story_AddDate + "','" + S.Story_Author + "','" + S.Sprint_ID + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static bool InsertTask(Task T) 
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO Task(Task_DeadLine,TaskLocationX,TaskLocationY,Task_Author,Task_Status,Task_Description,Story_ID,Task_Color,Task_Header) VALUES('" + T.Task_DeadLine + "','" + T.TaskLocationX + "','" + T.TaskLocationY + "','" + T.Task_Author + "','" + T.Task_Status + "','" + T.Task_Description + "','" + T.Story_ID + "','" + T.Task_BackColor + "','" + T.Task_Header + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static bool InsertSprint(Sprint T)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO Sprint(Sprint_Name,Sprint_Deadline,ProjectID) VALUES('" + T.Sprint_Name + "','" + T.Sprint_DeadLine + "','" + T.ProjectID + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static List<PictureBoxInfo> SelectSprint()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            List<PictureBoxInfo> PassValue = new List<PictureBoxInfo>();
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Sprint", Connect);

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PictureBoxInfo AddPB = new PictureBoxInfo();
                    AddPB.Sprint_ID = (int)reader["Sprint_ID"];
                    AddPB.Sprint_Name = (string)reader["Sprint_Name"];
                    AddPB.Sprint_DeadLine = (string)reader["Sprint_Deadline"];
                    AddPB.ProjectID = (int)reader["ProjectID"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }


        public static List<PictureBoxInfo> Select() 
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            List<PictureBoxInfo> PassValue = new List<PictureBoxInfo>();
            List<PictureBoxInfo> reallyPassValue = new List<PictureBoxInfo>();
            frmMain frm = frmMain.GetInstance;
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Story", Connect);

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PictureBoxInfo AddPB = new PictureBoxInfo();
                    AddPB.PB_BackColor = (reader["Story_Color"].ToString());
                    AddPB.PB_Size = new Size(140, 140);
                    AddPB.PB_Location = new Point((int)reader["StoryLocationX"], (int)reader["StoryLocationY"]);
                    AddPB.Story_ID = (int)reader["Story_ID"];
                    //AddPB.Story_Task_Count = (int)reader["Story_Task_Count"];
                    AddPB.Story_Description = (string)reader["Story_Description"];
                    AddPB.Story_Name = (string)reader["Story_Name"];
                    AddPB.Story_AddDate = (string)reader["Story_AddDate"];
                    AddPB.Story_Author = (string)reader["Story_Author"];
                    AddPB.Sprint_ID = (int)reader["Sprint_ID"];
                    //se a sprint nao for deste projeto nao inclui

                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                if (frm.currentProject != null)
                {

                    foreach(PictureBoxInfo content in PassValue)
                    {
                        if(GetSprintByID(content.Sprint_ID.ToString()).ProjectID == frm.currentProject.ProjectID)//
                        {
                            reallyPassValue.Add(content);
                        }
                    }
                return reallyPassValue;
                }
                else
                    return PassValue;

            }
            else
                return null;
        }

        public static List<PictureBoxInfo> SelectAllStorys()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            List<PictureBoxInfo> PassValue = new List<PictureBoxInfo>();
            frmMain frm = frmMain.GetInstance;
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Story", Connect);

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PictureBoxInfo AddPB = new PictureBoxInfo();
                    AddPB.PB_BackColor = (reader["Story_Color"].ToString());
                    AddPB.PB_Size = new Size(140, 140);
                    AddPB.PB_Location = new Point((int)reader["StoryLocationX"], (int)reader["StoryLocationY"]);
                    AddPB.Story_ID = (int)reader["Story_ID"];
                    //AddPB.Story_Task_Count = (int)reader["Story_Task_Count"];
                    AddPB.Story_Description = (string)reader["Story_Description"];
                    AddPB.Story_Name = (string)reader["Story_Name"];
                    AddPB.Story_AddDate = (string)reader["Story_AddDate"];
                    AddPB.Story_Author = (string)reader["Story_Author"];
                    AddPB.Sprint_ID = (int)reader["Sprint_ID"];

                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;

            }
            else
                return null;
        }

        public static List<PictureBoxInfo> SelectTask() 
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            List<PictureBoxInfo> PassValue = new List<PictureBoxInfo>();
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Task", Connect);

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PictureBoxInfo AddPB = new PictureBoxInfo();
                    AddPB.PB_BackColor = (reader["Task_Color"]).ToString();
                    AddPB.PB_Size = new Size(140, 28);
                    AddPB.PB_Location = new Point((int)reader["TaskLocationX"], (int)reader["TaskLocationY"]);
                    AddPB.Story_ID = (int)reader["Story_ID"];
                    AddPB.Task_ID = (int)reader["Task_ID"];
                    AddPB.Task_Status = (int)reader["Task_Status"];
                    AddPB.Task_Author = (string)reader["Task_Author"];
                    AddPB.Task_DeadLine = (string)reader["Task_DeadLine"];
                    AddPB.Task_DeadLine1 = Convert.ToDateTime(reader["Task_DeadLine"]);
                    AddPB.Task_Header = (string)reader["Task_Header"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        public static bool UpdateTask(int _Task_ID, int Status_Value)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("UPDATE Task SET Task_Status='" + Status_Value + "'WHERE Task_ID=@Task_ID", Connect);
                Cmd.Parameters.AddWithValue("@Task_ID", _Task_ID);
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return true;
            }
            else
                return false;
        }


        public static Point GetLastRow(Sprint currentSprint)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Point PassValue = Point.Empty;
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT TOP 1 * FROM Story WHERE Sprint_ID='" + currentSprint.Sprint_ID + "' ORDER BY Story_ID DESC", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PassValue = new Point((int)reader[2], (int)reader[3] + 140);

                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return Point.Empty;
        }

        public static Point GetLastRowTask(int Story_No)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Point PassValue = Point.Empty;
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT TOP 1 * FROM Task WHERE Story_ID='" + Story_No + "' ORDER BY Task_ID DESC", Connect); //From Task Olabilir
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    PassValue = new Point((int)reader[2], (int)reader[3] + 28);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return Point.Empty;
        }
        public static string GetTaskInfo(int Task_ID,int Story_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                string Task_Info = " ";
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT *FROM Story LEFT JOIN Task ON Task.Story_ID=Story.Story_ID", Connect); //From Task Olabilir

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    int story = Int32.Parse(reader["Story_ID"].ToString());
                    int sprintID = Int32.Parse(reader["Sprint_ID"].ToString());
                    if (Int32.Parse(reader["Story_Task_Count"].ToString()) > 0)
                    {
                        int task = Int32.Parse(reader["Task_ID"].ToString());
                        if (task == Task_ID || story == Story_ID)
                        {
                            Task_Info = " Story Name : " + (string)reader["Story_Name"] + "/ Task Header : " + (string)reader["Task_Header"] + "/ Story Description : " + (string)reader["Story_Description"] + "/ Task Author : " + reader["Task_Author"] + "/ Status : /" + reader["Task_Status"] + "/ Task Description : " + reader["Task_Description"] + "/ Task Dead Line : " + reader["Task_DeadLine"] + "/ Story Author : " + reader["Story_Author"] + "/ Story Start : " + reader["Story_AddDate"];
                            return Task_Info;
                        }
                    }
                    else
                    {
                        if (story == Story_ID)
                        {
                            Task_Info = " Story Name : " + (string)reader["Story_Name"] + "/ Task Header : " + "" + "/ Story Description : " + (string)reader["Story_Description"] + "/ Task Author : " + "" + "/ Status : /" + "" + "/ Task Description : " + "" + "/ Task Dead Line : " + "" + "/ Story Author : " + reader["Story_Author"] + "/ Story Start : " + reader["Story_AddDate"] + "/" + reader["Sprint_ID"];
                            return Task_Info;
                        }
                    }
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
            }
            return null;

        }


        public static void UpdateTaskCount(int Story_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                int Task_Count = 0;
                SqlCommand Cmd = new SqlCommand("SELECT *FROM Story WHERE Story_ID='" + Story_ID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((int)reader["Story_ID"] == Story_ID)
                    {
                        Task_Count = (int)reader["Story_Task_Count"];
                        Cmd = new SqlCommand("UPDATE Story SET Story_Task_Count='" + (Task_Count + 1) + "' WHERE Story_ID='" + Story_ID + "'", Connect);
                    }
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
            }
        }

        public static bool DeleteAllDB(int ProjectID) // elimar tudo dentro da sprint e não das outras
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("DELETE FROM Task", Connect);
                Cmd.ExecuteNonQuery();
                Cmd = new SqlCommand("DELETE FROM Story", Connect);
                Cmd.ExecuteNonQuery();
                Cmd = new SqlCommand("DELETE FROM Sprint WHERE ProjectID='" + ProjectID + "'", Connect);
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static bool DeleteTask(int Task_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("DELETE FROM Kimlik WHERE Task_ID=@Task_ID", Connect);
                Cmd.Parameters.AddWithValue("@Task_ID",Task_ID);
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return true;
            }
            else
                return false;

        }

        public static Sprint GetLastSprint()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT TOP 1 * FROM Sprint WHERE ProjectID='" + frmMain.GetInstance.currentProject.ProjectID + "' ORDER BY Sprint_ID DESC", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Sprint PassValue = new Sprint();
                while (reader.Read())
                {
                    PassValue.Sprint_ID = (int)reader["Sprint_ID"];
                    PassValue.Sprint_Name = (string)reader["Sprint_Name"];
                    PassValue.Sprint_DeadLine = (string)reader["Sprint_Deadline"];
                    PassValue.ProjectID = (int)reader["ProjectID"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static Sprint GetSprint(string Sprint_Name)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Sprint WHERE Sprint_Name='" + Sprint_Name + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Sprint PassValue = new Sprint();
                while (reader.Read())
                {
                    PassValue.Sprint_ID = (int)reader["Sprint_ID"];
                    PassValue.Sprint_Name = (string)reader["Sprint_Name"];
                    PassValue.Sprint_DeadLine = (string)reader["Sprint_Deadline"];
                    PassValue.ProjectID = (int)reader["ProjectID"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        
        public static List<Sprint> GetSprints()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Sprint", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                
                List < Sprint> PassValue = new List<Sprint>();
                while (reader.Read())
                {
                    Sprint prePassValue = new Sprint();
                    prePassValue.Sprint_ID = (int)reader["Sprint_ID"];
                    prePassValue.Sprint_Name = (string)reader["Sprint_Name"];
                    prePassValue.Sprint_DeadLine = (string)reader["Sprint_Deadline"];
                    prePassValue.ProjectID = (int)reader["ProjectID"];
                    PassValue.Add(prePassValue);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static Sprint GetSprintByID(string Sprint_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Sprint WHERE Sprint_ID='" + Sprint_ID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Sprint PassValue = new Sprint();
                while (reader.Read())
                {
                    PassValue.Sprint_ID = (int)reader["Sprint_ID"];
                    PassValue.Sprint_Name = (string)reader["Sprint_Name"];
                    PassValue.Sprint_DeadLine = (string)reader["Sprint_Deadline"];
                    PassValue.ProjectID = (int)reader["ProjectID"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static Story GetStoryByID(string Story_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Story WHERE Story_ID='" + Story_ID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Story PassValue = new Story();
                while (reader.Read())
                {
                    PassValue.Story_Description = (string)reader["Story_Description"];
                    PassValue.StoryLocationX = (int)reader["StoryLocationX"];
                    PassValue.StoryLocationY = (int)reader["StoryLocationY"];
                    PassValue.Story_Color = (string)reader["Story_Color"];
                    PassValue.Story_Task_Count = (int)reader["Story_Task_Count"];
                    PassValue.Story_Name = (string)reader["Story_Name"];
                    PassValue.Story_AddDate = (string)reader["Story_AddDate"];
                    PassValue.Story_Author = (string)reader["Story_Author"];
                    PassValue.Sprint_ID = (int)reader["Sprint_ID"];

                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        
        public static Task GetTaskByID(string Task_ID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Task WHERE Task_ID='" + Task_ID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Task PassValue = new Task();
                while (reader.Read())
                {
                    PassValue.Task_ID = (int)reader["Task_ID"];
                    PassValue.Task_DeadLine = (string)reader["Task_DeadLine"];
                    PassValue.TaskLocationX = (int)reader["TaskLocationX"];
                    PassValue.TaskLocationY = (int)reader["TaskLocationY"];
                    PassValue.Task_Author = (string)reader["Task_Author"];
                    PassValue.Task_Status = (int)reader["Task_Status"];
                    PassValue.Task_Description = (string)reader["Task_Description"];
                    PassValue.Story_ID = (int)reader["Story_ID"];
                    PassValue.Task_Header = (string)reader["Task_Header"];

                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static Users GetUser(string User_Name)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM [dbo].[User] WHERE UserName='" + User_Name + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Users PassValue = new Users();
                while (reader.Read())
                {
                    PassValue.UserID = (int)reader["UserID"];
                    PassValue.UserName = (string)reader["UserName"];
                    PassValue.UserPSW = (string)reader["UserPSW"];
                    PassValue.UserMail = (string)reader["UserMail"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        
        public static Users GetUserbyID(int UserID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM [dbo].[User] WHERE UserID='" + UserID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Users PassValue = new Users();
                while (reader.Read())
                {
                    PassValue.UserID = (int)reader["UserID"];
                    PassValue.UserName = (string)reader["UserName"];
                    PassValue.UserPSW = (string)reader["UserPSW"];
                    PassValue.UserMail = (string)reader["UserMail"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        
        public static Users GetUserbyMail(string UserMail)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM [dbo].[User] WHERE UserMail='" + UserMail + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Users PassValue = new Users();
                while (reader.Read())
                {
                    PassValue.UserID = (int)reader["UserID"];
                    PassValue.UserName = (string)reader["UserName"];
                    PassValue.UserPSW = (string)reader["UserPSW"];
                    PassValue.UserMail = (string)reader["UserMail"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static bool InsertUser(Users T)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[User](UserName,UserPSW,UserMail) VALUES('" + T.UserName + "','" + T.UserPSW + "','" + T.UserMail + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static bool InsertProject(Project T)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO [dbo].[Project](ProjectName) VALUES('" + T.ProjectName + "')", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
                Connect.Close();
                frmMain frmMain = frmMain.GetInstance;
                UserProject newuserproject = new UserProject();
                newuserproject.UserID = frmMain.currentUser.UserID;
                newuserproject.ProjectID = GetProject(T.ProjectName).ProjectID;
                InsertUserProject(newuserproject);//sp q se cria um projeto ja se deu log de um user, e esse registo esta na main
                return true;
            }
            else
                return false;
        }

        public static Project GetProject(string ProjectName)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Project WHERE ProjectName='" + ProjectName + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Project PassValue = new Project();
                while (reader.Read())
                {
                    PassValue.ProjectID = (int)reader["ProjectID"];
                    PassValue.ProjectName = (string)reader["ProjectName"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
       
        public static Project GetProjectbyID(int ProjectID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Project WHERE ProjectID='" + ProjectID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                Project PassValue = new Project();
                while (reader.Read())
                {
                    PassValue.ProjectID = (int)reader["ProjectID"];
                    PassValue.ProjectName = (string)reader["ProjectName"];
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static List<Project> GetProjects()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Project", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                List<Project> PassValue = new List<Project>();
                while (reader.Read())
                {
                    Project AddPB = new Project();
                    AddPB.ProjectID = (int)reader["ProjectID"];
                    AddPB.ProjectName = (string)reader["ProjectName"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static bool InsertUserProject(UserProject T)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("INSERT INTO UserProject(UserID,ProjectID) VALUES(" + T.UserID + "," + T.ProjectID +")", Connect);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return false;
                }
                Connect.Close();
                return true;
            }
            else
                return false;
        }

        public static List<UserProject> GetUserProjects()
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM UserProject", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                List<UserProject> PassValue = new List<UserProject>();
                while (reader.Read())
                {
                    UserProject AddPB = new UserProject();
                    AddPB.UserProjectID = (int)reader["UserProjectID"];
                    AddPB.UserID = (int)reader["UserID"];
                    AddPB.ProjectID = (int)reader["ProjectID"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }

        public static List<UserProject> GetUserProjectsbyUser(int UserID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM UserProject WHERE UserID='" + UserID + "'", Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                List<UserProject> PassValue = new List<UserProject>();
                while (reader.Read())
                {
                    UserProject AddPB = new UserProject();
                    AddPB.UserProjectID = (int)reader["UserProjectID"];
                    AddPB.UserID = (int)reader["UserID"];
                    AddPB.ProjectID = (int)reader["ProjectID"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }
        
        public static List<UserProject> GetUserProjectsbyProject(int ProjectID)
        {
            SqlConnection Connect = new SqlConnection(defaultConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
                SqlCommand Cmd = new SqlCommand("SELECT * FROM UserProject WHERE ProjectID=" + ProjectID, Connect);
                SqlDataReader reader = Cmd.ExecuteReader();
                List<UserProject> PassValue = new List<UserProject>();
                while (reader.Read())
                {
                    UserProject AddPB = new UserProject();
                    AddPB.UserProjectID = (int)reader["UserProjectID"];
                    AddPB.UserID = (int)reader["UserID"];
                    AddPB.ProjectID = (int)reader["ProjectID"];
                    PassValue.Add(AddPB);
                }
                reader.Close();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                return PassValue;
            }
            else
                return null;
        }



    }
}
