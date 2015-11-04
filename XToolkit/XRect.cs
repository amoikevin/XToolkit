using System.Runtime.InteropServices;

namespace System.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XRect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }
}