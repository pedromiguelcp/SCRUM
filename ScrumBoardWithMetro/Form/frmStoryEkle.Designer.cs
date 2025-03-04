﻿namespace ScrumBoardWithMetro
{
    partial class frmStoryEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoryEkle));
            this.btnStoryEkle = new MetroFramework.Controls.MetroTile();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtStory_Name = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.ActiveControl = null;
            this.btnStoryEkle.Location = new System.Drawing.Point(223, 214);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(58, 43);
            this.btnStoryEkle.TabIndex = 6;
            this.btnStoryEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoryEkle.TileImage = ((System.Drawing.Image)(resources.GetObject("btnStoryEkle.TileImage")));
            this.btnStoryEkle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStoryEkle.UseSelectable = true;
            this.btnStoryEkle.UseTileImage = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(160, 112);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(188, 96);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(15, 139);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Description";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(15, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Story Name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtStory_Name
            // 
            // 
            // 
            // 
            this.txtStory_Name.CustomButton.Image = null;
            this.txtStory_Name.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtStory_Name.CustomButton.Name = "";
            this.txtStory_Name.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtStory_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStory_Name.CustomButton.TabIndex = 1;
            this.txtStory_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStory_Name.CustomButton.UseSelectable = true;
            this.txtStory_Name.CustomButton.Visible = false;
            this.txtStory_Name.Lines = new string[0];
            this.txtStory_Name.Location = new System.Drawing.Point(160, 79);
            this.txtStory_Name.MaxLength = 32767;
            this.txtStory_Name.Multiline = true;
            this.txtStory_Name.Name = "txtStory_Name";
            this.txtStory_Name.PasswordChar = '\0';
            this.txtStory_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStory_Name.SelectedText = "";
            this.txtStory_Name.SelectionLength = 0;
            this.txtStory_Name.SelectionStart = 0;
            this.txtStory_Name.ShortcutsEnabled = true;
            this.txtStory_Name.Size = new System.Drawing.Size(188, 27);
            this.txtStory_Name.TabIndex = 1;
            this.txtStory_Name.UseSelectable = true;
            this.txtStory_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStory_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmStoryEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 276);
            this.Controls.Add(this.txtStory_Name);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnStoryEkle);
            this.MaximizeBox = false;
            this.Name = "frmStoryEkle";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Add Story";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnStoryEkle;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtStory_Name;
    }
}