using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
   public class Group
    {
        public int id { get; set; }
        public string title { get; set; }

        public ICollection<Student> students { get; set; }
    }
}
