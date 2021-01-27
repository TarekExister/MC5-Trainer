using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernCombatTrainer.MC5Memory
{
    //this class needs to be checked or updated if needs
    public static class GameMemory
    {
        public static string ProcessName = "WindowsEntryPoint.Windows";
        private static IntPtr LocalPlayer = (IntPtr)Mc5Mem.GetModuleAddress(ProcessName, ProcessName) + 0x181FFA0;

        private static IntPtr ShootFlagBase = (IntPtr)Mc5Mem.GetModuleAddress(ProcessName, ProcessName) + 0x01821A70;
        private static IntPtr TargetTypeBase = (IntPtr)Mc5Mem.GetModuleAddress(ProcessName, ProcessName) + 0x018259D0;

        public enum Target {Enemy = 7, Friendly = 9 };

        public static class VerrPower 
        {
            public static IntPtr Address = (IntPtr)Mc5Mem.GetModuleAddress(ProcessName,ProcessName)+ 0x3B3158;
            public static byte[] EnableOpCodes = { 0xF3, 0x0F, 0x11, 0x46, 0x1C };
            public static byte[] DefaultOpCodes = { 0xF3, 0x0F, 0x11, 0x56, 0x1C };
            public static int OpCodeLength = 5;
        }

        public static class Coordinates
        {
            public static IntPtr XAddress = Mc5Mem.GetPointerAddress(LocalPlayer, new int[] { 0x1F8, 0x38 }, 2);
            public static IntPtr YAddress = XAddress + 4;
            public static IntPtr ZAddress = YAddress + 4;
        }

        public static class AimCoordinates
        {
            public static IntPtr XAddress = Mc5Mem.GetPointerAddress(LocalPlayer, new int[] { 0x1FC, 0xC }, 2);
            public static IntPtr YAddress = XAddress + 4;
            public static IntPtr ZAddress = YAddress + 4;
        }

        public static class CameraRoll
        {
            public static IntPtr Address = Mc5Mem.GetPointerAddress(LocalPlayer, new int[] { 0x1F8, 0x4C }, 2);
        }

        public static class Health 
        {
            public static IntPtr Address = Mc5Mem.GetPointerAddress(LocalPlayer, new int[] { 0x1FC, 0x74,0x13C, 0x14 }, 4);
        }

        public static class TargetType 
        {
            public static IntPtr Address = Mc5Mem.GetPointerAddress(TargetTypeBase, new int[] { 0x75C, 0x38, 0xE8, 0x3D4 , 0x20 , 0x10C , 0x0 }, 7);
        }

        public static class ShootFlag
        {
            public static IntPtr Address = Mc5Mem.GetPointerAddress(ShootFlagBase, new int[] { 0x4, 0xE8, 0x14, 0x34, 0x20, 0x10 , 0x380 }, 7);
        }

        public static class Ammo1 
        {
            public static IntPtr Address = Mc5Mem.GetPointerAddress(LocalPlayer, new int[] { 0x1FC, 0xD8, 0x4, 0x44 }, 4);
        }

        public static class Ammo2
        {
            public static IntPtr Address = Mc5Mem.GetPointerAddress(LocalPlayer, new int[] { 0x1FC, 0xD8, 0x4, 0x48, 0x0 }, 5);
        }

    }
}
