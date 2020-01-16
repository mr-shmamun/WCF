using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeRepository" in both code and config file together.
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeContext db = new EmployeeContext();
        public Employee DeleteEmployee(int id)
        {
            Employee emp = db.employees.Find(id);
            db.employees.Remove(emp);
                db.SaveChanges();
            
            return emp;
        }

        public Employee GetEmployeeId(int id)
        {
            return db.employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return db.employees.ToList();
        }

        public Employee SaveEmployee(Employee employee)
        {
            if(employee != null)
            {
                db.employees.Add(employee);
                db.SaveChanges();
            }
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
            return employee;
        }
    }
}
