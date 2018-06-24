using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    public abstract class Product : INotifyPropertyChanged
    {
        private string name;
        private decimal price;
        private List<CondimentButton> condimentButtons = new List<CondimentButton>();

        public virtual string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public virtual decimal Price
        {
            get { return this.price; }
            private set
            {
                this.price = value;
                OnPropertyChanged("Price");
            }
        }

        public List<CondimentButton> CondimentButtons { get => condimentButtons; protected set => condimentButtons = value; }

        public Product(string name, decimal price, List<CondimentButton> condimentButtons)
        {
            this.Name = name;
            this.Price = price;
            if (condimentButtons != null)
            {
                foreach (CondimentButton condimentButton in condimentButtons)
                {
                    this.condimentButtons.Add(condimentButton);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
