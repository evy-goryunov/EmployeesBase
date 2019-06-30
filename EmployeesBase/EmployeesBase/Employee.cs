using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class Employee
	{
		public string _firstName { get; set; } //Имя
		public string _sureName { get; set; }  //Фамилия
		public string _department { get; set; }//Отдел
		public int _id { get; set; }           //ID
		public int _salary { get; set; }       //Зарплата
		public int _age { get; set; }          //Возраст

		public Employee()
		{

		}

		public Employee(string firstName, string sureName, string department,  int age, int salary, int id)
		{
			this._firstName = firstName;
			this._sureName = sureName;
			this._salary = salary;
			this._department = department;
			this._age = age;
			this._id = id;
		}
		public Employee(string firstName, string sureName, string department, int age, int salary)
		{
			this._firstName = firstName;
			this._sureName = sureName;
			this._salary = salary;
			this._department = department;
			this._age = age;
		}
		//редактируем отдел
		public void Edit(string firstName, string sureName, string department, int age, int salary)
		{
			_firstName = firstName;
			_sureName = sureName;
			_department = department;
			_age = age;
			_salary = salary;
		}
		//добовляем ID
		public void SetId(int id) => _id = id;
	}
}
