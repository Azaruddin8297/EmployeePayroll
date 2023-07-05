using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Profile { get; set;}
        public char Gender { get; set; }
        public string Department { get; set;}
        public int Salary { get; set;}
        public DateTime StartDate { get; set; }
        public string Notes { get; set;}
        public bool IsTrash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
