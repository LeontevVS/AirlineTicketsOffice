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
using AirlineTicketsOffice.Model;

namespace AirlineTicketsOffice.View
{
	/// <summary>
	/// Логика взаимодействия для AuthorizationWind.xaml
	/// </summary>
	public partial class AuthorizationWind : Window
	{
		private MainWindow _mainWindow;
		private List<User> _users = ATOEntity.GetContext().Users.ToList();

		public AuthorizationWind(MainWindow mainWindow)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			_mainWindow.Close();
			Close();
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			User user = _users.Find(x => x.Name == tbName.Text);
			if(user == null || pbPassword.Password != user.Password)
			{
				MessageBox.Show("Неверно введены имя или пароль");
			}
			else
			{
				_mainWindow.Visibility = Visibility.Visible;
				_mainWindow.CurrentUser = user;
				switch (user.Role)
				{
					case "Администратор":
						break;
                    case "Кассир":
						_mainWindow.TabUsers.Visibility = Visibility.Hidden;
                        break;
                    case "АвиационныйМенеджер":
                        _mainWindow.TabUsers.Visibility = Visibility.Hidden;
                        break;
                }

				Close();
			}
		}
	}
}
