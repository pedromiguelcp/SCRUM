namespace ScrumBoardWithMetro
{
    partial class frmProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ProjectNameNew = new MetroFramework.Controls.MetroTextBox();
            this.btnEnterProject = new MetroFramework.Controls.MetroTile();
            this.btnAddProject = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.ProjectName = new MetroFramework.Controls.MetroTextBox();
            this.pnlpriotasks = new MetroFramework.Controls.MetroPanel();
            this.comboProjectName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 0;
            // 
            // ProjectNameNew
            // 
            // 
            // 
            // 
            this.ProjectNameNew.CustomButton.Image = null;
            this.ProjectNameNew.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.ProjectNameNew.CustomButton.Name = "";
            this.ProjectNameNew.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.ProjectNameNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProjectNameNew.CustomButton.TabIndex = 1;
            this.ProjectNameNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProjectNameNew.CustomButton.UseSelectable = true;
            this.ProjectNameNew.CustomButton.Visible = false;
            this.ProjectNameNew.Lines = new string[0];
            this.ProjectNameNew.Location = new System.Drawing.Point(162, 216);
            this.ProjectNameNew.MaxLength = 32767;
            this.ProjectNameNew.Multiline = true;
            this.ProjectNameNew.Name = "ProjectNameNew";
            this.ProjectNameNew.PasswordChar = '\0';
            this.ProjectNameNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProjectNameNew.SelectedText = "";
            this.ProjectNameNew.SelectionLength = 0;
            this.ProjectNameNew.SelectionStart = 0;
            this.ProjectNameNew.ShortcutsEnabled = true;
            this.ProjectNameNew.Size = new System.Drawing.Size(200, 31);
            this.ProjectNameNew.TabIndex = 9;
            this.ProjectNameNew.UseSelectable = true;
            this.ProjectNameNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectNameNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEnterProject
            // 
            this.btnEnterProject.ActiveControl = null;
            this.btnEnterProject.Location = new System.Drawing.Point(207, 270);
            this.btnEnterProject.Name = "btnEnterProject";
            this.btnEnterProject.Size = new System.Drawing.Size(50, 34);
            this.btnEnterProject.TabIndex = 8;
            this.btnEnterProject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnterProject.TileImage = ((System.Drawing.Image)(resources.GetObject("btnEnterProject.TileImage")));
            this.btnEnterProject.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnterProject.UseSelectable = true;
            this.btnEnterProject.UseTileImage = true;
            this.btnEnterProject.Click += new System.EventHandler(this.btnEnterProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.ActiveControl = null;
            this.btnAddProject.Location = new System.Drawing.Point(368, 216);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(37, 31);
            this.btnAddProject.TabIndex = 6;
            this.btnAddProject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProject.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddProject.TileImage")));
            this.btnAddProject.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProject.UseSelectable = true;
            this.btnAddProject.UseTileImage = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(24, 184);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "New Project";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(19, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = " Name";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.Red;
            this.metroLabel7.Location = new System.Drawing.Point(23, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Select Project";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel8.Location = new System.Drawing.Point(23, 114);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Name";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // ProjectName
            // 
            // 
            // 
            // 
            this.ProjectName.CustomButton.Image = null;
            this.ProjectName.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.ProjectName.CustomButton.Name = "";
            this.ProjectName.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.ProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProjectName.CustomButton.TabIndex = 1;
            this.ProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProjectName.CustomButton.UseSelectable = true;
            this.ProjectName.CustomButton.Visible = false;
            this.ProjectName.Lines = new string[0];
            this.ProjectName.Location = new System.Drawing.Point(0, 0);
            this.ProjectName.MaxLength = 32767;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.PasswordChar = '\0';
            this.ProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProjectName.SelectedText = "";
            this.ProjectName.SelectionLength = 0;
            this.ProjectName.SelectionStart = 0;
            this.ProjectName.ShortcutsEnabled = true;
            this.ProjectName.Size = new System.Drawing.Size(0, 22);
            this.ProjectName.TabIndex = 0;
            this.ProjectName.UseSelectable = true;
            this.ProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlpriotasks
            // 
            this.pnlpriotasks.AllowDrop = true;
            this.pnlpriotasks.AutoSize = true;
            this.pnlpriotasks.BackColor = System.Drawing.Color.Transparent;
            this.pnlpriotasks.HorizontalScrollbarBarColor = true;
            this.pnlpriotasks.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlpriotasks.HorizontalScrollbarSize = 10;
            this.pnlpriotasks.Location = new System.Drawing.Point(487, 52);
            this.pnlpriotasks.Margin = new System.Windows.Forms.Padding(0);
            this.pnlpriotasks.Name = "pnlpriotasks";
            this.pnlpriotasks.Size = new System.Drawing.Size(132, 252);
            this.pnlpriotasks.TabIndex = 1;
            this.pnlpriotasks.UseCustomBackColor = true;
            this.pnlpriotasks.VerticalScrollbarBarColor = true;
            this.pnlpriotasks.VerticalScrollbarHighlightOnWheel = false;
            this.pnlpriotasks.VerticalScrollbarSize = 10;
            // 
            // comboProjectName
            // 
            this.comboProjectName.ItemHeight = 23;
            this.comboProjectName.Location = new System.Drawing.Point(162, 110);
            this.comboProjectName.MaxLength = 32767;
            this.comboProjectName.Name = "comboProjectName";
            this.comboProjectName.Size = new System.Drawing.Size(200, 29);
            this.comboProjectName.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboProjectName.TabIndex = 1;
            this.comboProjectName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboProjectName.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(487, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Priority tasks";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 318);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.comboProjectName);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pnlpriotasks);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnEnterProject);
            this.Controls.Add(this.ProjectNameNew);
            this.MaximizeBox = false;
            this.Name = "frmProjects";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "SCRUM Board Projects";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox ProjectNameNew;
        private MetroFramework.Controls.MetroTile btnEnterProject;
        private MetroFramework.Controls.MetroTile btnAddProject;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel pnlpriotasks;
        private MetroFramework.Controls.MetroTextBox ProjectName;
        private MetroFramework.Controls.MetroComboBox comboProjectName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}