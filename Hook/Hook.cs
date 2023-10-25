using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FreeBNS.Hook
{
    public class ZDYHook
    {
        public struct Keyboard_LL_Hook_Data
        {
            public UInt32 vkCode;
            public UInt32 scanCode;
            public UInt32 flags;
            public UInt32 time;
            public IntPtr extraInfo;
        }

        public struct Mouse_LL_Hook_Data
        {
            public long yx;
            public readonly int mouseData;
            public readonly uint flags;
            public readonly uint time;
            public readonly IntPtr dwExtraInfo;
        }

        private static IntPtr pKeyboardHook = IntPtr.Zero;
        private static IntPtr pMouseHook = IntPtr.Zero;
        //钩子委托声明
        public delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);
        private static HookProc keyboardHookProc;
        private static HookProc mouseHookProc;
        //安装钩子方法
        private static bool InsertKeyboardHook()
        {
            if (pKeyboardHook == IntPtr.Zero)//不存在钩子时
            {
                //创建钩子
                keyboardHookProc = keyboardHookCallback;
                pKeyboardHook = SetWindowsHookEx(13, //13表示全局键盘事件。
                    keyboardHookProc,
                    (IntPtr)0,
                    0);

                if (pKeyboardHook == IntPtr.Zero)//如果安装钩子失败
                {
                    removeKeyboardHook();
                    return false;
                }
            }

            return true;
        }
        internal static bool InsertHook()
        {
            bool iRet;
            iRet = InsertKeyboardHook();
            if (!iRet)
            {
                return false;
            }

            iRet = InsertMouseHook();
            if (!iRet)
            {
                removeKeyboardHook();
                return false;
            }
            return true;
        }

        private static bool InsertMouseHook()
        {
            if (pMouseHook == IntPtr.Zero)
            {
                mouseHookProc = mouseHookCallback;
                pMouseHook = SetWindowsHookEx(14, //14表示全局鼠标事件
                    mouseHookProc,
                    (IntPtr)0,
                    0);
                if (pMouseHook == IntPtr.Zero)
                {
                    removeMouseHook();
                    return false;
                }
            }

            return true;
        }

        internal static bool RemoveHook()
        {
            bool iRet;
            iRet = removeKeyboardHook();
            if (iRet)
            {
                iRet = removeMouseHook();
            }

            return iRet;
        }

        private static bool removeKeyboardHook()
        {
            if (pKeyboardHook != IntPtr.Zero)
            {
                if (UnhookWindowsHookEx(pKeyboardHook))
                {
                    pKeyboardHook = IntPtr.Zero;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static bool removeMouseHook()
        {
            if (pMouseHook != IntPtr.Zero)
            {
                if (UnhookWindowsHookEx(pMouseHook))
                {
                    pMouseHook = IntPtr.Zero;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        //安装钩子
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr pInstance, int threadID);
        //卸载钩子
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(IntPtr pHookHandle);
        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam); //parameter 'hhk' is ignored.
        private static int mouseHookCallback(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code < 0)
            {
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
            }

            Mouse_LL_Hook_Data mhd = (Mouse_LL_Hook_Data)Marshal.PtrToStructure(lParam, typeof(Mouse_LL_Hook_Data));
            if (wParam.ToInt32() > 512)
            {
                System.Diagnostics.Debug.WriteLine($"mouse event:{wParam}, ({mhd.yx & 0xffffffff},{mhd.yx >> 32})");
            }
            return ((int)wParam);
        }

        public static Mouse_LL_Hook_Data GetMouseEvent(Mouse_LL_Hook_Data mhd)
        {
            
            return mhd;
        }


        private static int keyboardHookCallback(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code < 0)
            {
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
            }

            Keyboard_LL_Hook_Data khd = (Keyboard_LL_Hook_Data)Marshal.PtrToStructure(lParam, typeof(Keyboard_LL_Hook_Data));
            System.Diagnostics.Debug.WriteLine($"key event:{wParam}, key code:{khd.vkCode}, event time:{khd.time}");
            return 0;
        }
    }
}
