using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
   public class Student
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public int? GroupId { get; set; }
            public Group Group { get; set; }
    }
}
