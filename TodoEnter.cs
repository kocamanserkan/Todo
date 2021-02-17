using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.bussinesService;
using Todo.entities;

namespace Todo
{
    public partial class TodoEnter : Form
    {
        public TodoEnter()
        {
            InitializeComponent();
        }

        private void txt_UserName_Enter(object sender, EventArgs e)
        {

            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;


        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {

            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_UserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {

                userService userService = new userService();
                user userControl = userService.userControl(txt_UserName.Text, txtPassword.Text);

                if (userControl != null )
                {

                    Form mainForm = Application.OpenForms["Form1"];
                    Panel leftPanel = (Panel)mainForm.Controls["pnlIslemList"];
                    GroupBox grpIslemList = (GroupBox)leftPanel.Controls["grpOperationList"];
                    foreach (Control item in grpIslemList.Controls)
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("Welcome to TO DO...","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter your user name or password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);


             } 
        }
    }
}
