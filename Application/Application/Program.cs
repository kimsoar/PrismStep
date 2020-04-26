using CalcuatorLibrary;
using CalculatorCommandParsingLibrary;
using CommonServiceLocator;
using InputOutputLibrary;
using InterfacesLibrary;
using Microsoft.Practices.Unity.Configuration;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            UnityConfigurationSection configSection =
                (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            configSection.Configure(container);

            container.RegisterInstance<IServiceLocator>(
                new UnityServiceLocatorAdapter(container));

            //app.config 사용안할때 코드로 하는 방법
            //Calculator calc = new Calculator();
            //container.RegisterInstance<ICalculator>(calc);

            //container.RegisterType<ICalculator, Calculator>();
            //container.RegisterType<IInputService, ConsoleInputService>();
            //container.RegisterType<IOutputService, ConsoleOutputService>();
            //container.RegisterType<IInputParserService, InputParserService>();
            //container.RegisterType<ICalculatorReplLoop, CalculatorReplLoop>();

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
            loop.Run();
        }
    }
}
