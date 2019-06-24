using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class Employee
    {
		public string _firstName { get; set; } //Имя
		public string _secondName { get; set; }//Отчество
		public string _sureName { get; set; }  //Фамилия
	//	public string _department { get; set; }//Отдел
	//	public int _id { get; set; }           //ID
		public string _salary { get; set; }       //Зарплата
		public string _age { get; set; }

		public Employee(string firstName, string secondName, string sureName, /*string department,*/  string age, string salary)
		{
			this._firstName = firstName;
			this._secondName = secondName;
			this._sureName = sureName;
			this._salary = salary;
			//this._department = department;
			this._age = age;
		}

		////редактируем зарплату
		//public void SetSalary(int salary) => _salary = salary;
		////редактируем отдел
		//public void SetDepartment(string department) => _department = department;
		////добовляем ID
		//public void SetId(int id) => _id = id;
	}
}
