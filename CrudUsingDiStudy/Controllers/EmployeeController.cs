using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudUsingDiStudy.Models;
using CrudUsingDiStudy.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudUsingDiStudy.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;//Declare a private read only variable with interface as data type.
        public EmployeeController(IEmployeeService value) //create constructor give a parameter with type as interface,
                                                          //this parameter holds the dependancy injection.
                                                          //here we are doing construction injection.        {
        {
            _employeeService = value;//assign the parameter to the variable that we are declared before.
        }
        // GET: api/values
        [HttpGet]
        public IActionResult GetAllEmployees()//implement a http get method 
        {
            return Ok(_employeeService.GetAllEmployees());//instead of creating the instace of controller using the variable to access the method
        }
        [HttpPost]
        public IActionResult AddEmployees(Employee employee)
        {
            return Ok(_employeeService.AddEmployees(employee));
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(_employeeService.GetEmployeesById(id));
        }
        [HttpPut]
        public IActionResult UpdateEmployees(Employee employee)
        {
            return Ok(_employeeService.UpdateEmployees(employee));
        }
        [HttpPost("update")]
        public IActionResult UpdateEmployeeUsingPost(Employee employee)
        {
            return Ok(_employeeService.UpdateEmployeesUsingPost(employee));
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            return Ok(_employeeService.DeleteEmployee(id));
        }
    }
}

