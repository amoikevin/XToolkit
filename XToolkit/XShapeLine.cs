using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapeLine
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapeLine_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x1, int y1, int x2, int y2, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeLine_SetPosition",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetPosition(IntPtr hShape, int x1, int y1, int x2, int y2);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeLine_SetColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetColor(IntPtr hShape, int color, byte alpha);
    }
}