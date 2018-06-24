using Restaraunt.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    public class ItalianState : IState
    {
        List<string> mainMenu = new List<string>() { "soup", "pasta", "pizza", "drink" };
        List<string> soupsMenu = new List<string>() { "Tuscan Tortellini Soup", "Chicken Parm Soup", "Sausage and White Bean Soup" };
        List<string> pastasMenu = new List<string>() { "Spaghetti and Meatballs", "Caprese Lasagna", "Tomato Butter Spaghetti" };
        List<string> pizzasMenu = new List<string>() { "Margherita", "Marinara", "Capricciosa" };
        List<string> drinksMenu = new List<string>() { "Vermouth", "Campari", "Lavazza" };

        public string GetGreeting()
        {
            return "Ciao. Buon apetito!";
        }

        public List<string> GetMainMenuList()
        {
            return this.mainMenu;
        }

        public IProductFactory GetProductFactory()
        {
            return new ItalianFactory();
        }

        public List<string> GetSecondaryMenuList(string selectedCategory)
        {
            switch (selectedCategory)
            {
                case "soup":
                    return this.soupsMenu;
                case "pasta":
                    return this.pastasMenu;
                case "pizza":
                    return this.pizzasMenu;
                case "drink":
                    return this.drinksMenu;
                default:
                    throw new Exception("case not handled");
            }
        }

        public class ItalianFactory : IProductFactory
        {
            public Product GetProduct(string selectedProduct)
            {
                switch (selectedProduct)
                {
                    case "Tuscan Tortellini Soup":
                        return new TuscanTortelliniSoup();
                    case "Chicken Parm Soup":
                        return new ChickenParmSoup();
                    case "Sausage and White Bean Soup":
                        return new SausageAndWhiteBeanSoup();
                    case "Spaghetti and Meatballs":
                        return new SpaghettiAndMeatballs();
                    case "Caprese Lasagna":
                        return new CapreseLasagna();
                    case "Tomato Butter Spaghetti":
                        return new TomatoButterSpaghetti();
                    case "Margherita":
                        return new Margherita();
                    case "Marinara":
                        return new Marinara();
                    case "Capricciosa":
                        return new Capricciosa();
                    case "Vermouth":
                        return new Vermouth();
                    case "Campari":
                        return new Campari();
                    case "Lavazza":
                        return new Lavazza();
                    default:
                        throw new Exception("case not handled");
                }
            }
        }
    }
}
