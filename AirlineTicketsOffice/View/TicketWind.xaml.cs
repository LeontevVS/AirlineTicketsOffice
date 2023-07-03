using AirlineTicketsOffice.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using Xceed.Wpf.Toolkit;

namespace AirlineTicketsOffice.View
{
	/// <summary>
	/// Логика взаимодействия для TicketWind.xaml
	/// </summary>
	public partial class TicketWind : Window
	{
		private Ticket _currentTicket = new Ticket();
        private MainWindow _mainWindow;

		public Ticket CurrentTicket
		{
			get { return _currentTicket; }
		}

		public Seat SelectedSeat
		{
			get
			{
				return _currentTicket.Seat;
			}
			set
			{
                _currentTicket.Seat = value;

            }
		}


        public TicketWind(MainWindow mainWindow, Ticket ticket)
		{
			InitializeComponent();
			_mainWindow = mainWindow;
			if (_mainWindow.CurrentUser.Role == "АвиационныйМенеджер")
			{
				CBPassage.IsReadOnly = 
					tbName.IsReadOnly =
					DPDate.IsReadOnly =
					tbPassport.IsReadOnly =
					DPPassportDate.IsReadOnly =
					dudPrice.IsReadOnly =
					tbTicket.IsReadOnly =
					tbTill.IsReadOnly =
					tbUser.IsReadOnly = true;
				btnChooseSeat.IsEnabled = false;
                BtnSaveAndClose.Visibility = BtnSave.Visibility = Visibility.Hidden;
            }
            DPPassportDate.Maximum = DateTime.Now;
			if (ticket != null)
			{
				_currentTicket = ticket;
				DPDate.Text = ticket.Date.ToLongDateString() + ticket.Date.ToShortTimeString();
				DPPassportDate.Text = ticket.PassportDate.ToString();
				tbSeat.Text = ticket.Seat.Chair + ticket.Seat.Row.ToString() + " " + ticket.Seat.Class;
			}
			else
			{
				_currentTicket.Date = DateTime.Now;
				_currentTicket.PassportDate = DateTime.Now;
				_currentTicket.User = _mainWindow.CurrentUser;
			}

            DataContext = _currentTicket;
			CBPassage.ItemsSource = ATOEntity.GetContext().Passages.ToList();
		}

		private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (IsCorrect())
            {
                Save();
            }
        }

        private bool IsCorrect()
        {
            StringBuilder errors = new StringBuilder();
            int temp = 0;
            decimal dtemp = 0;
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                (tbName.Text.Split(' ').Length < 2 && !string.IsNullOrWhiteSpace(tbName.Text.Split(' ')[1]) && !string.IsNullOrWhiteSpace(tbName.Text.Split(' ')[0])))
                errors.AppendLine("Укажите ФИО пассажира");
            if (string.IsNullOrWhiteSpace(CBPassage.Text))
                errors.AppendLine("Выберите рейс");
            if (string.IsNullOrWhiteSpace(DPDate.Text))
                errors.AppendLine("Укажите дату покупки");
            if (string.IsNullOrWhiteSpace(DPPassportDate.Text))
                errors.AppendLine("Укажите дату выдачи паспорта");
            if (tbPassport.Text.Contains('_'))
                errors.AppendLine("Укажите серию и номер паспорта");
            if (!int.TryParse(tbTicket.Text, out temp) && temp < 1)
                errors.AppendLine("Укажите номер билета");
            if (!int.TryParse(tbTill.Text, out temp) && temp < 1)
                errors.AppendLine("Укажите номер кассы");
            if (!decimal.TryParse(dudPrice.Text, out dtemp) || dtemp < 1)
                errors.AppendLine("Укажите цену");
			if (tbSeat.Text == "Не выбрано")
				errors.AppendLine("Выберите место");

            if (errors.Length > 0)
            {
                System.Windows.MessageBox.Show(errors.ToString());
                return false;
            }
            else
                return true; 
        }

		private bool Save()
		{

			if (_currentTicket.id == 0)
				ATOEntity.GetContext().Tickets.Add(_currentTicket);

			try
			{
				ATOEntity.GetContext().SaveChanges();
				System.Windows.MessageBox.Show("Информация сохранена");
				return true;
			}
			catch (Exception ex)
			{
				System.Windows.MessageBox.Show(ex.Message.ToString());
				return false;
			}
		}

		private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
		{
			if(IsCorrect() && Save())
				Close();
		}

		private void BtnClose_Click(object sender, RoutedEventArgs e)
		{
            if (_mainWindow.CurrentUser.Role != "АвиационныйМенеджер")
                if (System.Windows.MessageBox.Show("Несохраненные изменения будут утеряны.\nЗакрыть окно?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			    Close();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_mainWindow.UnlockMainWind();
			_mainWindow.UpdateTicketsList();
		}

		private void btnChooseSeat_Click(object sender, RoutedEventArgs e)
		{
			if (_currentTicket.Passage != null)
			{
				SeatChooseWind chooseWind = new SeatChooseWind(this);
				IsEnabled = false;
				chooseWind.Show();
			}
			else
				System.Windows.MessageBox.Show("Для выбора места сначала нужно выбрать рейс");
		}
	}
}
