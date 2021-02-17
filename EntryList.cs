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
    public partial class EntryList : Form
    {

        todoService todoService;

     


        public EntryList()
        {
            InitializeComponent();
            todoService = new todoService();

        }

        private void EntryList_Load(object sender, EventArgs e)
        {
            dataGridview1.DataSource = Alllist();
            dataGridview1.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private List<todo> Alllist()
        {


           return todoService.todoList();



        }

        private void dataGridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
