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
	public partial class StaffWind : Window
	{
		private Staff _currentStaff = new Staff();
		private MainWindow _mainWindow;

		public StaffWind(MainWindow mainWindow, Staff staff)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
            if (_mainWindow.CurrentUser.Role == "Кассир")
            {
                tbName.IsReadOnly = cbCrew.IsReadOnly = cbPost.IsReadOnly = true;
                BtnSaveAndClose.Visibility = BtnSave.Visibility = Visibility.Hidden;
            }
			if (staff != null)
			{
				_currentStaff = staff;
			}

			cbPost.ItemsSource = Enum.GetNames(typeof(Posts));
			cbCrew.ItemsSource = ATOEntity.GetContext().Crews.ToList();
			DataContext = _currentStaff;
		}

        private void BtnSave_Click(object sender, RoutedEventArgs e) => Save();

		private void BtnClose_Click(object sender, RoutedEventArgs e)
		{
            if (_mainWindow.CurrentUser.Role != "Кассир")
                if (MessageBox.Show("Несохраненные изменения будут утеряны.\nЗакрыть окно?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Close();
		}

        private bool Save()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(tbName.Text))
                errors.AppendLine("Укажите ФИО");
            if (string.IsNullOrWhiteSpace(cbCrew.Text))
                errors.AppendLine("Укажите экипаж");
            if (string.IsNullOrWhiteSpace(cbPost.Text))
                errors.AppendLine("Укажите должность");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (_currentStaff.id == 0)
                ATOEntity.GetContext().Staffs.Add(_currentStaff);

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
			_mainWindow.UpdateStaffsList();
		}
	}
}
