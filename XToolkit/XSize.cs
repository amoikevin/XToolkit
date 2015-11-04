using System.Runtime.InteropServices;

namespace System.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XSize
    {
        public int width;
        public int height;
    }
}