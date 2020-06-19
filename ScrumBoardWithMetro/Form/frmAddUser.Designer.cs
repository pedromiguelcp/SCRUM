namespace ScrumBoardWithMetro
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddUser = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.AddMail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pnlUsers = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroLabel2.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.ActiveControl = null;
            this.btnAddUser.Location = new System.Drawing.Point(385, 114);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(42, 34);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUser.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.TileImage")));
            this.btnAddUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.UseSelectable = true;
            this.btnAddUser.UseTileImage = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.Red;
            this.metroLabel7.Location = new System.Drawing.Point(23, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(145, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "User information";
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
            this.metroLabel8.Size = new System.Drawing.Size(85, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "User mail";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // AddMail
            // 
            // 
            // 
            // 
            this.AddMail.CustomButton.Image = null;
            this.AddMail.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.AddMail.CustomButton.Name = "";
            this.AddMail.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.AddMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddMail.CustomButton.TabIndex = 1;
            this.AddMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AddMail.CustomButton.UseSelectable = true;
            this.AddMail.CustomButton.Visible = false;
            this.AddMail.Lines = new string[0];
            this.AddMail.Location = new System.Drawing.Point(161, 114);
            this.AddMail.MaxLength = 32767;
            this.AddMail.Multiline = true;
            this.AddMail.Name = "AddMail";
            this.AddMail.PasswordChar = '\0';
            this.AddMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddMail.SelectedText = "";
            this.AddMail.SelectionLength = 0;
            this.AddMail.SelectionStart = 0;
            this.AddMail.ShortcutsEnabled = true;
            this.AddMail.Size = new System.Drawing.Size(200, 31);
            this.AddMail.TabIndex = 18;
            this.AddMail.UseSelectable = true;
            this.AddMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AddMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(450, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Users";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // pnlUsers
            // 
            this.pnlUsers.AllowDrop = true;
            this.pnlUsers.AutoSize = true;
            this.pnlUsers.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsers.HorizontalScrollbarBarColor = true;
            this.pnlUsers.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlUsers.HorizontalScrollbarSize = 10;
            this.pnlUsers.Location = new System.Drawing.Point(430, 60);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(104, 137);
            this.pnlUsers.TabIndex = 19;
            this.pnlUsers.UseCustomBackColor = true;
            this.pnlUsers.VerticalScrollbarBarColor = true;
            this.pnlUsers.VerticalScrollbarHighlightOnWheel = false;
            this.pnlUsers.VerticalScrollbarSize = 10;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 199);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.AddMail);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnAddUser);
            this.MaximizeBox = false;
            this.Name = "frmAddUser";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "SCRUM Board Add User";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnAddUser;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox AddMail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel pnlUsers;
    }
}