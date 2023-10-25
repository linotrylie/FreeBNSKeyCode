using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeBNS.Hook
{

    public class MouseHook
    {
        private Point point;
        private Point Point
        {
            get { return point; }
            set
            {
                if (point != value)
                {
                    point = value;
                    if (MouseMoveEvent != null)
                    {
                        var e = new MouseEventArgs(MouseButtons.None, 0, point.X, point.Y, 0);
                        MouseMoveEvent(this, e);
                    }
                }
            }
        }
        private int hHook;
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_LBUTTONUP = 514;

        private const int WM_RBUTTONDOWN = 516;
        private const int WM_RBUTTONUP = 517;

        private const int WM_MIDBUTTONUP = 520;
        private const int WM_MIDBUTTONDOWN = 519;

        private const int WM_S1BUTTONUP = 524;
        private const int WM_S1BUTTONDOWN = 523;

        //private const int WM_S2UTTONDOWN = 514;
        //private const int WM_S2UTTONUP = 514;

        public const int WH_MOUSE_LL = 14;
        public Win32Api.HookProc hProc;
        public MouseHook()
        {
            this.Point = new Point();
        }
        public int SetHook()
        {
            hProc = new Win32Api.HookProc(MouseHookProc);
            hHook = Win32Api.SetWindowsHookEx(WH_MOUSE_LL, hProc, IntPtr.Zero, 0);
            return hHook;
        }
        public void UnHook()
        {
            Win32Api.UnhookWindowsHookEx(hHook);
        }
        private int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            Win32Api.MouseHookStruct MyMouseHookStruct = (Win32Api.MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(Win32Api.MouseHookStruct));
            if (nCode < 0)
            {
                return Win32Api.CallNextHookEx(hHook, nCode, wParam, lParam);
            }
            else
            {
                MouseButtons button = MouseButtons.None;
                MouseEventArgs e = null;
                int clickCount = 0;
                /*System.Diagnostics.Debug.WriteLine($"mouse event:{wParam}, {MyMouseHookStruct.wHitTestCode}, {MyMouseHookStruct.dwExtraInfo}, {MyMouseHookStruct.hwnd})");*/
                switch ((Int32)wParam)
                {
                    case WM_LBUTTONDOWN:
                        button = MouseButtons.Left;
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickDownEvent(this, e);
                        break;
                    case WM_RBUTTONDOWN:
                        button = MouseButtons.Right;
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickDownEvent(this, e);
                        break;
                    case WM_MIDBUTTONDOWN:
                        button = MouseButtons.Middle;
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickDownEvent(this, e);
                        break;
                    case WM_S1BUTTONDOWN:
                        if (MyMouseHookStruct.hwnd == 131072)
                        {
                            button = MouseButtons.XButton1;
                        }
                        else
                        {
                            button = MouseButtons.XButton2;
                        }
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickDownEvent(this, e);
                        break;
                    case WM_LBUTTONUP:
                        button = MouseButtons.Left;
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickUpEvent(this, e);
                        break;
                    case WM_RBUTTONUP:
                        button = MouseButtons.Right;
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickUpEvent(this, e);
                        break;
                    case WM_MIDBUTTONUP:
                        button = MouseButtons.Middle;
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickUpEvent(this, e);
                        break;
                    case WM_S1BUTTONUP:
                        if(MyMouseHookStruct.hwnd == 131072)
                        {
                            button = MouseButtons.XButton1;
                        }
                        else
                        {
                            button = MouseButtons.XButton2;
                        }
                        clickCount = 1;
                        e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                        MouseClickUpEvent(this, e);
                        break;
                }
            } 
            this.Point = new Point(MyMouseHookStruct.pt.x, MyMouseHookStruct.pt.y);
            return Win32Api.CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        /// <summary>
        /// 判断按键是否按下
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsKeyPressed(int key)
        {
            return Convert.ToBoolean(GetAsyncKeyState(key) & 0x8000);
        }

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int key);
        public delegate void MouseMoveHandler(object sender, MouseEventArgs e);
        public event MouseMoveHandler MouseMoveEvent;

        public delegate bool MouseClickHandler(object sender, MouseEventArgs e);
        public event MouseClickHandler MouseClickUpEvent;
        public event MouseClickHandler MouseClickDownEvent;
    }
}
