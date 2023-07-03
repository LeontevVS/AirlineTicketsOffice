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
	/// Логика взаимодействия для PassageWind.xaml
	/// </summary>
	public partial class PassageWind : Window
	{
		private Passage _currentPassage = new Passage();
		private MainWindow _mainWindow;

		public PassageWind(MainWindow mainWindow, Passage passage)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
            if (_mainWindow.CurrentUser.Role == "Кассир")
            {
                tbTitle.IsReadOnly = 
                    iudPassageNumber.IsReadOnly = 
                    cbLiner.IsReadOnly = 
                    dpDate.IsReadOnly = 
                    dpArrival.IsReadOnly = 
                    cbCrew.IsReadOnly = true;
                BtnSaveAndClose.Visibility = BtnSave.Visibility = Visibility.Hidden;
            }
            if (passage != null)
			{
				_currentPassage = passage;
			}
			else
			{
				_currentPassage.Date = DateTime.Now;
				_currentPassage.Arrival = DateTime.Now;
			}

            cbLiner.ItemsSource = ATOEntity.GetContext().Liners.ToList();
            cbCrew.ItemsSource = ATOEntity.GetContext().Crews.ToList();
			DataContext = _currentPassage;
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
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
                errors.AppendLine("Укажите название рейса");
            if (iudPassageNumber.Value == 0)
                errors.AppendLine("Укажите номер рейса");
            if (string.IsNullOrWhiteSpace(cbCrew.Text))
                errors.AppendLine("Укажите экипаж");
            if (string.IsNullOrWhiteSpace(cbLiner.Text))
                errors.AppendLine("Укажите лайнер");
            if (string.IsNullOrWhiteSpace(dpDate.Text))
                errors.AppendLine("Укажите дату отправления");
            if (string.IsNullOrWhiteSpace(dpArrival.Text))
                errors.AppendLine("Укажите прибытия");
            if (Convert.ToDateTime(dpArrival.Text) < Convert.ToDateTime(dpDate.Text))
                errors.AppendLine("Некорректный ввод дат");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            if (_currentPassage.id == 0)
                ATOEntity.GetContext().Passages.Add(_currentPassage);

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

        private void BtnSave_Click(object sender, RoutedEventArgs e) => Save();

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mainWindow.UnlockMainWind();
			_mainWindow.UpdatePassagesList();
		}
	}
}
