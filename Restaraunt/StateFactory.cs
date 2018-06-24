using Restaraunt.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    public class StateFactory
    {
        static readonly StateName currentState = StateName.Greek;

        public static IState GetState()
        {
            switch (currentState)
            {
                case StateName.Italian:
                    return new ItalianState();
                case StateName.Greek:
                    return new GreekState();
                default:
                    throw new Exception("case not handled");
            }
        }
    }
}
