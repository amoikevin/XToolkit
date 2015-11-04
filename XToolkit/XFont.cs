using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XFont
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XFont_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int size); //创建字体

        [DllImport(XToolkit.DllName, EntryPoint = "XFont_Create2", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create2([MarshalAs(UnmanagedType.LPWStr)] string pName = "宋体", int size = 12,
            bool bBold = false, bool bItalic = false, bool bUnderline = false, bool bStrikeOut = false);

        [DllImport(XToolkit.DllName, EntryPoint = "XFont_CreateEx", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CreateEx([MarshalAs(UnmanagedType.LPStruct)] XLogFontW pFontInfo);

        [DllImport(XToolkit.DllName, EntryPoint = "XFont_CreateFromHFONT", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr CreateFromHFONT(IntPtr hFont);

        [DllImport(XToolkit.DllName, EntryPoint = "XFont_EnableAutoDestroy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableAutoDestroy(IntPtr hFontX, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XFont_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hFontX); //销毁字体

        [DllImport(XToolkit.DllName, EntryPoint = "XFont_GetHFONT", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHFONT(IntPtr hFontX);
    }
}