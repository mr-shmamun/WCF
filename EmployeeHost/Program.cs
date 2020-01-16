using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(EmployeeService.EmployeeRepository)))
            {
                host.Open();
                Console.WriteLine("There Host is Started........");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
