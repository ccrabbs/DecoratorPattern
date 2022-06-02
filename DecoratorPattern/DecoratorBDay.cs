namespace DecoratorPattern
{
    class DecoratorBDay : BaseDecorator
    {
        public DecoratorBDay(IComponent ic)
            : base(ic) { }

        public override string Welcome()
        {
            return icomp.Welcome() +
                "\nHappy Birthday..";
        }
        public override string Welcome(string nm)
        {
            return icomp.Welcome(nm) +
                "\nHappy Birthday..";
        }
    }
}