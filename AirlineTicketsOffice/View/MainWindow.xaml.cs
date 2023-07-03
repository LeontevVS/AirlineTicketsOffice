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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AirlineTicketsOffice.Model;
using AirlineTicketsOffice.View;

namespace AirlineTicketsOffice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		public User CurrentUser { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Visibility = Visibility.Hidden;
            AuthorizationWind authorization = new AuthorizationWind(this);
            authorization.Show();
            UpdateTicketsList();
			UpdatePassagesList();
			UpdateLinersList();
			UpdateStaffsList();
            UpdateCrewsList();
            UpdateUsersList();
        }

        private void Btn_Create_Click(object sender, RoutedEventArgs e)
        {
            if(TabCtrl.SelectedItem == TabTickets)
            {
				TicketWind wind = new TicketWind(this, null);
				wind.Show();
            }
            else if(TabCtrl.SelectedItem == TabPassages)
			{
				PassageWind wind = new PassageWind(this, null);
				wind.Show();
			}
            else if(TabCtrl.SelectedItem == TabLiners)
			{
				LinerWind wind = new LinerWind(this, null);
				wind.Show();
			}
            else if(TabCtrl.SelectedItem == TabCrewsAndStuffs)
			{
				if (TabCtrlCrewsAndStaffs.SelectedItem == TabCrews)
				{
					CrewWind wind = new CrewWind(this, null);
					wind.Show();
				}
                else if(TabCtrlCrewsAndStaffs.SelectedItem == TabStaffs)
				{
					StaffWind wind = new StaffWind(this, null);
					wind.Show();
				}
			}
            else if(TabCtrl.SelectedItem == TabUsers)
            {
                UsersWind wind = new UsersWind(this, null);
                wind.Show();
            }
            BlockMainWind();
        }
		private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (TabCtrl.SelectedItem == TabTickets)
			{
				TicketWind wind = new TicketWind(this, DGridTickets.SelectedItem as Ticket);
				wind.Show();
			}
            else if(TabCtrl.SelectedItem == TabPassages)
			{
				PassageWind wind = new PassageWind(this, DGridPassages.SelectedItem as Passage);
				wind.Show();
			}
            else if(TabCtrl.SelectedItem == TabLiners)
			{
				LinerWind wind = new LinerWind(this, DGridLiners.SelectedItem as Liner);
				wind.Show();
			}
            else if(TabCtrl.SelectedItem == TabCrewsAndStuffs)
			{
				if (TabCtrlCrewsAndStaffs.SelectedItem == TabCrews)
				{
					CrewWind wind = new CrewWind(this, DGridCrews.SelectedItem as Crew);
					wind.Show();
				}
                else if(TabCtrlCrewsAndStaffs.SelectedItem == TabStaffs)
				{
					StaffWind wind = new StaffWind(this, DGridStaffs.SelectedItem as Staff);
					wind.Show();
				}
			}
            else if(TabCtrl.SelectedItem == TabUsers)
			{
				UsersWind wind = new UsersWind(this, DGridUsers.SelectedItem as User);
				wind.Show();
			}

			BlockMainWind();
		}

        private void BlockMainWind()
        {
            IsEnabled = false;
        }

        public void UnlockMainWind()
        {
            IsEnabled = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           e.Cancel = !IsEnabled;
        }

        public void UpdateTicketsList() => DGridTickets.ItemsSource = ATOEntity.GetContext().Tickets.ToList();
        public void UpdatePassagesList() => DGridPassages.ItemsSource = ATOEntity.GetContext().Passages.ToList();
		public void UpdateLinersList() => DGridLiners.ItemsSource = ATOEntity.GetContext().Liners.ToList();
		public void UpdateStaffsList() => DGridStaffs.ItemsSource = ATOEntity.GetContext().Staffs.ToList();
		public void UpdateCrewsList() => DGridCrews.ItemsSource = ATOEntity.GetContext().Crews.ToList();
		public void UpdateUsersList() => DGridUsers.ItemsSource = ATOEntity.GetContext().Users.ToList();

		private void btnDelete_Click(object sender, RoutedEventArgs e)
		{
			
			if (MessageBox.Show("Вы точно хотите удалить выбранный элемент?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
                try
				{
                    if (TabCtrl.SelectedItem == TabTickets)
                    {
                        ATOEntity.GetContext().Tickets.Remove(DGridTickets.SelectedItem as Ticket);
						ATOEntity.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");

						UpdateTicketsList();
                    }
                    else if (TabCtrl.SelectedItem == TabPassages)
                    {
                        ATOEntity.GetContext().Passages.Remove(DGridPassages.SelectedItem as Passage);
                        ATOEntity.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");

                        UpdatePassagesList();
                    }
                    else if (TabCtrl.SelectedItem == TabLiners)
                    {
                        ATOEntity.GetContext().Liners.Remove(DGridLiners.SelectedItem as Liner);
                        ATOEntity.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");

                        UpdateLinersList();
                    }
                    else if(TabCtrl.SelectedItem == TabCrewsAndStuffs)
                    {
                        if (TabCtrlCrewsAndStaffs.SelectedItem == TabCrews)
                        {
                            ATOEntity.GetContext().Crews.Remove(DGridCrews.SelectedItem as Crew);
                            ATOEntity.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены");

                            UpdateCrewsList();
                        }
                        else if(TabCtrlCrewsAndStaffs.SelectedItem == TabStaffs)
                        {
                            ATOEntity.GetContext().Staffs.Remove(DGridStaffs.SelectedItem as Staff);
                            ATOEntity.GetContext().SaveChanges();
                            MessageBox.Show("Данные удалены");

                            UpdateStaffsList();
                        }
                    }
                    else if(TabCtrl.SelectedItem == TabUsers)
                    {
                        ATOEntity.GetContext().Users.Remove(DGridUsers.SelectedItem as User);
                        ATOEntity.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены");

                        UpdateUsersList();
                    }
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

        private void TabCtrl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CurrentUser.Role == "Кассир")
            {
                if (TabCtrl.SelectedItem != TabTickets)
                    btnDelete.Visibility = Btn_Create.Visibility = Visibility.Hidden;
                else
                    btnDelete.Visibility = Btn_Create.Visibility = Visibility.Visible;
            }
            else if (CurrentUser.Role == "АвиационныйМенеджер")
            {
                if (TabCtrl.SelectedItem == TabTickets)
                    btnDelete.Visibility = Btn_Create.Visibility = Visibility.Hidden;
                else
                    btnDelete.Visibility = Btn_Create.Visibility = Visibility.Visible;
            }
        }
    }
}
