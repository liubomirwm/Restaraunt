using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Restaraunt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IState state = StateFactory.GetState();
        public static ObservableCollection<string> mainMenuItems = new ObservableCollection<string>(state.GetMainMenuList());
        static ObservableCollection<string> secondaryMenuItems;
        static IProductFactory productFactory = state.GetProductFactory();
        static string greeting = state.GetGreeting();
        static internal Product product;
        static ObservableCollection<CondimentButton> condimentButtons = new ObservableCollection<CondimentButton>();
        static ObservableCollection<Button> buttons = new ObservableCollection<Button>();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            mainMenuComboBox.ItemsSource = mainMenuItems;
            greetingTextBlock.Text = greeting;
        }

        private void mainMenuComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (sender as ComboBox).SelectedItem as string;
            List<string> secondaryMenuList = state.GetSecondaryMenuList(selectedItem);
            secondaryMenuItems = new ObservableCollection<string>(secondaryMenuList);
            product = null;
            secondaryMenuComboBox.Visibility = Visibility.Visible;
            secondaryMenuComboBox.ItemsSource = secondaryMenuItems;
            //priceTextBlock.Text = "Price:";
        }

        private void secondaryMenuComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox senderAsComboBox = sender as ComboBox;
            string selectedItem = senderAsComboBox.SelectedItem as string;
            if (selectedItem == null)
            {
                return;
            }
            product = productFactory.GetProduct(selectedItem);
            condimentButtons.Clear();
            foreach (CondimentButton condimentButton in product.CondimentButtons)
            {
                condimentButtons.Add(condimentButton);
            }
            Binding binding = new Binding("Price");
            binding.Source = product;
            priceDigitTextBlock.SetBinding(TextBlock.TextProperty, binding);
            buttons.Clear();
            foreach (CondimentButton condimentButton in condimentButtons)
            {
                Button button = new Button();
                button.Click += condimentButton.clickHandler;
                button.Content = condimentButton.text;
                button.HorizontalAlignment = HorizontalAlignment.Center;
                button.VerticalAlignment = VerticalAlignment.Center;
                button.Padding = new Thickness(5);
                button.FontSize = 15;
                buttons.Add(button);
            }
            condimentsItemsControl.ItemsSource = buttons;
            //priceTextBlock.Text = $"Price: {product.Price}$";
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            if (product == null)
            {
                MessageBox.Show($"You have to select a meal first.", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show($"Your order: {product.Name}\nCost: {product.Price}$", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
