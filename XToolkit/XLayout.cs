using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XLayout
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create();

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_AddEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void AddEle(IntPtr hLayout, IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_AddLayoutObject",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void AddLayoutObject(IntPtr hLayout, IntPtr hLayoutObject);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_AddShape", CallingConvention = CallingConvention.StdCall)]
        public static extern void AddShape(IntPtr hLayout, IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_RemoveChild", CallingConvention = CallingConvention.StdCall)]
        public static extern void RemoveChild(IntPtr hLayout, IntPtr hChild);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_AdjustLayout", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void AdjustLayout(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetRectFrame", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetRectFrame(IntPtr hLayout, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetRect(IntPtr hLayout, out XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetRectFrame", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void GetRectFrame(IntPtr hLayout, out XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetWindow", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetWindow(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEle(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetParentLayout",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParentLayout(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetParent", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParent(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetID", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetID(IntPtr hLayout, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetHorizon", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetHorizon(IntPtr hLayout, bool bHorizon);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetAlignH", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlignH(IntPtr hLayout, XLayoutAlign nFlag);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetAlignV", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlignV(IntPtr hLayout, XLayoutAlign nFlag);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetPadding", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetPadding(IntPtr hLayout, int left, int top, int right, int bottom);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetSpace", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetSpace(IntPtr hLayout, int nSpace);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutWidth(IntPtr hLayout, int nFlag, int nWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_SetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutHeight(IntPtr hLayout, int nFlag, int nHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetLayoutWidth",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutWidth(IntPtr hLayout, out int pFlag, out int pWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetLayoutHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutHeight(IntPtr hLayout, out int pFlag, out int pHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWidth(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHeight(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetWidthIn", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWidthIn(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetHeightIn", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHeightIn(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetContentSize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetContentSize(IntPtr hLayout, out XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_ShowLayout", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowLayout(IntPtr hLayout, bool bShow);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetChildCount", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetChildCount(IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetChildType", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern XObjectType GetChildType(IntPtr hLayout, int index);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_GetChild", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetChild(IntPtr hLayout, int index);

        [DllImport(XToolkit.DllName, EntryPoint = "XLayout_Draw", CallingConvention = CallingConvention.StdCall)]
        public static extern void Draw(IntPtr hLayout, IntPtr hDraw);

        [DllImport(XToolkit.DllName, EntryPoint = "Layout_SetEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetEle(IntPtr hLayout, IntPtr hParent);
    }
}