using EmployeeClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeClient.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee employee = new Employee();

            EmployeeRepositoryClient client = new EmployeeRepositoryClient();
            client.Open();

            var data = client.GetEmployees();

            client.Close();



            return View(data);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {

            EmployeeRepositoryClient client = new EmployeeRepositoryClient();
            client.Open();

            var data = client.GetEmployeeId(id);

            client.Close();



            return View(data);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                EmployeeRepositoryClient client = new EmployeeRepositoryClient();
                client.Open();

                var data = client.SaveEmployee(emp);

                client.Close();


                return RedirectToAction("Index");
            }
            catch
            {
                return View(emp);
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeRepositoryClient client = new EmployeeRepositoryClient();
            client.Open();

            var data = client.GetEmployeeId(id);

            client.Close();

            return View(data);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                EmployeeRepositoryClient client = new EmployeeRepositoryClient();
                client.Open();

                var data = client.UpdateEmployee(emp);

                client.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(emp);
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            EmployeeRepositoryClient client = new EmployeeRepositoryClient();
            client.Open();

            var data = client.GetEmployeeId(id);

            client.Close();

            return View(data);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {
                EmployeeRepositoryClient client = new EmployeeRepositoryClient();
                client.Open();

                var data = client.DeleteEmployee(id);

                client.Close();

              

                return RedirectToAction("Index");
            }
            catch
            {
                return View(emp);
            }
        }
    }
}
