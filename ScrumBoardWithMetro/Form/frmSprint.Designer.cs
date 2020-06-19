namespace ScrumBoardWithMetro
{
    partial class frmSprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSprint));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sprint_Name = new MetroFramework.Controls.MetroTextBox();
            this.SprintDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.comborole = new MetroFramework.Controls.MetroComboBox();
            this.btnEnterSprint = new MetroFramework.Controls.MetroTile();
            this.btnAddSprint = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 0;
            // 
            // sprint_Name
            // 
            // 
            // 
            // 
            this.sprint_Name.CustomButton.Image = null;
            this.sprint_Name.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.sprint_Name.CustomButton.Name = "";
            this.sprint_Name.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.sprint_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sprint_Name.CustomButton.TabIndex = 1;
            this.sprint_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sprint_Name.CustomButton.UseSelectable = true;
            this.sprint_Name.CustomButton.Visible = false;
            this.sprint_Name.Lines = new string[0];
            this.sprint_Name.Location = new System.Drawing.Point(161, 385);
            this.sprint_Name.MaxLength = 32767;
            this.sprint_Name.Multiline = true;
            this.sprint_Name.Name = "sprint_Name";
            this.sprint_Name.PasswordChar = '\0';
            this.sprint_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sprint_Name.SelectedText = "";
            this.sprint_Name.SelectionLength = 0;
            this.sprint_Name.SelectionStart = 0;
            this.sprint_Name.ShortcutsEnabled = true;
            this.sprint_Name.Size = new System.Drawing.Size(200, 31);
            this.sprint_Name.TabIndex = 9;
            this.sprint_Name.UseSelectable = true;
            this.sprint_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sprint_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SprintDeadLine
            // 
            this.SprintDeadLine.Location = new System.Drawing.Point(161, 422);
            this.SprintDeadLine.MinimumSize = new System.Drawing.Size(0, 29);
            this.SprintDeadLine.Name = "SprintDeadLine";
            this.SprintDeadLine.Size = new System.Drawing.Size(200, 29);
            this.SprintDeadLine.TabIndex = 7;
            // 
            // comborole
            // 
            this.comborole.ItemHeight = 23;
            this.comborole.Location = new System.Drawing.Point(161, 268);
            this.comborole.MaxLength = 32767;
            this.comborole.Name = "comborole";
            this.comborole.Size = new System.Drawing.Size(200, 29);
            this.comborole.Style = MetroFramework.MetroColorStyle.Blue;
            this.comborole.TabIndex = 1;
            this.comborole.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comborole.UseSelectable = true;
            this.comborole.SelectedIndexChanged += new System.EventHandler(this.comborole_SelectedIndexChanged);
            // 
            // btnEnterSprint
            // 
            this.btnEnterSprint.ActiveControl = null;
            this.btnEnterSprint.Location = new System.Drawing.Point(180, 491);
            this.btnEnterSprint.Name = "btnEnterSprint";
            this.btnEnterSprint.Size = new System.Drawing.Size(50, 34);
            this.btnEnterSprint.TabIndex = 8;
            this.btnEnterSprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnterSprint.TileImage = ((System.Drawing.Image)(resources.GetObject("btnEnterSprint.TileImage")));
            this.btnEnterSprint.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnterSprint.UseSelectable = true;
            this.btnEnterSprint.UseTileImage = true;
            this.btnEnterSprint.Click += new System.EventHandler(this.btnEnterSprint_Click);
            // 
            // btnAddSprint
            // 
            this.btnAddSprint.ActiveControl = null;
            this.btnAddSprint.Location = new System.Drawing.Point(396, 417);
            this.btnAddSprint.Name = "btnAddSprint";
            this.btnAddSprint.Size = new System.Drawing.Size(42, 34);
            this.btnAddSprint.TabIndex = 6;
            this.btnAddSprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSprint.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddSprint.TileImage")));
            this.btnAddSprint.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSprint.UseSelectable = true;
            this.btnAddSprint.UseTileImage = true;
            this.btnAddSprint.Click += new System.EventHandler(this.btnAddSprint_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel3.Location = new System.Drawing.Point(23, 272);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Select Sprint";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(23, 353);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(151, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Create new Sprint";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(23, 391);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Sprint Name";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel5.Location = new System.Drawing.Point(23, 426);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(133, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Sprint Deadline";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Red;
            this.metroLabel6.Location = new System.Drawing.Point(23, 232);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(124, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Change Sprint";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.Red;
            this.metroLabel7.Location = new System.Drawing.Point(23, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(115, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Sprint details";
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
            this.metroLabel8.Size = new System.Drawing.Size(108, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Sprint name";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel9.Location = new System.Drawing.Point(23, 154);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(131, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Sprint deadline";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.ForeColor = System.Drawing.Color.White;
            this.metroLabel10.Location = new System.Drawing.Point(161, 114);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel10.TabIndex = 16;
            this.metroLabel10.Text = "Name";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.Color.White;
            this.metroLabel11.Location = new System.Drawing.Point(161, 154);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(81, 25);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "Deadline";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // frmSprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 542);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnAddSprint);
            this.Controls.Add(this.btnEnterSprint);
            this.Controls.Add(this.comborole);
            this.Controls.Add(this.SprintDeadLine);
            this.Controls.Add(this.sprint_Name);
            this.MaximizeBox = false;
            this.Name = "frmSprint";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Sprints management";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox sprint_Name;
        private MetroFramework.Controls.MetroDateTime SprintDeadLine;
        private MetroFramework.Controls.MetroComboBox comborole;
        private MetroFramework.Controls.MetroTile btnEnterSprint;
        private MetroFramework.Controls.MetroTile btnAddSprint;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}