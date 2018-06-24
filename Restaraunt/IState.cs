using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    public interface IState
    {
        List<string> GetMainMenuList();
        List<string> GetSecondaryMenuList(string selectedCategory);
        IProductFactory GetProductFactory();
        string GetGreeting();
    }
}
