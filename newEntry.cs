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

namespace Todo
{
    public partial class newEntry : Form
    {
        public newEntry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;

        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnAddNewToDo_Click(object sender, EventArgs e)
        {

            todoService todoService = new todoService();
            int result = todoService.addNewEntrt(new entities.todo()
            {

                id = Guid.NewGuid(),
                title = txtTitle.Text,
                briefStatement = txtBriefStatment.Text,
                fullStatement = txtStatement.Text,
                importanceDegree = int.Parse(txtImportanceDegree.Text),
                situation = cmbStage.SelectedItem.ToString(),
                creatingDate = DateTime.Now


            });

            if (result>0)
            {
                MessageBox.Show("To Do! is added with succes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult ask = MessageBox.Show("Do you want to add another To Do!","Ask",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (ask==DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;

                        }
                    }
                }

                else
                {
                    Form EntryList = Application.OpenForms["EntryList"];
                    if (EntryList ==null)
                    {
                        EntryList = new EntryList();
                        EntryList.MdiParent = Application.OpenForms["Form1"];
                        EntryList.StartPosition = FormStartPosition.CenterScreen;

                        EntryList.Show();
                        this.Close();
                    }
                    else
                    {
                        //???
                    }
                }
            }
            else
            {
                MessageBox.Show("To do! could not be added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


         

        }


    }
}
