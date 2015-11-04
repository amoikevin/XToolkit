using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XBtn
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_IsCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsCheck(IntPtr hEle); //按钮是否被选中

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetCheck(IntPtr hEle, bool bCheck);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetState", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetState(IntPtr hEle, XCommonState nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetState", CallingConvention = CallingConvention.StdCall)]
        public static extern XCommonState GetState(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetStyle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetStyle(IntPtr hEle, XButtonStyle nStyle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetStyle", CallingConvention = CallingConvention.StdCall)]
        public static extern XButtonStyle GetStyle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetType", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetType(IntPtr hEle, XButtonType nType);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetType", CallingConvention = CallingConvention.StdCall)]
        public static extern XButtonType GetType(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetGroupID", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetGroupID(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetGroupID", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetGroupID(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetBindEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetBindEle(IntPtr hEle, IntPtr hBindEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetBindEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetBindEle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetTextAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetTextAlign(IntPtr hEle, int nFlags);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetTextAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTextAlign(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIconAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetIconAlign(IntPtr hEle, XButtonIconAlign align);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetOffset", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetOffset(IntPtr hEle, int x, int y);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetOffsetIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetOffsetIcon(IntPtr hEle, int x, int y);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIconSpace", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetIconSpace(IntPtr hEle, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetText", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetText(IntPtr hEle, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetText", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetText(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetIcon(IntPtr hEle, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIconDisable", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetIconDisable(IntPtr hEle, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_AddAnimationFrame",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AddAnimationFrame(IntPtr hEle, IntPtr hImage, int uElapse);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_EnableAnimation", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr EnableAnimation(IntPtr hEle, bool bEnable, bool bLoopPlay = false);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_AddBkBorder", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AddBkBorder(IntPtr hEle, XButtonState nState, int color, byte alpha, int width);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_AddBkFill", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AddBkFill(IntPtr hEle, XButtonState nState, int color, byte alpha);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_AddBkImage", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AddBkImage(IntPtr hEle, XButtonState nState, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetBkInfoCount", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBkInfoCount(IntPtr hEle, XButtonState nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_ClearBkInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ClearBkInfo(IntPtr hEle, XButtonState nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetBkInfoManager", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr GetBkInfoManager(IntPtr hEle, XButtonState nState);
    }
}