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
		public static ObservableCollection<Employee> dbEmployee { get; set; }
		public static ObservableCollection<Department> dbDepartment { get; set; }

		public DataBase()
		{
			dbEmployee   = new ObservableCollection<Employee>();
			dbDepartment = new ObservableCollection<Department>();
		}
		// TODO реализовать логику проверки полей на пустые или неверные
		//редактируем отдел
		public static void EditProfile(string first, string sure, string dep, int age, int sal, int i)
		{
			dbEmployee[i].Edit(first, sure, dep, age, sal);
		}
		// Добавляем сотрудника
		public static void AddEmployee(Employee newEmployee)
		{
			dbEmployee.Add(newEmployee);
		}
		// Получить ID
		public int GetID()
		{
			return dbEmployee.Count();
		}

		public static void DeleteProfile(int i)
		{
			dbEmployee.RemoveAt(i);
		}

		//получаем ID
		//public static void SetId(int i)
		//{
		//	dbEmployee[i].SetId(i);
		//}

	}
}
