using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PubgCheat
{
    public class StartCheat : Action
    {
        ProcessTerminator _processTerminator = new ProcessTerminator();

        public void Selection(Printer printer, Router router)
        {
            
            if (_processTerminator.IsEmpty())
            {
                printer.ErrorMessage();
            }
            else
            {
                printer.PrintCheatMenu();
                router.GetMenu().Clear();
                router.GenerateFuncs();
                router.ScanInput();
            }
        }
    }
}