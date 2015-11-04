using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XToolkit
    {
        public const string DllName = "XCGUI.dll";

        [DllImport(DllName, EntryPoint = "XInitXCGUI", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern bool Init([MarshalAs(UnmanagedType.LPWStr)] string pText = null);

        [DllImport(DllName, EntryPoint = "XRunXCGUI", CallingConvention = CallingConvention.StdCall)]
        public static extern void Run();

        [DllImport(DllName, EntryPoint = "XExitXCGUI", CallingConvention = CallingConvention.StdCall)]
        public static extern void Exit();


        [DllImport(DllName, EntryPoint = "_Image_AddRef", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ImageAddRef(IntPtr hImage); //增加引用计数

        [DllImport(DllName, EntryPoint = "_Image_Release", CallingConvention = CallingConvention.StdCall)]
        public static extern void ImageRelease(IntPtr hImage); //释放引用计数

        [DllImport(DllName, EntryPoint = "xtrace", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto
            )]
        public static extern void Trace([MarshalAs(UnmanagedType.LPStr)] string pFormat, params object[] args);

        [DllImport(DllName, EntryPoint = "xtracew", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern void TraceW([MarshalAs(UnmanagedType.LPWStr)] string pFormat, params object[] args);

        [DllImport(DllName, EntryPoint = "_XC_DebugPrintf", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Auto)]
        public static extern void DebugPrintf(int level, [MarshalAs(UnmanagedType.LPStr)] string pFormat,
            params object[] args);

        [DllImport(DllName, EntryPoint = "_XC_DebugPrintfW", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern void DebugPrintfW(int level, [MarshalAs(UnmanagedType.LPWStr)] string pFormat,
            params object[] args);

        [DllImport(DllName, EntryPoint = "_XC_SetType", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetType(IntPtr hXCGUI, XObjectType nType); //设置元素最终类型

        [DllImport(DllName, EntryPoint = "_XC_AddType", CallingConvention = CallingConvention.StdCall)]
        public static extern void AddType(IntPtr hXCGUI, XObjectType nType); //增加类型

        [DllImport(DllName, EntryPoint = "_XC_BindData", CallingConvention = CallingConvention.StdCall)]
        public static extern void BindData(IntPtr hXCGUI, int data);

        [DllImport(DllName, EntryPoint = "_XC_GetBindData", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBindData(IntPtr hXCGUI);


        [DllImport(DllName, EntryPoint = "XC_UnicodeToAnsi", CallingConvention = CallingConvention.StdCall)]
        public static extern int UnicodeToAnsi([MarshalAs(UnmanagedType.LPWStr)] string pIn, int inLen, out byte[] pOut,
            int outLen);

        [DllImport(DllName, EntryPoint = "XC_AnsiToUnicode", CallingConvention = CallingConvention.StdCall)]
        public static extern int AnsiToUnicode([MarshalAs(UnmanagedType.LPStr)] string pIn, int inLen, out byte[] pOut,
            int outLen);

        [DllImport(DllName, EntryPoint = "XC_DebugToFileInfo", CallingConvention = CallingConvention.StdCall)]
        public static extern void DebugToFileInfo([MarshalAs(UnmanagedType.LPStr)] string pInfo);

        //打印调试信息到文件 xcgui_debug.txt

        [DllImport(DllName, EntryPoint = "XC_IsHELE", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsHELE(IntPtr hEle); //检查句柄

        [DllImport(DllName, EntryPoint = "XC_IsHWINDOW", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsHWINDOW(IntPtr hWindow); //检查句柄

        [DllImport(DllName, EntryPoint = "XC_IsShape", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsShape(IntPtr hShape); //检查句柄

        [DllImport(DllName, EntryPoint = "XC_IsHXCGUI", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsHXCGUI(IntPtr hXCGUI, XObjectType nType);

        [DllImport(DllName, EntryPoint = "XC_hWindowFromHWnd", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr hWindowFromHWnd(IntPtr hWnd);

        [DllImport(DllName, EntryPoint = "XC_IsSViewExtend", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsSViewExtend(IntPtr hEle); //判断元素是否从滚动视图元素扩展的新元素,包含滚动视图元素

        [DllImport(DllName, EntryPoint = "XC_GetObjectType", CallingConvention = CallingConvention.StdCall)]
        public static extern XObjectType GetObjectType(IntPtr hXCGUI);

        [DllImport(DllName, EntryPoint = "XC_GetObjectByID", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetObjectByID(int nID); //通过ID获取对象句柄

        [DllImport(DllName, EntryPoint = "XC_RectInRect", CallingConvention = CallingConvention.StdCall)]
        public static extern bool RectInRect([MarshalAs(UnmanagedType.LPStruct)] XRect pRect1,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pRect2);

        [DllImport(DllName, EntryPoint = "XC_CombineRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void CombineRect([MarshalAs(UnmanagedType.LPStruct)] XRect pDest,
            [MarshalAs(UnmanagedType.LPStruct)] XRect pSrc1, [MarshalAs(UnmanagedType.LPStruct)] XRect pSrc2);

        [DllImport(DllName, EntryPoint = "XC_ShowLayoutFrame", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowLayoutFrame(bool bShow);

        [DllImport(DllName, EntryPoint = "XC_EnableDebugFile", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableDebugFile(bool bEnable);

        [DllImport(DllName, EntryPoint = "XC_SetLayoutFrameColor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLayoutFrameColor(int color);

        [DllImport(DllName, EntryPoint = "XC_LoadLayout", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadLayout([MarshalAs(UnmanagedType.LPWStr)] string pFileName);


        [DllImport(DllName, EntryPoint = "XC_LoadLayoutFromString", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadLayoutFromString([MarshalAs(UnmanagedType.LPStr)] string pStringXML);

        [DllImport(DllName, EntryPoint = "XC_LoadResource", CallingConvention = CallingConvention.StdCall)]
        public static extern bool LoadResource([MarshalAs(UnmanagedType.LPWStr)] string pFileName,
            [MarshalAs(UnmanagedType.LPWStr)] string pDir = null);

        [DllImport(DllName, EntryPoint = "XC_LoadResourceFromString", CallingConvention = CallingConvention.StdCall)]
        public static extern bool LoadResourceFromString([MarshalAs(UnmanagedType.LPStr)] string pStringXML,
            [MarshalAs(UnmanagedType.LPWStr)] string pDir = null);

        [DllImport(DllName, EntryPoint = "XC_TemplateLoad", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TemplateLoad(XObjectType nType, [MarshalAs(UnmanagedType.LPWStr)] string pFileName);

        //加载模板 返回模板对象

        [DllImport(DllName, EntryPoint = "XC_TemplateDestroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void TemplateDestroy(IntPtr pInfo);

        [DllImport(DllName, EntryPoint = "XC_GetTextSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTextSize([MarshalAs(UnmanagedType.LPWStr)] string pString, int length,
            IntPtr hFontX, out XSize pOutSize);

        [DllImport(DllName, EntryPoint = "XC_GetDefaultFont", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetDefaultFont(); //获取默认字体

        [DllImport(DllName, EntryPoint = "XC_InitFont", CallingConvention = CallingConvention.StdCall)]
        public static extern void InitFont([MarshalAs(UnmanagedType.LPStruct)] XLogFontW pFont,
            [MarshalAs(UnmanagedType.LPWStr)] string pName, int size, bool bBold = false, bool bItalic = false,
            bool bUnderline = false, bool bStrikeOut = false);

        [DllImport(DllName, EntryPoint = "XC_Malloc", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Malloc(int size);

        [DllImport(DllName, EntryPoint = "XC_Free", CallingConvention = CallingConvention.StdCall)]
        public static extern void Free(IntPtr p);
    }
}