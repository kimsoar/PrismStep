using InterfacesLibrary;
using System;

namespace InputOutputLibrary
{
    public class ConsoleOutputService : IOutputService
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
