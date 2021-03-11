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

namespace Werewolf_Character_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void ClearAllFields() {
            
        }

        private void Str_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            
        }

        private void Dex_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Sta_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Cha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Man_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void App_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Per_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Int_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Wit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {

        }

        private void Auspice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Breed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tribe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CharacterName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Chronicle_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PackName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PackTotem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Concept_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e) 
        {
            ClearAllFields();
            Werewolf werewolf = new();
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e) {
            ClearAllFields();
            Werewolf werewolf = new();
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e) {

        }

        private void PrintMenuItem_Click(object sender, RoutedEventArgs e) {

        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
