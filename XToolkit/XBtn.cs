using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XBtn
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pName,
            IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_IsCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsCheck(IntPtr hEle); //��ť�Ƿ�ѡ��

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetCheck(IntPtr hEle, bool bCheck);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetState", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetState(IntPtr hEle, int nState);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetState", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetState(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetStyle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetStyle(IntPtr hEle, int nStyle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetStyle", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetStyle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetType", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetType(IntPtr hEle, int type);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetType", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetType(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetGroupID", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetGroupID(IntPtr hEle, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetGroupID", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetGroupID(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetBindEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBindEle(IntPtr hEle, IntPtr hBindEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetBindEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetBindEle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetTextAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextAlign(IntPtr hEle, int flag);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetTextAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTextAlign(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIconAlign", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetIconAlign(IntPtr hEle, int align);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetOffset", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetOffset(IntPtr hEle, int x, int y);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetOffsetIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetOffsetIcon(IntPtr hEle, int x, int y);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIconSpace", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetIconSpace(IntPtr hEle, int size);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_GetText", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetText(IntPtr hEle, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetText", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetText(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetImageLeave", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageLeave(IntPtr hEle, IntPtr hImage); //����뿪ʱͼƬ

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetImageStay", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageStay(IntPtr hEle, IntPtr hImage); //���ͣ��ʱͼƬ

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetImageDown", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageDown(IntPtr hEle, IntPtr hImage); //��갴��ʱͼƬ

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetImageCheck", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImageCheck(IntPtr hEle, IntPtr hImage); //ѡ��ʱͼƬ

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetImageDisable", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetImageDisable(IntPtr hEle, IntPtr hImage); //��ť����״̬ͼƬ

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_SetIcon", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetIcon(IntPtr hEle, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_AddAnimationFrame",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void AddAnimationFrame(IntPtr hEle, IntPtr hImage, int uElapse);

        [DllImport(XToolkit.DllName, EntryPoint = "XBtn_EnableAnimation", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableAnimation(IntPtr hEle, bool bEnable, bool bLoopPlay = false);
    }
}