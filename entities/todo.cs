using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.entities
{
    public class todo
    {
        [DisplayName("ID")]
        public Guid id { get; set; }
        [DisplayName("Title")]
        public string title { get; set; }
        [DisplayName("Bried Statament")]
        public string briefStatement { get; set; }
        [DisplayName("Full Statament")]
        public string fullStatement { get; set; }
        [DisplayName("Importance Of Degree")]
        public int importanceDegree { get; set; }
        [DisplayName("Situation")]
        public string situation { get; set; }
        [DisplayName("Creating Date")]

        public DateTime creatingDate { get; set; }






    }
}
