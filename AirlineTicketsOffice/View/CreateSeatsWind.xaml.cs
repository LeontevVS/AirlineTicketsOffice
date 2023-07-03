using AirlineTicketsOffice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
	/// Логика взаимодействия для CreateSeatsWind.xaml
	/// </summary>
	public partial class CreateSeatsWind : Window
	{
        private ObservableCollection<CreateSeats> _collection = null;
        private const string _seatsArray = "ABCDEF";
        private Liner _currentLiner;

        public CreateSeatsWind(Liner liner)
		{
			InitializeComponent();
            _currentLiner = liner;
            tbLiner.Text += liner.AirlinerName;
            tbSeatsCount.Text += liner.PassengerCapacity;
            cbClass.ItemsSource = Enum.GetNames(typeof(Classes));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(_collection == null)
            {
                _collection = new ObservableCollection<CreateSeats>();
                dgCreateSeats.ItemsSource = _collection;
            }
            _collection.Add(new CreateSeats());
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void BtnSaveAndClose_Click(object sender, RoutedEventArgs e)
        {
            if (IsCorrect() && SaveSeats())
                Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool IsCorrect()
        {
            int inputCountSeats = 0;
            foreach (CreateSeats elem in _collection)
            {
                inputCountSeats += elem.SeatsCount;
            }
            if (inputCountSeats == _currentLiner.PassengerCapacity)
                return true;
            else
                MessageBox.Show("Данные указаны неверно");
                return false;
        }

        private bool SaveSeats()
        {
            if (_currentLiner.Seats.Count != 0)
            {
                ATOEntity.GetContext().Seats.RemoveRange(_currentLiner.Seats);

                //try
                //{
                //    ATOEntity.GetContext().SaveChanges();
                //    //MessageBox.Show("Информация сохранена");
                //    return true;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message.ToString());
                //    return false;
                //}
            } 

            List<Seat> createdSeats = new List<Seat>();
            int currentRow = 1;
            foreach (CreateSeats elem in _collection)
            {
                for (int i = 0; i < elem.RowCount; i++)
                {
                    for (int j = 0; j < elem.SeatsCountInRow; j++)
                    {
                        Seat seat = new Seat()
                        {
                            Class = Enum.GetName(typeof(Classes), elem.Class),
                            Chair = _seatsArray[j].ToString(),
                            Liner = _currentLiner,
                            Row = currentRow
                        };
                        createdSeats.Add(seat);
                    }
                    currentRow++;
                }
            }

            ATOEntity.GetContext().Seats.AddRange(createdSeats);

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
            {
                SaveSeats();
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(dgCreateSeats.SelectedIndex >= 0)
                _collection.RemoveAt(dgCreateSeats.SelectedIndex);
        }
    }

    class CreateSeats: INotifyPropertyChanged
    {
        private Classes _class;

        public Classes Class
        {
            get { return _class; }
            set
            {
                _class = value;
                if (Class == Classes.Эконом)
                    SeatsCountInRow = 6;
                else
                    SeatsCountInRow = 4;
                OnPropertyChanged("SeatsCountInRow");
            }
        }


        private int _rowCount;

        public int RowCount
        {
            get { return _rowCount; }
            set
            {
                _rowCount = value;
                OnPropertyChanged();
                SeatsCount = _rowCount * _seatsCountInRow;
            }
        }

        private int _seatsCountInRow;

        public int SeatsCountInRow
        {
            get { return _seatsCountInRow; }
            set
            {
                _seatsCountInRow = value;
                OnPropertyChanged();
                SeatsCount = _rowCount * _seatsCountInRow;
            }
        }

        private int _seatsCount;

        public int SeatsCount
        {
            get { return _seatsCount; }
            private set
            {
                if (value == _seatsCount) return;
                _seatsCount = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
