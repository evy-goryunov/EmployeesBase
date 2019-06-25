using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class Presenter
    {
		private IView _view;

		public Presenter(IView view)
		{
			this._view = view;
		}
		// добавить сотрудника
		public void Add()
		{
			if (_view.firstName != "" && _view.sureName != "" && _view.department != "" && _view.age != "" && _view.salary != "")
			{
				DataBase.AddEmployee(new Employee(_view.firstName, _view.sureName, _view.department, int.Parse(_view.age), int.Parse(_view.salary), _view.id));
			}
		}
		// редактировать профиль
		public void ChangeDepartment()
		{
			DataBase.EditProfile(_view.firstName, _view.sureName, _view.department, int.Parse(_view.age), int.Parse(_view.salary), _view.id);
		}

		// удалить профиль
		public void DeleteProfile()
		{
			DataBase.DeleteProfile(_view.id);
		}
    }
}
