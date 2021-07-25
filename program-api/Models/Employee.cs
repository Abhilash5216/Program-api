using System;
using System.Collections.Generic;

#nullable disable

namespace program_api.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Department { get; set; }
        public int? Age { get; set; }
    }
}
