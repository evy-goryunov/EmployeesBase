using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeesBase
{
	/// <summary>
	/// Логика взаимодействия для EditWindow.xaml
	/// </summary>
	public partial class EditWindow : Window, IView
	{
		Presenter present;
		public EditWindow()
		{
			InitializeComponent();
			present = new Presenter(this);
			btnAdd.Click += delegate { present.Add(); };
			this.Title = present.Cnt().ToString();
		}

		public string firstName //Имя
		{
			get => txtFirstname.Text;
			set => txtFirstname.Text = value;
		} 
		public string secondName //Отчество
		{
			get => txtSecondname.Text;
			set => txtSecondname.Text = value;
		}
		public string sureName //Фамилия
		{
			get => txtSurename.Text;
			set => txtSurename.Text = value;
		}
		public string salary //Зарплата
		{
			get => txtAge.Text;
			set => txtAge.Text = value;
		}       
		public string age //Возраст
		{
			get => txtAge.Text;
			set => txtAge.Text = value;
		}


		//public int id { get } //ID


	}
}
