using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseMVC.Models
{
    public class Department
    {
        public int ID { get; set; }

        public string DeptName { get; set; }

        public string Location { get; set; }

        public int NumberOfStaffs { get; set; }

    }
}
