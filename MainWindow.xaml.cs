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

namespace DataBindingExample
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventModel evento;
        public MainWindow()
        {
            InitializeComponent();
            evento = new EventModel () { 
                Title = "Reunión de trabajo", 
                Date = new DateTime(2020, 10, 23) 
            }; 
            nombreTextBox.Text = evento.Title; 
            fechaDatePicker.SelectedDate = evento.Date;
        }
        class EventModel
        {
            private string title; private DateTime date;
            public string Title
            {
                get => title; set
                {
                    if (value != title)
                    {
                        title = value;
                    }
                }
            }
            public DateTime Date
            {
                get => date;
                set
                {
                    if (value != date)
                    {
                        date = value;
                    }
                }
            }
        }

        private void modificarEventoButton_Click(object sender, RoutedEventArgs e)
        {
            evento.Title = evento.Title.ToLower(); 
            evento.Date = evento.Date.AddDays(1); 
            nombreTextBox.Text = evento.Title; 
            fechaDatePicker.SelectedDate = evento.Date; 
            MessageBox.Show(evento.Title + "\n" + evento.Date);
        }
    }
}