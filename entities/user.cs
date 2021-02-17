using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.entities
{
    public class user
    {
        public Guid id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
