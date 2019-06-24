using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    interface IView
    {
		string firstName { get; set; } //Имя
		string secondName { get; set; }//Отчество
		string sureName { get; set; }  //Фамилия
		//int id { get; set; }         //ID
		string salary { get; set; }    //Зарплата
		string age { get; set; }	   //Возраст
	}
}
