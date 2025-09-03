using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public decimal Salary { get; set; }
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Department { get; set; } = "";
    }
}
