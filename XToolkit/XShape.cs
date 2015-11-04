using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XShape
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetParentEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParentEle(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetParentLayout",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParentLayout(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetHWINDOW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHWINDOW(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetParent", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParent(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_SetID", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetID(IntPtr hShape, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetID", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetID(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_Redraw", CallingConvention = CallingConvention.StdCall)]
        public static extern void Redraw(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWidth(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHeight(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetRect(IntPtr hShape, out XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_SetRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRect(IntPtr hShape, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_GetContentSize", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void GetContentSize(IntPtr hShape, out XSize pSize); //获取内容大小

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_ShowLayout", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowLayout(IntPtr hShape, bool bShow);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_AdjustLayout", CallingConvention = CallingConvention.StdCall)]
        public static extern void AdjustLayout(IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XShape_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hShape);
    }
}