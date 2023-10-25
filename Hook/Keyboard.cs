using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FreeBNS.Hook
{
    /// <summary>
    /// This class wraps calls to the user32.dll keybd_event method
    /// </summary>
    public class Keyboard
    {
        public static Dictionary<string, Int32> KeyMap = new Dictionary<string, Int32>();

        public static Dictionary<string, Int32> getKeyMap()
        {

            /*KeyMap.Add("LButton", 0x1);
            KeyMap.Add("RButton", 0x2);
            KeyMap.Add("MButton", 0x4);
            KeyMap.Add("XButton1", 0x5);
            KeyMap.Add("XButton2", 0x6);*/
            KeyMap.Add("Tab", 0x9);
            KeyMap.Add("Space", 0x20);
            KeyMap.Add("Left", 0x25);
            KeyMap.Add("Up", 0x26);
            KeyMap.Add("Right", 0x27);
            KeyMap.Add("Down", 0x28);
            KeyMap.Add("A", 0x41);
            KeyMap.Add("B", 0x42);
            KeyMap.Add("C", 0x43);
            KeyMap.Add("D", 0x44);
            KeyMap.Add("E", 0x45);
            KeyMap.Add("F", 0x46);
            KeyMap.Add("G", 0x47);
            KeyMap.Add("H", 0x48);
            KeyMap.Add("I", 0x49);
            KeyMap.Add("J", 0x4A);
            KeyMap.Add("K", 0x4B);
            KeyMap.Add("L", 0x4C);
            KeyMap.Add("M", 0x4D);
            KeyMap.Add("N", 0x4E);
            KeyMap.Add("O", 0x4F);
            KeyMap.Add("P", 0x50);
            KeyMap.Add("Q", 0x51);
            KeyMap.Add("R", 0x52);
            KeyMap.Add("S", 0x53);
            KeyMap.Add("T", 0x54);
            KeyMap.Add("U", 0x55);
            KeyMap.Add("V", 0x56);
            KeyMap.Add("W", 0x57);
            KeyMap.Add("X", 0x58);
            KeyMap.Add("Y", 0x59);
            KeyMap.Add("Z", 0x5A);
            KeyMap.Add("0", 0x60);
            KeyMap.Add("1", 0x61);
            KeyMap.Add("2", 0x62);
            KeyMap.Add("3", 0x63);
            KeyMap.Add("4", 0x64);
            KeyMap.Add("5", 0x65);
            KeyMap.Add("6", 0x66);
            KeyMap.Add("7", 0x67);
            KeyMap.Add("8", 0x68);
            KeyMap.Add("9", 0x69);
            KeyMap.Add("F1", 0x70);
            KeyMap.Add("F2", 0x71);
            KeyMap.Add("F3", 0x72);
            KeyMap.Add("F4", 0x73);
            KeyMap.Add("F5", 0x74);
            KeyMap.Add("F6", 0x75);
            KeyMap.Add("F7", 0x76);
            KeyMap.Add("F8", 0x77);
            KeyMap.Add("F9", 0x78);
            KeyMap.Add("F10", 0x79);
            KeyMap.Add("F11", 0x7A);
            KeyMap.Add("F12", 0x7B);
            KeyMap.Add("SHIFT", 16);
            KeyMap.Add("CTRL", 17);
            KeyMap.Add("ALT", 18);
            KeyMap.Add("-", 0x6D);
            KeyMap.Add("=", 187);
            return KeyMap;
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        /// <summary>
        /// Key down flag
        /// </summary>
        private const int KEY_DOWN_EVENT = 0x0001;
        /// <summary>
        /// Key up flag
        /// </summary>
        private const int KEY_UP_EVENT = 0x0002;
        /// <summary>
        /// ms to wait between keystrokes when holding a key down
        /// </summary>
        private const int PauseBetweenStrokes = 50;

        /// <summary>
        /// Will hold a key down for a number of milliseconds
        /// </summary>
        /// <param name="key">byte value for key. can cast like this: (byte)System.Windows.Forms.Keys.F24</param>
        /// <param name="duration">ms to hold key down for</param>
        /// <example>
        /// <code>
        /// Keyboard.KeyUp((byte)Keys.F24,5000);
        /// </code>
        /// </example>
        public static void HoldKey(byte key, int downduration, int upduration)
        {
            System.Threading.Thread.Sleep(downduration);
            keybd_event(key, 0, KEY_DOWN_EVENT, 0);
            System.Threading.Thread.Sleep(upduration);
            keybd_event(key, 0, KEY_UP_EVENT, 0);
            System.Threading.Thread.Sleep(PauseBetweenStrokes);
        }

        public static void HoldGroupKey(byte[] keys, int downduration, int upduration)
        {
            if (keys.Length < 2)
            {
                return;
            }
            System.Threading.Thread.Sleep(downduration);
            keybd_event(keys[0], 0, KEY_DOWN_EVENT, 0);
            PressKey(keys[1]);
            System.Threading.Thread.Sleep(upduration);
            keybd_event(keys[0], 0, KEY_UP_EVENT, 0);
            System.Threading.Thread.Sleep(PauseBetweenStrokes);

        }

        /// <summary>
        /// Will press a key
        /// </summary>
        /// <param name="key">byte value for key. can cast like this: (byte)System.Windows.Forms.Keys.F24</param>
        /// <example>
        /// <code>
        /// Keyboard.PressKey((byte)Keys.F24);
        /// </code>
        /// </example>
        public static void PressKey(byte key)
        {
            keybd_event(key, 0, KEY_DOWN_EVENT, 0);
            keybd_event(key, 0, KEY_UP_EVENT, 0);
        }
        /// <summary>
        /// Will trigger the KeyUp event for a key. Easy way to keep the computer awake without sending any input.
        /// </summary>
        /// <param name="key">byte value for key. can cast like this: (byte)System.Windows.Forms.Keys.F24</param>
        /// <example>
        /// <code>
        /// Keyboard.KeyUp((byte)Keys.F24);
        /// </code>
        /// </example>
        public static void KeyUp(byte key)
        {
            keybd_event(key, 0, KEY_UP_EVENT, 0);
        }

    }
}
