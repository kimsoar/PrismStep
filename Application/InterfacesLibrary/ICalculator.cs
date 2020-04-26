using CommonTypesLibrary;

namespace InterfacesLibrary
{
    public interface ICalculator
    {
        int Add(Arguments args);
        int Div(Arguments args);
        int Execute(CommandTypes commandTypes, Arguments args);
        int Mul(Arguments args);
        int Sub(Arguments args);
    }
}
