using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapeGif
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGif_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGif_SetImage", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImage(IntPtr hShape, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGif_SetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutWidth(IntPtr hShape, int nFlag, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGif_SetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutHeight(IntPtr hShape, int nFlag, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGif_GetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutWidth(IntPtr hShape, out int pFlag, out int pWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGif_GetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutHeight(IntPtr hShape, out int pFlag, out int pHeight);
    }
}