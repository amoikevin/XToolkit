using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XWnd
    {
//        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RegEventEx", CallingConvention = CallingConvention.StdCall)]
//        public static extern void RegEventEx(IntPtr hWindow, CEventBase* pEvent);
//        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RemoveEventEx", CallingConvention = CallingConvention.StdCall)]
//        public static extern bool RemoveEventEx(IntPtr hWindow, CEventBase* pEvent);
        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RegEventC", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegEventC(IntPtr hWindow, int nEvent, IntPtr pFun);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RegEventC1", CallingConvention = CallingConvention.StdCall)]
        public static extern void RegEventC1(IntPtr hWindow, int nEvent, IntPtr pFun);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RemovegEvent", CallingConvention = CallingConvention.StdCall)]
        public static extern bool RemovegEvent(IntPtr hWindow, int nEvent, IntPtr pFun);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_Create", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.LPWStr)] string pTitle,
            IntPtr hWndParent, int XCStyle = XWindowStyle.Default);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_CreateEx", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateEx(int dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName,
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, int dwStyle, int x, int y, int cx, int cy,
            IntPtr hWndParent, int XCStyle = XWindowStyle.Default);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_AddEle", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddEle(IntPtr hWindow, IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_InsertEle", CallingConvention = CallingConvention.StdCall)]
        public static extern bool InsertEle(IntPtr hWindow, IntPtr hChildEle, IntPtr hDestEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_AddShape", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AddShape(IntPtr hWindow, IntPtr hShape);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetHWND", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHWND(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_EnableDragBorder", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void EnableDragBorder(IntPtr hWindow, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_EnableDragWindow", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void EnableDragWindow(IntPtr hWindow, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_EnableDrawBk", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableDrawBk(IntPtr hWindow, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_EnableAutoFocus", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void EnableAutoFocus(IntPtr hWindow, bool bEnable); //当鼠标左键按下是否获得焦点

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RedrawWnd", CallingConvention = CallingConvention.StdCall)]
        public static extern void RedrawWnd(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_RedrawWndRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void RedrawWndRect(IntPtr hWindow, [MarshalAs(UnmanagedType.LPStruct)] XRect pRect,
            bool bImmediately = false); //重绘窗口指定区域

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetFocusEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFocusEle(IntPtr hWindow, IntPtr hFocusEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetFocusEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetFocusEle(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCursor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCursor(IntPtr hWindow, IntPtr hCursor);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetCursor", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetCursor(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCursorSys", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetCursorSys(IntPtr hWindow, IntPtr hCursor);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetFont", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetFont(IntPtr hWindow, IntPtr hFontx);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetID", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetID(IntPtr hWindow, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetID", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetID(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCaptureEle", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCaptureEle(IntPtr hWindow, IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetCaptureEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetCaptureEle(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_BindLayoutEle", CallingConvention = CallingConvention.StdCall)]
        public static extern bool BindLayoutEle(IntPtr hWindow, XWndPos nPosition, IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetLayoutEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetLayoutEle(IntPtr hWindow, XWndPos nPosition);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_BindLayoutObject", CallingConvention = CallingConvention.StdCall
            )]
        public static extern void BindLayoutObject(IntPtr hWindow, XWndPos nPosition, IntPtr hLayout);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetLayoutObject", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetLayoutObject(IntPtr hWindow, XWndPos nPosition);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetLayoutSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutSize(IntPtr hWindow, int left, int top, int right, int bottom);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetLayoutSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLayoutSize(IntPtr hWindow, out XPadding pBorderSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetDragBorderSize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDragBorderSize(IntPtr hWindow, int left, int top, int right, int bottom);

        //设置拖动边框大小

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetDragBorderSize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void GetDragBorderSize(IntPtr hWindow, out XPadding pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetMinimumSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetMinimumSize(IntPtr hWindow, int width, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_HitChildEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr HitChildEle(IntPtr hWindow, [MarshalAs(UnmanagedType.LPStruct)] XPoint pPt);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetChildCount", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetChildCount(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetChildByIndex", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetChildByIndex(IntPtr hWindow, int index);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetChildByID", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetChildByID(IntPtr hWindow, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEle(IntPtr hWindow, int nID);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetDrawRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetDrawRect(IntPtr hWindow, [MarshalAs(UnmanagedType.LPStruct)] XRect pRcPaint);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_ShowWindow", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ShowWindow(IntPtr hWindow, int nCmdShow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_AdjustLayout", CallingConvention = CallingConvention.StdCall)]
        public static extern void AdjustLayout(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_CloseWindow", CallingConvention = CallingConvention.StdCall)]
        public static extern void CloseWindow(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_CreateCaret", CallingConvention = CallingConvention.StdCall)]
        public static extern void CreateCaret(IntPtr hWindow, IntPtr hEle, int width, int height); //创建插入符

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCaretSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCaretSize(IntPtr hWindow, int width, int height); //设置插入符大小

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCaretPos", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCaretPos(IntPtr hWindow, int x, int y); //设置插入符位置

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCaretPosEx", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCaretPosEx(IntPtr hWindow, int x, int y, int width, int height); //设置插入符位置

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetCaretColor", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetCaretColor(IntPtr hWindow, int color); //设置插入符颜色

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_ShowCaret", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowCaret(IntPtr hWindow, bool bShow); //显示插入符

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_DestroyCaret", CallingConvention = CallingConvention.StdCall)]
        public static extern void DestroyCaret(IntPtr hWindow); //销毁插入符

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetCaretHELE", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetCaretHELE(IntPtr hWindow);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetClientRect", CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetClientRect(IntPtr hWindow, out XRect pRect); //获取客户区坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetBodyRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetBodyRect(IntPtr hWindow, out XRect pRect); //获取窗口body坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetTimer", CallingConvention = CallingConvention.StdCall)]
        public static extern int SetTimer(IntPtr hWindow, int nIDEvent, int uElapse); //设置定时器

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_KillTimer", CallingConvention = CallingConvention.StdCall)]
        public static extern bool KillTimer(IntPtr hWindow, int nIDEvent);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_GetBkInfoManager", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr GetBkInfoManager(IntPtr hWindow, XWndPos nPosition);

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetTransparentType",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTransparentType(IntPtr hWindow, XWindowTransparent nType); //设置透明窗口

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetTransparentAlpha",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTransparentAlpha(IntPtr hWindow, byte alpha); //设置窗口透明度

        [DllImport(XToolkit.DllName, EntryPoint = "XWnd_SetTransparentColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTransparentColor(IntPtr hWindow, int color); //设置窗口透明色
        //[DllImport(XToolkit.DllName, EntryPoint = "XWnd_RegEventTest", CallingConvention = CallingConvention.StdCall)]
        //public static extern bool RegEventTest(int nEvent, byte* pParamType);
    }
}