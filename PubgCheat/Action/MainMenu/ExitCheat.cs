using System;

namespace PubgCheat
{
    public class ExitCheat : Action
    {
        public void Selection(Printer printer, Router router)
        {
            printer.ExitMessage();
            Environment.Exit(0);
        }
    }
}