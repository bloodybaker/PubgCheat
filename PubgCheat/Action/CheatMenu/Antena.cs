using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Memory;
using PubgCheat.CheatSource;

namespace PubgCheat.CheatMenu
{
    public class Antena : Action
    {
        private ProcessTerminator _processTerminator = new ProcessTerminator();
        private BackgroundWorker _backgroundWorker = new BackgroundWorker();
        private CheatTable _cheat = new CheatTable();
        private Adress _currentAdress = new Adress();
        private Mem _mem = new Mem();
        
        public void Selection(Printer printer, Router router)
        {
            
            int pId = 0;
            bool open = false;
            List<int> ProcPID = _processTerminator.GetpId();
            List<int> ProcparentPID = _processTerminator.GetParentID();
            Console.WriteLine(ProcparentPID.Count);
            int a = 0;
            if (ProcPID[0] == ProcparentPID[a])
                ProcPID.RemoveAt(0);
            else if (ProcPID[0] == ProcparentPID[a+1])
                ProcPID.RemoveAt(0);
            pId = ProcPID.FirstOrDefault();
            if (pId > 0)
            {
                printer.SuccessMessage();
                if (_mem.IsAdmin())
                {
                    ProcPID = null;
                    ProcparentPID = null;
                }
                SetCheat(_cheat.ant, _cheat.anton, _currentAdress.ant);
            }
        }
        public void SetCheat(String cheatPattern, string cheatOverride, Int32 type)
        {
            if (_backgroundWorker.IsBusy != true)
            {
                List<object> arguments = new List<object>();
                arguments.Add(cheatPattern);
                arguments.Add(cheatOverride);
                arguments.Add(type);
                string adress = "";
                while (!adress.Equals("0"))
                {
                    var res = AoBScan(cheatPattern);
                    adress = res.Result.FirstOrDefault().ToString("x");
                    _currentAdress.antLST.Add(adress); //?
                    _mem.WriteMemory(adress, "bytes", cheatOverride);
                }
            }
        }
        public Task<IEnumerable<long>> AoBScan(string search)
        {
            return _mem.AoBScan(0x10000000000, 0x2FFFFFFFFFF,search, true, false);
        }
        
    }
}