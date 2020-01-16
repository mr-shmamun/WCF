using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeRepository" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeRepository
    {
        [OperationContract]
        List<Employee> GetEmployees();
        [OperationContract]
        Employee GetEmployeeId(int id);

        [OperationContract]
        Employee SaveEmployee(Employee employee);

        [OperationContract]
        Employee UpdateEmployee(Employee employee);

        [OperationContract]
        Employee DeleteEmployee(int id);
    }
}
