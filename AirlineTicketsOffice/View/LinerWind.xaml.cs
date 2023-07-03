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
	/// Логика взаимодействия для LinerWind.xaml
	/// </summary>
	public partial class LinerWind : Window
	{
		private Liner _currentLiner = new Liner();
		private MainWindow _mainWindow;

		public LinerWind(MainWindow mainWindow, Liner liner)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
            if (_mainWindow.CurrentUser.Role == "Кассир")
            {
                tbAirlinerName.IsReadOnly =
                    iudPassengerCapacity.IsReadOnly = true;
                dpProductionDate.IsEnabled = false;
                btnCreateSeats.IsEnabled = false;
                BtnSaveAndClose.Visibility = BtnSave.Visibility = Visibility.Hidden;
            }
            if (liner != null)
			{
				_currentLiner = liner;
			}
			else
			{
				_currentLiner.ProductionDate = DateTime.Now;
			}

			DataContext = _currentLiner;
		}

		private void btnCreateSeats_Click(object sender, RoutedEventArgs e)
		{
            if (IsCorrect())
            {
                CreateSeatsWind wind = new CreateSeatsWind(_currentLiner);
                wind.Show();
            }
		}

		private void BtnClose_Click(object sender, RoutedEventArgs e)
		{
            if (_mainWindow.CurrentUser.Role != "Кассир")
                if (MessageBox.Show("Несохраненные изменения будут утеряны.\nЗакрыть окно?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Close();
		}

        private bool IsCorrect()
        {
            StringBuilder errors = new StringBuilder();
            DateTime prodDate;
            if (string.IsNullOrWhiteSpace(tbAirlinerName.Text))
                errors.AppendLine("Укажите наименование");
            if (iudPassengerCapacity.Value == 0)
                errors.AppendLine("Укажите количество мест");
            if (!DateTime.TryParse(dpProductionDate.Text, out prodDate))
                errors.AppendLine("Неверно указана дата");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }
            else
                return true;
        }

        private bool Save()
        {
            if (_currentLiner.id == 0)
                _currentLiner.id = ATOEntity.GetContext().Liners.Add(_currentLiner).id;

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

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (IsCorrect())
                Save();
            MessageBox.Show(Convert.ToString(_currentLiner.id));
        }

		private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
		{
            if (IsCorrect() && Save())
                Close();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mainWindow.UnlockMainWind();
			_mainWindow.UpdateLinersList();
		}
	}
}
