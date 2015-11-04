using System.Runtime.InteropServices;

namespace System.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XPoint
    {
        public int x;
        public int y;
    }
}