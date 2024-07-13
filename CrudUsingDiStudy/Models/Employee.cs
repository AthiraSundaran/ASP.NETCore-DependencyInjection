using System;
namespace CrudUsingDiStudy.Models
{
	public class Employee//model is plain C# class it represent the data that application will handle,
						 //that define the structure of data for both incoming requsr and outgoing response.
						 //models are used as parameter of action method for reciving the httprequest and also
						 //the return type action method 
	{
		public int EmployeeId { get; set; }
		public required string EmployeeName { get; set; }
		public required string Designation { get; set; }
	}
}

