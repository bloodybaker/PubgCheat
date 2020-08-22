using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PubgCheat
{
    public class ProcessTerminator
    {
        private Process[] _aProc;

        public bool IsEmpty()
        {
            ProcessOperate();
            List<Int32> procID = new List<Int32>();
            foreach (Process proc in _aProc)
            {
                procID.Add(proc.Id);
            }
            if (procID.Capacity < 0)
            {
                return true;
            }
            return false;
        }
        
        public List<Int32> GetpId()
        {
            ProcessOperate();
            List<Int32> procID = new List<Int32>();
            foreach (Process proc in _aProc)
            {
                procID.Add(proc.Id);
            }
            return procID;
        }
        
        
        public List<Int32> GetParentID()
        {
            ProcessOperate();
            List<Int32> procID = new List<Int32>();
            foreach (Process p in _aProc)
            {
                procID.Add(Process.GetProcessById(p.Id).Parent().Id);
            }
            return procID;
        }

        public void ProcessOperate()
        {
            _aProc = Process.GetProcessesByName("PUBGLite-Win64-Shipping");
        }
    }
}