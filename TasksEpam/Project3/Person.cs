using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksEpam.Project3
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
