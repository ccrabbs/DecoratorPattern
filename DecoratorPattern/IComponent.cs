namespace DecoratorPattern
{
    interface IComponent // interfaces do not contain public private declarations inside
    {
        string Welcome();
        string Welcome(string nm);
    }
}