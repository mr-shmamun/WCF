using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    class EmployeeContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        public EmployeeContext() : base("EmpConnection")
        {

        }
    }
}
