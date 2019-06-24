using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesBase
{
    class Presenter
    {
		private Model _model;
		private IView _view;

		public Presenter(IView view)
		{
			this._view = view;
			_model = new Model();
		}

		public void Add()
		{
			_model.NewDataBase.AddEmployee(new Employee(_view.firstName, _view.secondName, _view.sureName, _view.age, _view.salary));


		}

		public int Cnt()
		{
			return _model.getcnt();
		}
    }
}
