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
using System.Xml.Linq;

namespace AirlineTicketsOffice.View
{
	/// <summary>
	/// Логика взаимодействия для CrewWind.xaml
	/// </summary>
	public partial class CrewWind : Window
	{
		private Crew _currentCrew = new Crew();
		private MainWindow _mainWindow;

		public CrewWind(MainWindow mainWindow, Crew crew)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
            if (_mainWindow.CurrentUser.Role == "Кассир")
            {
                tbName.IsReadOnly = true;
                BtnSaveAndClose.Visibility = BtnSave.Visibility = Visibility.Hidden;
            }
            if (crew != null)
			{
				_currentCrew = crew;
                dgStaffs.ItemsSource = crew.Staffs;
			}

			DataContext = _currentCrew;
		}

		private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
		{
            if (Save())
                Close();
		}

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
                errors.AppendLine("Укажите наименование экипажа");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (_currentCrew.id == 0)
                ATOEntity.GetContext().Crews.Add(_currentCrew);

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

        private void BtnSave_Click(object sender, RoutedEventArgs e) => Save();

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mainWindow.UnlockMainWind();
			_mainWindow.UpdateCrewsList();
		}
	}
}
