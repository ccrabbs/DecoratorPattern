using System;

namespace DecoratorPattern
{
    class DecoratorTimeBDayDerived : Component
    {
        public override string Welcome(string nm)
        {
            return base.Welcome(nm) +
                "\n Current Time =" + DateTime.Now.ToString() +
                "\n Happy Birthday";
        }
    }
}