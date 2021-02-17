using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExitToDo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Application.Exit();
        }

        private void btnListToDo_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["newEntry"] != null)
            {
                T = Application.OpenForms["newEntry"];
                T.Focus();

            }
            else
            {
                T = new newEntry();
                T.MdiParent = this;
                T.Show();

            }

        }


        private void ButtonOnOff(bool kontrol)
        {

            foreach (var item in grpOperationList.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Enabled = kontrol;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {





            tmr_Timing.Start();
            tmr_Timing.Interval = 1000;
            tmr_Timing.Tick += Tmr_Timing_Tick;


            ButtonOnOff(false);


            TodoEnter userKontrol = new TodoEnter();
            userKontrol.MdiParent = this;
            userKontrol.StartPosition = FormStartPosition.CenterScreen;
            userKontrol.Show();





           
        }

        private void Tmr_Timing_Tick(object sender, EventArgs e)
        {


            lblTime.Text = DateTime.Now.ToString("F");



        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
