using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace EmployeesBase
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IView
	{
		Presenter present;
		DataBase db;

		public MainWindow()
		{
			InitializeComponent();
			present = new Presenter(this);
			db = new DataBase();
			AddBtn.Click += delegate { present.AddToSQLDB(); };
			EditBtn.Click += delegate { present.ChangeDepartment(); };
			DeleteBtn.Click += delegate { present.DeleteProfile(); };
			BtnRead.Click += delegate { present.ReadDB(); };
			ListOfEmp.ItemsSource = DataBase.dbEmployee;
			//lb.ItemsSource = DataBase.dbEmployee;
		}
		// реализация IView
		public string firstName //Имя
		{
			get => txtFirstname.Text;
			set
			{
				txtFirstname.Text = value;
			}
		}
		public string department //Отчество
		{
			get => txtDepartment.Text;
			set => txtDepartment.Text = value;
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
		public int id
		{
			get
			{
				return int.Parse( txtID.Text);
			}

			set => txtID.Text = value.ToString();
		}

		//Обновить
		private void Refresh_Click(object sender, RoutedEventArgs e)
		{
			ListOfEmp.Items.Refresh();
		}
		//{ Binding «ElementName»= «Имя_объекта - источника», Path =«Свойство_объекта - источника», Mode =«Mode»}
	}
}
