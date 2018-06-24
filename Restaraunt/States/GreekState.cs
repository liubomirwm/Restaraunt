using Restaraunt.CondimentDecorators;
using Restaraunt.Products;
using Restaraunt.Products.Drinks;
using Restaraunt.Products.Seafoods;
using Restaraunt.Products.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.States
{
    public class GreekState : IState
    {
        List<string> mainMenu = new List<string>() { "sweets", "drinks", "seafood" };
        List<string> sweetsMenu = new List<string>() { "Baklava", "Bougatsa" };
        List<string> drinksMenu = new List<string>() { "Frappe", "Ellinikos", "Retsina" };
        List<string> seafoodMenu = new List<string>() { "Greek Cod", "Greek Mussels", "Lobster Pasta" };

        public string GetGreeting()
        {
            return "Γειά σου! Καλή όρεξη";
        }

        public List<string> GetMainMenuList()
        {
            return this.mainMenu;
        }

        public IProductFactory GetProductFactory()
        {
            return new GreekFactory();
        }

        public List<string> GetSecondaryMenuList(string selectedCategory)
        {
            switch (selectedCategory)
            {
                case "sweets":
                    return this.sweetsMenu;
                case "drinks":
                    return this.drinksMenu;
                case "seafood":
                    return this.seafoodMenu;
                default:
                    throw new Exception("case not handled");
            }
        }

        public class GreekFactory : IProductFactory
        {
            public Product GetProduct(string selectedProduct)
            {
                switch (selectedProduct)
                {
                    case "Baklava":
                        return new Baklava();
                    case "Bougatsa":
                        return new Bougatsa();
                    case "Frappe":
                        return new Frappe();
                    case "Ellinikos":
                        return new Ellinikos();
                    case "Retsina":
                        return new Retsina();
                    case "Greek Cod":
                        return new GreekCod();
                    case "Greek Mussels":
                        return new GreekMussels();
                    case "Lobster Pasta":
                        return new LobsterPasta();
                    default:
                        throw new Exception("case not handled");
                }
            }
        }
    }
}
