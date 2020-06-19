using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumBoardWithMetro
{
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            SQLHelper.SQLStart("Data Source=PEDRO\\SQLEXPRESS;Initial Catalog=ScrumTableDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            timer1.Start();
        }
        //frmMain frm = frmMain.GetInstance;
        frmLog frm = frmLog.GetInstance;
        int Value = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            timer1.Enabled = true;
            if (Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                frm.Show();
                frm.Focus();
                timer1.Enabled = false;

            }
            else
            {
                metroProgressBar1.Value += 1;
                Value += 1;
            }

        }
    }
}
