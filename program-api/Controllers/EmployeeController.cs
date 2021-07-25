using Microsoft.AspNetCore.Mvc;
using program_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program_api.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly FirstDatabaseContext _Context;
            public EmployeeController(FirstDatabaseContext _Context)
        {
            this._Context = _Context;
        }

        [HttpGet]
        [Route("EmployeeRoute")]
        public ActionResult GetEmployee()
        {
            var result = _Context.Employees.ToList();
            return Ok(result);
        }

        [HttpPost, Route("CreateNewEmployee")]
        public ActionResult CreateEmployee([FromBody] Employee emp)
        {

            _Context.Employees.Add(new Employee()
            {
                Age = emp.Age,
                Name = emp.Name,
                //DeptId = _context.Departments.Where(w => w.Id == 1).Select(s => s.Id).ToString(),
            });
            _Context.SaveChanges();
            return Ok("New Employee Created");
        }
        [HttpGet]
        [Route("Dummy")]
        public ActionResult Dummy1()
        {
            var result = _Context.Employees.ToList();
            return Ok(result);
        }

    }
}
