using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapePic
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapePic_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapePic_SetImage", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImage(IntPtr hShape, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapePic_SetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutWidth(IntPtr hShape, int nFlag, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapePic_SetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutHeight(IntPtr hShape, int nFlag, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapePic_GetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutWidth(IntPtr hShape, out int pFlag, out int pWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapePic_GetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutHeight(IntPtr hShape, out int pFlag, out int pHeight);
    }
}