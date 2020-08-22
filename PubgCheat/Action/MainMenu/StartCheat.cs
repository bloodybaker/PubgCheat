using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PubgCheat
{
    public class StartCheat : Action
    {
        private Process[] _aProc;
        private List<Int32> _processId = new List<Int32>();
        
        public void Selection(Printer printer, Router router)
        {
            _aProc = Process.GetProcessesByName("PUBGLite-Win64-Shipping");
            foreach (Process curProcess in _aProc)
            {
                _processId.Add(curProcess.Id);
            }

            Console.WriteLine(_processId.Count);
            if (_processId.Count == 0)
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

        public List<Int32> GetParentID()
        {
            List<Int32> _localProcessId = new List<Int32>();

            foreach (Process p in _aProc)
            {
                _localProcessId.Add(Process.GetProcessById(p.Id).Parent().Id);
            }
            
            return _localProcessId;
        }
    }
}