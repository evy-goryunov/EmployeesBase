using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;

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

		//добовляем департамент в БД 
		public static void AddDepToDB(Department newDepartment)
		{
			var sql = String.Format("INSERT INTO Table (DEPARTMENT)"
									+ "VALUES (N'{0}')",
									//newEmployee._id,
									newDepartment._departmentName);
			Debug.WriteLine(sql);
			try
			{
				using (SqlConnection newConnect = new SqlConnection(@" Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True;Pooling=False"))
				{
					newConnect.Open();
					SqlCommand command = new SqlCommand(sql, newConnect);
					command.ExecuteNonQuery();
				}
			}
			catch (Exception e)
			{
				Debug.WriteLine(e.Message);
			}
		}


		//добовляем сотрудника в БД 
		public static void AddToDB(Employee newEmployee)
		{
			var sql = String.Format("INSERT INTO People (FIRSTNAME, SURENAME, DEPARTMENT, SALARY, AGE)"
									+ "VALUES (N'{0}', N'{1}', N'{2}', '{3}', '{4}')",
									//newEmployee._id,
									newEmployee._firstName,
									newEmployee._sureName,
									newEmployee._department,
									newEmployee._salary,
									newEmployee._age);
			Debug.WriteLine(sql);
			try
			{
				using (SqlConnection newConnect = new SqlConnection(@" Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True;Pooling=False"))
				{
					newConnect.Open();
					SqlCommand command = new SqlCommand(sql, newConnect);
					command.ExecuteNonQuery();
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine(e.Message);
			}
		}


		// Чтение из БД
		public static void ReadFromBD()
		{
			Employee newEmployee = new Employee();
			try
			{
				using (SqlConnection newConnect = new SqlConnection(@" Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True;Pooling=False"))
				{
					newConnect.Open();
					var sql = @" SELECT * FROM People";
					SqlCommand command = new SqlCommand(sql, newConnect);
					SqlDataReader reader = command.ExecuteReader();

					while (reader.Read())
					{
						dbEmployee.Add(new Employee(newEmployee._firstName = $"{reader["FIRSTNAME"]}",
													newEmployee._sureName = $"{reader["SURENAME"]}",
													newEmployee._department = $"{reader["DEPARTMENT"]}",
													newEmployee._age = int.Parse($"{reader["AGE"]}"),
													newEmployee._salary = int.Parse($"{reader["SALARY"]}"),
													newEmployee._id = int.Parse($"{reader["ID"]}")));
					}
				}
			}catch(Exception e)
			{
				Debug.WriteLine(e.Message);
			}
		}


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
		// Удалить сотрудника
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
