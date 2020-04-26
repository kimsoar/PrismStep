using CommonTypesLibrary;
using InterfacesLibrary;
using System;

namespace CalculatorCommandParsingLibrary
{
    public class InputParserService : IInputParserService
    {
        public CommandTypes ParseCommand(string command)
        {
            return ((CommandTypes)Enum.Parse(typeof(CommandTypes), command));
        }
    }
}
