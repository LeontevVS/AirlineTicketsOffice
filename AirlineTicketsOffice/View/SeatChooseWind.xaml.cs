using AirlineTicketsOffice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
	/// Логика взаимодействия для SeatChooseWind.xaml
	/// </summary>
	public partial class SeatChooseWind : Window
	{
        private Ticket _ticket;
        private TicketWind _ticketWind;


        public SeatChooseWind(TicketWind ticketWind)
		{
			InitializeComponent();
            _ticket = ticketWind.CurrentTicket;
            _ticketWind = ticketWind;
            dgSeats.ItemsSource = SelectFreeSeats();
		}

        private List<Seat> SelectFreeSeats()
        {
            List<Seat> allSeats = _ticket.Passage.Liner.Seats.ToList();
            List<Ticket> boughtTickets = _ticket.Passage.Tickets.ToList();
            foreach (Ticket ticket in boughtTickets)
            {
                allSeats.Remove(allSeats.Find(s => s.id == ticket.Seat_id));
            }
            return allSeats;
        }

        private void SaveSelectedSeat()
        {
            _ticket.Seat = dgSeats.SelectedItem as Seat;
            _ticketWind.tbSeat.Text = _ticket.Seat.Chair + _ticket.Seat.Row.ToString() + " " + _ticket.Seat.Class;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            SaveSelectedSeat();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ticketWind.IsEnabled = true;
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            SaveSelectedSeat();
            Close();
        }
    }
}
