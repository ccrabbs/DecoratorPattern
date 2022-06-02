namespace DecoratorPattern
{
    class DecoratorBDayDerived : Component
    {
        public override string Welcome()
        {
            return base.Welcome() +
                "\n Happy Birthday";
        }
        public override string Welcome(string nm)
        {
            return base.Welcome(nm) +
                "\n Happy Birthday";
        }
    }
}