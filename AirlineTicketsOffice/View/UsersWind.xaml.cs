using AirlineTicketsOffice.Model;
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

namespace AirlineTicketsOffice.View
{
	/// <summary>
	/// Логика взаимодействия для StuffWind.xaml
	/// </summary>
	public partial class UsersWind : Window
	{
		private User _currentUser = new User();
		private MainWindow _mainWindow;

		public UsersWind(MainWindow mainWindow, User user)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
			if (user != null)
			{
                _currentUser = user;
			}

            cbRoles.ItemsSource = Enum.GetNames(typeof(Roles));
			DataContext = _currentUser;
		}

        private void BtnSave_Click(object sender, RoutedEventArgs e) => Save();

		private void BtnClose_Click(object sender, RoutedEventArgs e)
		{
            if (MessageBox.Show("Несохраненные изменения будут утеряны.\nЗакрыть окно?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Close();
		}

        private bool Save()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(tbName.Text))
                errors.AppendLine("Укажите ФИО");
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
                errors.AppendLine("Укажите пароль");
            if (string.IsNullOrWhiteSpace(cbRoles.Text))
                errors.AppendLine("Укажите роль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (_currentUser.id == 0)
                ATOEntity.GetContext().Users.Add(_currentUser);

            try
            {
                ATOEntity.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
		{
            if (Save())
                Close();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mainWindow.UnlockMainWind();
			_mainWindow.UpdateUsersList();
		}
	}
}
