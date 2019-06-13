using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Employee.Entity
{
    public class EmployeeEntity
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public DateTime Dob { get; set; }
        public string Pos { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string EmpContact { get; set; }
        public DateTime Hired { get; set; }
        public byte[] Photo { get; set; }
        public bool? StopWork { get; set; }
    }
}