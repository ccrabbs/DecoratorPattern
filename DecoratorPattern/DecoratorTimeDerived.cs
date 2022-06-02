using System;

namespace DecoratorPattern
{
    class DecoratorTimeDerived:Component
    {
        public override string Welcome()
        {
            return base.Welcome() + 
                "\nCurrent Time = " + DateTime.Now.ToString();
        }
        public override string Welcome(string nm)
        {
            return base.Welcome(nm) +
                "\nCurrent Time = " + DateTime.Now.ToString(); 
        }
    }
}
