using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapeEllipse
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapeEllipse_Create", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeEllipse_SetBorderColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBorderColor(IntPtr hShape, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeEllipse_SetFillColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFillColor(IntPtr hShape, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeEllipse_EnableBorder",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableBorder(IntPtr hShape, bool bEnable = true);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeEllipse_EnableFill",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableFill(IntPtr hShape, bool bEnable = true);
    }
}