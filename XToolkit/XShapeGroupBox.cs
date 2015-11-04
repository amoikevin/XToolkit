using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapeGroupBox
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_Create", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_SetBorderColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBorderColor(IntPtr hShape, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_SetTextColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextColor(IntPtr hShape, int color, byte alpha = 254);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_SetFontX",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFontX(IntPtr hShape, IntPtr hFontX);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_SetTextOffset",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextOffset(IntPtr hShape, int offsetX, int offsetY);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_SetRoundAngle",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRoundAngle(IntPtr hShape, int nWidth, int nHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_SetText",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void SetText(IntPtr hShape, [MarshalAs(UnmanagedType.LPWStr)] string pText);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_GetTextOffset",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTextOffset(IntPtr hShape, out int pOffsetX, out int pOffsetY);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_GetRoundAngle",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetRoundAngle(IntPtr hShape, out int pWidth, out int pHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeGroupBox_EnableRoundAngle",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableRoundAngle(IntPtr hShape, bool bEnable);
    }
}