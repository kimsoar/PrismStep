using CommonTypesLibrary;

namespace InterfacesLibrary
{
    public interface IInputService
    {
        string ReadCommand();
        Arguments ReadArguments();
    }
}
