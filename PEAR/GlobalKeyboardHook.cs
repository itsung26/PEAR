using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEAR
{
    public sealed class GlobalKeyboardHook : IDisposable
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        private readonly LowLevelKeyboardProc hookCallback;
        private IntPtr hookHandle = IntPtr.Zero;

        public event Action<string> KeyPressed;

        public GlobalKeyboardHook()
        {
            hookCallback = HandleKeyPress;
            hookHandle = InstallHook(hookCallback);
        }

        public void Dispose()
        {
            if (hookHandle != IntPtr.Zero)
            {
                UnhookWindowsHookEx(hookHandle);
                hookHandle = IntPtr.Zero;
            }
        }

        private IntPtr HandleKeyPress(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && IsKeyDown(wParam))
            {
                Keys key = (Keys)Marshal.ReadInt32(lParam);
                if (!IsModifierKey(key))
                {
                    KeyPressed?.Invoke(key.ToString());
                }
            }

            return CallNextHookEx(hookHandle, nCode, wParam, lParam);
        }

        private static bool IsKeyDown(IntPtr wParam)
        {
            return wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN;
        }

        private static bool IsModifierKey(Keys key)
        {
            return key == Keys.ShiftKey || key == Keys.ControlKey || key == Keys.Menu
                || key == Keys.LWin || key == Keys.RWin;
        }

        private static IntPtr InstallHook(LowLevelKeyboardProc callback)
        {
            using (Process process = Process.GetCurrentProcess())
            using (ProcessModule module = process.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, callback, GetModuleHandle(module.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
