using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.database;
using Todo.entities;

namespace Todo.bussinesService
{
  public class todoService
    {

        public int addConrol()
        {

            return virtualDB.toDoTable.Count;


        }

        public List<todo> todoList()
        {

            return virtualDB.toDoTable;

        }

        public int addNewEntrt(todo data)
        {

            try
            {
                virtualDB.toDoTable.Add(data);
                return 1;

            }
            catch (Exception ex)
            {

                return 0;
            }

        }
        
    }
}
