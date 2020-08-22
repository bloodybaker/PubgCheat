using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Memory;
using PubgCheat.CheatSource;

namespace PubgCheat.CheatMenu
{
    public class Antena : Action
    {
        private ProcessTerminator _processTerminator = new ProcessTerminator();
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private CheatTable _cheat = new CheatTable();
        private Adress _currentAdress = new Adress();
        private Mem _mem = new Mem();
        
        public void Selection(Printer printer, Router router)
        {
            
            int pId = 0;
            bool open = false;
            List<int> ProcPID = _processTerminator.GetpId();
            List<int> ProcparentPID = _processTerminator.GetParentID();
            int a = 0;
            if (ProcPID[0] == ProcparentPID[a])
                ProcPID.RemoveAt(0);
            else if (ProcPID[0] == ProcparentPID[a+1])
                ProcPID.RemoveAt(0);
            pId = ProcPID.FirstOrDefault();
            open = _mem.OpenProcess(pId);
            if (pId > 0)
            {
                printer.SuccessMessage();
                if (open == true && _mem.IsAdmin())
                {
                    ProcPID = null;
                    ProcparentPID = null;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                SetCheat(_cheat.ant, _cheat.anton, _currentAdress.ant);
            }
        }
        public void SetCheat(String cheatPattern, string cheatOverride, Int32 type)
        {
            if (backgroundWorker.IsBusy != true)
            {
                List<object> arguments = new List<object>();
                arguments.Add(cheatPattern);
                arguments.Add(cheatOverride);
                arguments.Add(type);
                backgroundWorker.RunWorkerAsync(arguments);
            }
        }
    }
}