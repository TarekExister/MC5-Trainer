using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernCombatTrainer.GameModel.Weapons
{
    public static class UnlimitedVerrPower
    {
        public static void Enable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName)) 
            {
                MC5Memory.Mc5Mem.WriteBytes(MC5Memory.GameMemory.VerrPower.Address,
                    MC5Memory.GameMemory.VerrPower.EnableOpCodes,
                    MC5Memory.GameMemory.VerrPower.OpCodeLength);
            }
            
        }
        public static void Disable()
        {
            if (MC5Memory.Mc5Mem.AttachProcess(MC5Memory.GameMemory.ProcessName))
            {
                MC5Memory.Mc5Mem.WriteBytes(MC5Memory.GameMemory.VerrPower.Address,
                    MC5Memory.GameMemory.VerrPower.DefaultOpCodes,
                    MC5Memory.GameMemory.VerrPower.OpCodeLength);
            }
        }
    }
}
