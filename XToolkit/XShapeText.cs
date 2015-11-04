using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShapeText
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_Create", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetText", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern void SetText(IntPtr hTextBlock, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_GetText", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetText(IntPtr hTextBlock, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_GetTextLength",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTextLength(IntPtr hTextBlock);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetFont", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFont(IntPtr hTextBlock, IntPtr hFontx);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetTextColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextColor(IntPtr hTextBlock, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_GetTextColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTextColor(IntPtr hTextBlock);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetTextAlign",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextAlign(IntPtr hTextBlock, int align);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetOffset", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetOffset(IntPtr hTextBlock, int x, int y);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutWidth(IntPtr hTextBlock, int nFlag, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_SetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutHeight(IntPtr hTextBlock, int nFlag, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_GetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutWidth(IntPtr hTextBlock, out int pFlag, out int pWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XShapeText_GetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutHeight(IntPtr hTextBlock, out int pFlag, out int pHeight);
    }
}