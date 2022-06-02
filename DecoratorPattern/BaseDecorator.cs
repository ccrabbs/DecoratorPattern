namespace DecoratorPattern
{
    abstract class BaseDecorator : IComponent
    {
        protected IComponent icomp = null;
        public BaseDecorator(IComponent ic) // aggregations
        {
            icomp = ic;
        }

        public abstract string Welcome();


        public abstract string Welcome(string nm);

    }
}