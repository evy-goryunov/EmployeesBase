using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class DataBase
    {
		public ObservableCollection<Employee> dbEmployee;
		public ObservableCollection<Department> dbDepartment;

		public DataBase()
		{
			dbEmployee  = new ObservableCollection<Employee>();
			dbDepartment = new ObservableCollection<Department>();
		}
		// коллекция для сотрудников
		//public ObservableCollection<Employee> dbEmployee { get; set; } = new ObservableCollection<Employee>();
		// коллекция для отделов
		//public ObservableCollection<Department> dbDepartment { get; set; } = new ObservableCollection<Department>();
		////редактируем возраст
		//public static void SetDep(string a, int i) => dbEmployee[i].SetDepartment(a);
		////редактируем зарплату
		//public static void SetSal(int a, int i) => dbEmployee[i].SetSalary(a);
		////получаем ID
		//public static void SetId(int i) => dbEmployee[i].SetId(i);

		public void AddEmployee(Employee newEmployee)
		{
			dbEmployee.Add(newEmployee);
		}

		public int GetID()
		{
			return dbEmployee.Count();
		}

	}
}
