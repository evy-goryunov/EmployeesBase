using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class Model
    {
		DataBase _newDataBase;

		public Model()
		{
			_newDataBase = new DataBase();
		}

		public DataBase NewDataBase
		{
			get
			{
				return _newDataBase;
			}
		}

		public int getcnt()
		{
			return _newDataBase.dbEmployee.Count();
		}
	}
}
