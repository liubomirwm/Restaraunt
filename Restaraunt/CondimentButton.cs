using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Restaraunt
{
    public class CondimentButton
    {
        public string text = "Click me";
        public Type decoratorType;
        public RoutedEventHandler clickHandler;
        public void OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.product = (Product)Activator.CreateInstance(this.decoratorType, MainWindow.product);
            Binding binding = new Binding("Price");
            binding.Source = MainWindow.product;
            ((MainWindow)Application.Current.MainWindow).priceDigitTextBlock.SetBinding(TextBlock.TextProperty, binding);
        }

        public CondimentButton(string buttonText, Type decoratorType)
        {
            this.decoratorType = decoratorType;
            this.text = buttonText;
            this.clickHandler = OnClick;
        }
    }
}
