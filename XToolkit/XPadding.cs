using System.Runtime.InteropServices;

namespace System.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XPadding
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }
}