using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.database;
using Todo.entities;

namespace Todo.bussinesService
{
    public class userService
    {

        public user userControl(string username, string password)
        {


            return virtualDB.userTable.Where(i => i.userName == username && i.password == password).FirstOrDefault();


        }


    }
}
