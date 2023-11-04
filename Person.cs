using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Init_Project
{
    public class Person
    {
        private static int _id; 
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

        public Person()
        {
            _id++;
            ID = _id;
        }
    }
}
