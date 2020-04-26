using CommonTypesLibrary;

namespace InterfacesLibrary
{
    public interface IInputParserService
    {
        CommandTypes ParseCommand(string command);
    }
}