using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XRichEditSet
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditSet_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);
    }
}