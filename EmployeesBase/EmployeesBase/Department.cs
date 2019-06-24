using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class Department
    {
		public string _departmentName { get; private set; }

		public Department(string departmentName)
		{
			this._departmentName = departmentName;
		}
	}
}
