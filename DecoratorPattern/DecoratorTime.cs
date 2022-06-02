using System;

namespace DecoratorPattern
{
    class DecoratorTime:BaseDecorator
    {
        // constructors are not inherited in c##
        public DecoratorTime (IComponent ic)
            :base(ic)
    {
    }
        public override string Welcome()
        {
            return icomp.Welcome() + // call existing method
                "\nCurrent Time = " + DateTime.Now.ToString(); // decorator
        }
        public override string Welcome(string me)
        {
            return icomp.Welcome(me) + // call existing method
                "\nCurrent Time = " + DateTime.Now.ToString();
        }
    }
}