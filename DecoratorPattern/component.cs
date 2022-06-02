namespace DecoratorPattern
{
    class Component : IComponent
    {
        virtual public string Welcome()
        {
            return "Welcome to the Group..";
        }

        virtual public string Welcome(string nm)
        {
            return nm + ", Welcome to the Group..";
        }
    }
}