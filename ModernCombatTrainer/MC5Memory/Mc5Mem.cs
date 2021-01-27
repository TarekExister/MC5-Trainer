using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;

namespace ModernCombatTrainer.MC5Memory
{
    public static class Mc5Mem
    {
        private static IntPtr handle = IntPtr.Zero;
        private static int pid = 0;

        public static bool AttachProcess(string processName)
        {

            Process[] processList = Process.GetProcesses();
            foreach (Process p in processList)
            {
                if (p.ProcessName.Equals(processName))
                {
                    pid = p.Id;
                    handle = WindowsAPI.Kernel32.OpenProcess(WindowsAPI.Kernel32.ProcessAccessFlags.All, false, pid);
                    return true;
                }
            }
            

            return false;
        }

        public static IntPtr GetModuleAddress(string processName, string moduleName)
        {
            IntPtr modAddress = IntPtr.Zero;
            Process[] procList = Process.GetProcessesByName(processName);
            Process pModule = procList[0];
            foreach (ProcessModule module in pModule.Modules)
            {
                if (module.ModuleName.Equals(moduleName.Insert(moduleName.Length, ".exe")))
                {
                    modAddress = module.BaseAddress;
                }
            }
            return modAddress;
        }

        public static IntPtr GetUWPWindowHandle()
        {
            Process[] procs = Process.GetProcessesByName("ApplicationFrameHost");
            return procs[0].MainWindowHandle;
        }

        public static byte[] ReadBytes(IntPtr address, int size)
        {
            byte[] bts = new byte[size];
            IntPtr readbts = IntPtr.Zero;
            WindowsAPI.Kernel32.ReadProcessMemory(handle, address, bts, size, out readbts);
            return bts;
        }

        public static void WriteBytes(IntPtr address, byte[] buffer, int size)
        {
            IntPtr readbts = IntPtr.Zero;
            WindowsAPI.Kernel32.WriteProcessMemory(handle, address, buffer, size, out readbts);
        }

        unsafe public static IntPtr GetPointerAddress(IntPtr BaseAddress, int[] offsets, int PointerLevel)
        {
            IntPtr address = BaseAddress;
            IntPtr tmp = IntPtr.Zero;

            for (int x = 0; x < PointerLevel; x++)
            {
                byte[] buffer = ReadBytes(address, sizeof(IntPtr));
                tmp = (IntPtr)(BitConverter.ToInt32(buffer, 0));
                address = tmp + offsets[x];
            }
            return address;
        }

        unsafe public static IntPtr GetPointerAddress64Bit(IntPtr BaseAddress, int[] offsets, int PointerLevel)
        {
            IntPtr address = BaseAddress;
            IntPtr tmp = IntPtr.Zero;

            for (int x = 0; x < PointerLevel; x++)
            {
                byte[] buffer = ReadBytes(address, sizeof(IntPtr));
                tmp = (IntPtr)(BitConverter.ToInt64(buffer, 0));
                address = tmp + offsets[x];
            }
            return address;
        }

        unsafe public static T Read<T>(IntPtr address)
        {
            object val = 0;

            if (typeof(T) == typeof(int))
            {
                val = BitConverter.ToInt32(ReadBytes(address, sizeof(int)), 0);
            }
            else if (typeof(T) == typeof(uint))
            {
                val = BitConverter.ToUInt32(ReadBytes(address, sizeof(uint)), 0);
            }
            else if (typeof(T) == typeof(long))
            {
                val = BitConverter.ToInt64(ReadBytes(address, sizeof(long)), 0);
            }
            else if (typeof(T) == typeof(byte))
            {
                val = ReadBytes(address, sizeof(byte))[0];
            }
            else if (typeof(T) == typeof(IntPtr))
            {
                val = BitConverter.ToUInt32(ReadBytes(address, sizeof(IntPtr)), 0);
            }
            else if (typeof(T) == typeof(UIntPtr))
            {
                val = BitConverter.ToUInt64(ReadBytes(address, sizeof(UIntPtr)), 0);
            }
            else if (typeof(T) == typeof(float))
            {
                val = BitConverter.ToSingle(ReadBytes(address, sizeof(float)), 0);
            }
            else if (typeof(T) == typeof(double))
            {
                val = BitConverter.ToDouble(ReadBytes(address, sizeof(double)), 0);
            }

            return (T)Convert.ChangeType(val, typeof(T));
        }


        unsafe public static void Write<T>(IntPtr address, T value)
        {

            if (typeof(T) == typeof(int))
            {
                int val = (int)Convert.ChangeType(value, typeof(int));
                byte[] buffer = BitConverter.GetBytes(val);
                WriteBytes(address, buffer, sizeof(int));

            }
            else if (typeof(T) == typeof(uint))
            {
                uint val = (uint)Convert.ChangeType(value, typeof(uint));
                byte[] buffer = BitConverter.GetBytes(val);
                WriteBytes(address, buffer, sizeof(uint));
            }
            else if (typeof(T) == typeof(long))
            {
                long val = (long)Convert.ChangeType(value, typeof(long));
                byte[] buffer = BitConverter.GetBytes(val);
                WriteBytes(address, buffer, sizeof(long));
            }
            else if (typeof(T) == typeof(float))
            {
                float val = (float)Convert.ChangeType(value, typeof(float));
                byte[] buffer = BitConverter.GetBytes(val);
                WriteBytes(address, buffer, sizeof(float));
            }
            else if (typeof(T) == typeof(double))
            {
                double val = (double)Convert.ChangeType(value, typeof(double));
                byte[] buffer = BitConverter.GetBytes(val);
                WriteBytes(address, buffer, sizeof(double));
            }
            else if (typeof(T) == typeof(byte))
            {
                byte val = (byte)Convert.ChangeType(value, typeof(byte));
                byte[] buffer = BitConverter.GetBytes(val);
                WriteBytes(address, buffer, sizeof(byte));
            }
            else if (typeof(T) == typeof(IntPtr))
            {
                IntPtr val = (IntPtr)Convert.ChangeType(value, typeof(IntPtr));
                byte[] buffer = BitConverter.GetBytes((uint)val);
                WriteBytes(address, buffer, sizeof(IntPtr));
            }
            else if (typeof(T) == typeof(UIntPtr))
            {
                UIntPtr val = (UIntPtr)Convert.ChangeType(value, typeof(UIntPtr));
                byte[] buffer = BitConverter.GetBytes((uint)val);
                WriteBytes(address, buffer, sizeof(UIntPtr));
            }
        }
    }
}
