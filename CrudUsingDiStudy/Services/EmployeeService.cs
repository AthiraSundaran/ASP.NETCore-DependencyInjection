using System;
using CrudUsingDiStudy.Models;

namespace CrudUsingDiStudy.Services
{
	public class EmployeeService:IEmployeeService//inherit the interface class
	{
		public List<Employee> My_List = new List<Employee>()//create a employee list
		{
			new Employee{EmployeeId=1,EmployeeName="ABC",Designation="abc"},
			new Employee{EmployeeId=2,EmployeeName="DEF",Designation="def"},
			new Employee{EmployeeId=3,EmployeeName="GHI",Designation="ghi"}
		};
        public List<Employee> GetAllEmployees()//implement the method that declared in the interface class
        {
			return My_List;//return the list of employee
		}
		public List<Employee> AddEmployees(Employee employee)//implement the method for adding employee to the list,here  parameter employee take model as datatype
		{
			My_List.Add(new Employee { EmployeeId = My_List.Count+1, EmployeeName = employee.EmployeeName, Designation = employee.Designation });//Addind data to list using add method
			return My_List;//return the list of employee
        }
		public Employee GetEmployeesById(int id)//implement the method defined in interface.
		{
			try
			{
				Employee employee = My_List.FirstOrDefault(i => i.EmployeeId == id);//check the given id is presnt in list
				if (employee == null)//if id is not present throw an exceptin manually.
				{
					throw new("employee not fount");
				}
				return employee;//if id is present retun that employee.
			}
			catch (Exception ex)//catch the exception thrown in try block
			{
				throw new(ex.Message);//show the exception manually.
			}
        }
        public List<Employee> UpdateEmployees(Employee employee)//implement the update method declare in interface
		{
			try
			{
				Employee emp = My_List.FirstOrDefault(i => i.EmployeeId == employee.EmployeeId);//check the id present in list the 
				if (emp == null)
				{
					throw new("Employee not found");//id not present throw an exception manually.
				}
				emp.EmployeeName= employee.EmployeeName;//if id is presnt assign new name for the employee.
				emp.Designation = employee.Designation;//assign new designation for employee.
				return My_List;//return updated result.
			}
			catch(Exception Ex)
			{
				throw new(Ex.Message);
			}
		}
        public List<Employee> UpdateEmployeesUsingPost(Employee employee)//we can also update the data using post method.
		{
			try
			{
				Employee emp = My_List.FirstOrDefault(i => i.EmployeeId == employee.EmployeeId);
				if (emp == null)
				{
					throw new("Employee not fount");
				}
				emp.EmployeeName = employee.EmployeeName;
				emp.Designation = emp.Designation;
				return My_List;
			}
			catch(Exception Ex)
			{
				throw new(Ex.Message);
			}
		}
        public List<Employee> DeleteEmployee(int id)//implement the method for delete an employee defined in interface.
		{
			My_List.RemoveAll(i => i.EmployeeId == id);//remove the data from the list by Id.
			return My_List;
		}
    }
}

