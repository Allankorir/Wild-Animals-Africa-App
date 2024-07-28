using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Linq;
using Wildanimals.Models;

namespace Wildanimals
{
    public partial class MainWindow : Window
    {
        private AnimalData animalData;

        public MainWindow()
        {
            InitializeComponent();
            animalData = new AnimalData();
            this.DataContext = animalData;
        }
        // Author: Allan Korir
        //Desc: Clean Architecture wpf

        //Home button click
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            // Reset to default layout
            this.DataContext = null;
            this.DataContext = animalData;
        }
        //Animal click
        private void Animal_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var animalName = button.CommandParameter.ToString();
            var selectedAnimal = animalData.GetAnimalByName(animalName);

            animalData.SelectedAnimal = selectedAnimal;
            this.DataContext = null;
            this.DataContext = animalData;
        }
        //Info btn click
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Africa Epic Adventure\nExplore the wild!", "Info", MessageBoxButton.OK);
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            // Implement settings functionality
        }
    }
}
