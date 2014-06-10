using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace PlayerForTeatr
{
    class KeyboardLogger
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookProcDel callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll")]
        static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32.dll")]
        static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern short GetKeyState(int vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern short GetAsyncKeyState(int vKey);
        

        public delegate int KeyboardHookProcDel(int code, int wParam, ref keyboardHookStruct lParam);
        public struct keyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        const int WH_KEYBOARD_LL = 13;
        const byte VK_SHIFT = 0x10;
        const byte VK_CAPITAL = 0x14;

        private IntPtr mHookId = IntPtr.Zero;
        private KeyboardHookProcDel mHookProc;

        public event KeyEventHandler GregKeyDown;


        public void StartKeyLogger()
        {
            mHookProc = new KeyboardHookProcDel(HookProc);
            IntPtr hInstance = LoadLibrary("User32");
            mHookId = SetWindowsHookEx(WH_KEYBOARD_LL, mHookProc, hInstance, 0);
        }
        public void StopKeyLogger()
        {
            UnhookWindowsHookEx(mHookId);
        }
        private int HookProc(int code, int wParam, ref keyboardHookStruct lParam)
        {
            if (code >= 0 && lParam.vkCode != 0x74)
            {
                if (GregKeyDown != null)
                {
                    Keys keys = Keys.A;
                    bool found = false;
                                  
                    switch (lParam.vkCode)
                    {
                        case 0x25:
                            keys = Keys.Left;
                            found = true;
                            break;
                        case 0x26:
                            keys = Keys.Up;
                            found = true;
                            break;
                        case 0x27:
                            keys = Keys.Right;
                            found = true;
                            break;
                        case 0x28:
                            keys = Keys.Down;
                            found = true;
                            break;
                        case 0xd:
                            //keys = Keys.Return;
                            //found = true;
                            break;
                    }
                    if (found  == true)
                    {                        
                        short retVal = GetKeyState(lParam.vkCode);
                       
                        if ((retVal & 0x80) == 0)
                        {
                            // arrow down
                            KeyEventArgs args = new KeyEventArgs(keys);
                            GregKeyDown(this, args);
                            Console.WriteLine("key down");
                        }
                        else
                        {
                            // arrow up  
                            Console.WriteLine("key up");
                        }                   
                    }
                }     
            }
            return CallNextHookEx(mHookId, code, wParam, ref lParam);

        }

    }
}
