using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Assg_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Players { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Players = new ObservableCollection<string>();
            listBox.ItemsSource = Players;
        }

        private void AddPlayer(object sender, RoutedEventArgs e)
        {
            string playerName = playerNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Players.Contains(playerName))
            {
                MessageBox.Show("This player is already on the roster.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Players.Add(playerName);
            MessageBox.Show($"Player '{playerName}' added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            playerNameTextBox.Clear();
        }

        private void RemovePlayer(object sender, RoutedEventArgs e)
        {
            string playerName = playerNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Players.Contains(playerName))
            {   Players.Remove(playerName);
                MessageBox.Show("Player deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                playerNameTextBox.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Player details not found.", " Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            

            playerNameTextBox.Clear();

        }
    }
}