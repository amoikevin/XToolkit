using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XEle
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XEle_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        //[DllImport(XToolkit.DllName, EntryPoint = "XEle_RegEventEx", CallingConvention = CallingConvention.StdCall)]
        //public static extern void RegEventEx(IntPtr hEle, CEventBase* pEvent); //内部使用
        //[DllImport(XToolkit.DllName, EntryPoint = "XEle_RemoveEventEx", CallingConvention = CallingConvention.StdCall)]
        //public static extern bool RemoveEventEx(IntPtr hEle, CEventBase* pEvent); //内部使用
        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RegEventC", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegEventC(IntPtr hEle, int nEvent, IntPtr pFun); //注册事件C方式

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RegEventC1", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegEventC1(IntPtr hEle, int nEvent, IntPtr pFun);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RegEventC2", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegEventC2(IntPtr hEle, int nEvent, IntPtr pFun);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RemoveEventC", CallingConvention = CallingConvention.StdCall)]
        public static extern bool RemoveEventC(IntPtr hEle, int nEvent, IntPtr pFun); //移除事件函数C方式

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SendEvent", CallingConvention = CallingConvention.StdCall)]
        public static extern int SendEvent(IntPtr hEle, IntPtr hEventEle, int nEvent, IntPtr wParam, IntPtr lParam);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_PostEvent", CallingConvention = CallingConvention.StdCall)]
        public static extern bool PostEvent(IntPtr hEle, IntPtr hEventEle, int nEvent, IntPtr wParam, IntPtr lParam);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsShow", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsShow(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsEnable", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsEnable(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsEnableFocus", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsEnableFocus(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsDrawFocus", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsDrawFocus(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsBorder", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsBorder(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsEnableEvent_XE_PAINT_END",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsEnableEvent_XE_PAINT_END(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsMouseThrough", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsMouseThrough(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_IsBkTransparent", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern bool IsBkTransparent(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_Enable", CallingConvention = CallingConvention.StdCall)]
        public static extern void Enable(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableFocus", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableFocus(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableDrawFocus", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableDrawFocus(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableEvent_XE_PAINT_END",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableEvent_XE_PAINT_END(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableBkTransparent",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableBkTransparent(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableBorder", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableBorder(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableMouseThrough",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableMouseThrough(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetRect", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetRect(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            bool bRedraw = false);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetRectLogic", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRectLogic(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            bool bRedraw = false); //逻辑模式坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetRect(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect); //相对与父坐标,人眼观察模式

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetRectLogic", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetRectLogic(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        //相对与父坐标,逻辑模式

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetClientRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetClientRect(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        //左上角为0，0坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetWndClientRect", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void GetWndClientRect(IntPtr hEle, out XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetWidth(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetHeight", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetHeight(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RectWndClientToEleClient",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void RectWndClientToEleClient(IntPtr hEle, ref XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_PointWndClientToEleClient",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void PointWndClientToEleClient(IntPtr hEle, ref XPoint pPt);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RectClientToWndClient",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void RectClientToWndClient(IntPtr hEle, ref XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_PointClientToWndClient",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void PointClientToWndClient(IntPtr hEle, ref XPoint pPt);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_AddEle", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddEle(IntPtr hEle, IntPtr hChildEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_InsertEle", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertEle(IntPtr hEle, IntPtr hChildEle, IntPtr hDestEle); //插入到指定元素前面

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RemoveEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void RemoveEle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_AddShape", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddShape(IntPtr hEle, IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_ShowEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowEle(IntPtr hEle, bool bShow);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetType", CallingConvention = CallingConvention.StdCall)]
        public static extern XObjectType GetType(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetHWND", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHWND(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetHWINDOW", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHWINDOW(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetCursor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCursor(IntPtr hEle, IntPtr hCursor);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetCursor", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetCursor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetID", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetID(IntPtr hEle, int id);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetID", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetID(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetParentEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParentEle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetParent", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetParent(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetBkColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBkColor(IntPtr hEle, int color, byte alpha = 255); //设置背景颜色

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetBkColor", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBkColor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetBorderColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetBorderColor(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetBorderColor", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBorderColor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetTextColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTextColor(IntPtr hEle, int color, byte alpha = 254);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetTextColor", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetTextColor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetFocusBorderColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFocusBorderColor(IntPtr hEle, int color, byte alpha = 255);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetFocusBorderColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetFocusBorderColor(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetFont", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFont(IntPtr hEle, IntPtr hFontx);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetFont", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetFont(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetAlpha", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetAlpha(IntPtr hEle, byte alpha);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetChildCount", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetChildCount(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetChildByIndex", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetChildByIndex(IntPtr hEle, int index);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetChildByID", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetChildByID(IntPtr hEle, int id);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_HitChildEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HitChildEle(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt);

        //判断坐标点在哪个元素上

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_BindLayoutObject", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void BindLayoutObject(IntPtr hEle, IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetLayoutObject", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetLayoutObject(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetUserData", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetUserData(IntPtr hEle, int nData);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetUserData", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetUserData(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetContentSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetContentSize(IntPtr hEle, out XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetCapture", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCapture(IntPtr hEle, bool b);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetLayoutWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutWidth(IntPtr hEle, int nFlag, int nWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetLayoutHeight", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetLayoutHeight(IntPtr hEle, int nFlag, int nHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetLayoutWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutWidth(IntPtr hEle, out int pFlag, out int pWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetLayoutHeight", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void GetLayoutHeight(IntPtr hEle, out int pFlag, out int pHeight);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RedrawEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void RedrawEle(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RedrawRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void RedrawRect(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hEle); //销毁

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetImage", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetImage(IntPtr hEle, IntPtr hImage);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableTransparentChannel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableTransparentChannel(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_SetToolTip", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetToolTip(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pText);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_GetToolTip", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetToolTip(IntPtr hEle, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_EnableToolTip", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableToolTip(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XEle_AdjustLayout", CallingConvention = CallingConvention.StdCall)]
        public static extern void AdjustLayout(IntPtr hEle);

//        [DllImport(XToolkit.DllName, EntryPoint = "XEle_RegEventTest", CallingConvention = CallingConvention.StdCall)]
//        public static extern bool RegEventTest(int nEvent, byte* pParamType); //检测回调函数参数是否正确
    }
}