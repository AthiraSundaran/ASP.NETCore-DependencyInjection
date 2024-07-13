using System;
using CrudUsingDiStudy.Models;

namespace CrudUsingDiStudy.Services
{
	public interface IEmployeeService// interface class,used for Abstraction ie hiding certain details and only show the important details of an object
	{
        public List<Employee> GetAllEmployees();//Declare the method that need to implement in service class.
		public List<Employee> AddEmployees(Employee employee);//declare method for Adding Employee to the list.
		public Employee	GetEmployeesById(int id);//Declare a method for get employee by Id.
		public List<Employee> UpdateEmployees(Employee employee);//Declare method for update employee data in alist.
		public List<Employee> UpdateEmployeesUsingPost(Employee employee);//Declare a method for updating data in alist using post Method.
		public List<Employee> DeleteEmployee(int id);//Declare a method for delete employee from list.

    }
}

