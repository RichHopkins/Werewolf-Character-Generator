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
        public Werewolf werewolf = new Werewolf();
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void ClearAllFields() 
        {
            //Werewolf werewolf = new Werewolf();
        }

        public static void PrintToPDF() 
        {
            
        }

        public static void OpenXMLFile()
        {
            
        }

        public static void SaveXMLFile()
        {

        }

        private void Str_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Strength = StrRating.Value;
        }

        private void Dex_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Dexterity = DexRating.Value;
        }

        private void Sta_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Stamina = StaRating.Value;
        }

        private void Cha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Charisma = ChaRating.Value;
        }

        private void Man_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Manipulation = ManRating.Value;
        }

        private void App_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Appearance = AppRating.Value;
        }

        private void Per_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Perception = PerRating.Value;
        }

        private void Int_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Intelligence = IntRating.Value;
        }

        private void Wit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<int> e)
        {
            werewolf.Wits = WitRating.Value;
        }

        private void Auspice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)Auspice.SelectedItem;
            werewolf.Auspice = item.Content.ToString();

        }

        private void Breed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)Breed.SelectedItem;
            werewolf.Breed = item.Content.ToString();
        }

        private void Tribe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)Tribe.SelectedItem;
            werewolf.Tribe = item.Content.ToString();
        }

        private void CharacterName_TextChanged(object sender, TextChangedEventArgs e)
        {
            werewolf.CharacterName = CharacterName.Text;
        }

        private void PlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            werewolf.PlayerName = PlayerName.Text;
        }

        private void Chronicle_TextChanged(object sender, TextChangedEventArgs e)
        {
            werewolf.Chronicle = Chronicle.Text; 
        }
    
        private void PackName_TextChanged(object sender, TextChangedEventArgs e)
        {
            werewolf.PackName = PackName.Text;
        }

        private void PackTotem_TextChanged(object sender, TextChangedEventArgs e)
        {
            werewolf.PackTotem = PackTotem.Text;
        }

        private void Concept_TextChanged(object sender, TextChangedEventArgs e)
        {
            werewolf.Concept = Concept.Text;
        }

        private void NewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ClearAllFields();
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e) 
        {
            OpenXMLFile();
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e) 
        {
            SaveXMLFile();
        }

        private void PrintMenuItem_Click(object sender, RoutedEventArgs e) {
            PrintToPDF();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
