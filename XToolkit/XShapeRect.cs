using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapeRect
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_SetBorderColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBorderColor(IntPtr hShape, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_SetFillColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFillColor(IntPtr hShape, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_SetRoundAngle",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRoundAngle(IntPtr hShape, int nWidth, int nHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_GetRoundAngle",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetRoundAngle(IntPtr hShape, out int pWidth, out int pHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_EnableBorder",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableBorder(IntPtr hShape, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_EnableFill", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void EnableFill(IntPtr hShape, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeRect_EnableRoundAngle",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableRoundAngle(IntPtr hShape, bool bEnable);
    }
}