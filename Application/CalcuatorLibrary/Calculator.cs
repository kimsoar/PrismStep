using CalcuatorLibrary;
using CommonTypesLibrary;
using InterfacesLibrary;
using System;

namespace CalcuatorLibrary
{
    public class Calculator : ICalculator
    {
        public int Execute(CommandTypes commandTypes, Arguments args)
        {
            switch (commandTypes)
            {
                case CommandTypes.Add:
                    return (Add(args));
                case CommandTypes.Sub:
                    return (Sub(args));
                case CommandTypes.Mul:
                    return (Mul(args));
                case CommandTypes.Div:
                    return (Div(args));
                default:
                    throw new InvalidOperationException();
            }
        }

        public int Add(Arguments args)
        {
            return (args.X + args.Y);
        }

        public int Sub(Arguments args)
        {
            return (args.X - args.Y);
        }

        public int Mul(Arguments args)
        {
            return (args.X * args.Y);
        }

        public int Div(Arguments args)
        {
            return (args.X / args.Y);
        }

    }
}
