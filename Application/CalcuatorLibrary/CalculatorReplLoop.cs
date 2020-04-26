using CommonServiceLocator;
using CommonTypesLibrary;
using InterfacesLibrary;
using System.Collections.Generic;

namespace CalcuatorLibrary
{
    public class CalculatorReplLoop : ICalculatorReplLoop
    {
        public CalculatorReplLoop(
            IServiceLocator locator,
            ICalculator calculator,
            IInputService inputService,
            IInputParserService inputParserService)
        {
            this.calculator = calculator;
            this.inputService = inputService;
            this.inputParserService = inputParserService;

            outputServices = new List<IOutputService>(
                locator.GetAllInstances<IOutputService>());
        }
        IInputService inputService;
        List<IOutputService> outputServices;
        ICalculator calculator;
        IInputParserService inputParserService;

        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = inputParserService.ParseCommand(command);

                    Arguments arguments = inputService.ReadArguments();

                    WriteMessageToAllOutputServices(calculator.Execute(commandType, arguments).ToString());
                }
                catch
                {
                    WriteMessageToAllOutputServices("Mistake!");
                }
            }
        }

        void WriteMessageToAllOutputServices(string message)
        {
            foreach (IOutputService outputSerivce in outputServices)
            {
                outputSerivce.WriteMessage(message);
            }
        }
    }
}
