using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.entities;

namespace Todo.database
{
   public static class virtualDB
    {


        public static List<user> userTable;
        public static List<todo> toDoTable;



        static virtualDB()
        {

            userTable = new List<user>();
            userTable.Add(new user() { id = Guid.NewGuid(), userName = "todo", password = "x1" });
            toDoTable = new List<todo>();


        }


    }
}
