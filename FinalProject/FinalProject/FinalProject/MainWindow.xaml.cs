using FinalProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;


namespace PersonalProject
{
   
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private UCL5Entities db =new UCL5Entities();

        public MainWindow()
        {
            InitializeComponent();
            StartTimer();
            
        }
        private void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            firstImage.Visibility = Visibility.Hidden;
            secondImage.Visibility = Visibility.Visible;
            ShowSearchControls();
        }

        private void ShowSearchControls()
        {
            searchPanel.Visibility = Visibility.Visible;
            searchResultsListBox.Visibility = Visibility.Visible;

            ede.Visibility = Visibility.Visible;
            logolbx.Visibility = Visibility.Visible;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from p in db.Players select p;
            searchResultsListBox.ItemsSource = query.ToList();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var select1 = searchTextBox.Text;
            var query = from p in db.Players where p.Name.Contains(select1.ToUpper()) select p;
            searchResultsListBox.ItemsSource = query.ToList();
        }

        private void searchResultsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Player selectedPlayer = searchResultsListBox.SelectedItem as Player;

            if (selectedPlayer != null)
            {

            
                var query = from p in db.Teams where p.Id == selectedPlayer.TeamsId select p;
                var query2 = from p in db.Players select p.Goals.ToString();

                ede.ItemsSource = new List<string>() { "Goals: " + selectedPlayer.Goals, "Minutes Played: " + selectedPlayer.Minutes, "Position: " + selectedPlayer.Position, "Assists: " + selectedPlayer.Assists, "Match Played: " + selectedPlayer.Match, "Distance Covered: " + selectedPlayer.Distance };


                logolbx.ItemsSource = query.ToList();


            }
        }
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                

                PerformSearch();
            }
        }

        private void PerformSearch()
        {
            string searchTerm = searchTextBox.Text;
            var query = from p in db.Players where p.Name.Contains(searchTerm.ToUpper()) select p;
            searchResultsListBox.ItemsSource = query.ToList();
        }
        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = searchTextBox.Text;
            var query = from p in db.Players where p.Name.StartsWith(searchTerm.ToUpper()) select p.Name;
            searchResultsListBox.ItemsSource = query.ToList();
        }
    }
}

