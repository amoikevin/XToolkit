using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XSView
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XSView_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_SetTotalSize", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetTotalSize(IntPtr hEle, int cx, int cy); //设置视图内容总大小(不包含边框间隔)

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetTotalSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetTotalSize(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XSize pSize);

        //获取设置的内容大小

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_SetLineSize", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetLineSize(IntPtr hEle, int nHeight, int nWidth);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetLineSize", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetLineSize(IntPtr hEle, out XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetViewPosH", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetViewPosH(IntPtr hEle); //获取视口原点X坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetViewPosV", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetViewPosV(IntPtr hEle); //获取视口原点Y坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetViewWidth", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetViewWidth(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetViewHeight", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern int GetViewHeight(IntPtr hEle);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetViewRect", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetViewRect(IntPtr hEle, out XRect pRect);

        //获取视口坐标(不含边框间隔),left为视口左间隔大小,top为视口上间隔大小,非(0,0).

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetScrollBarH", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetScrollBarH(IntPtr hEle); //获取水平滚动条

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetScrollBarV", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr GetScrollBarV(IntPtr hEle); //获取垂直滚动条

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_SetPadding", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetPadding(IntPtr hEle, int left, int top, int right, int bottom);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_GetPadding", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPadding(IntPtr hEle, out XPadding pPadding);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollPosH", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollPosH(IntPtr hEle, int pos); //滚动到指定点

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollPosV", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollPosV(IntPtr hEle, int pos); //滚动到指定点

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollPosXH", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollPosXH(IntPtr hEle, int posX); //滚动到指定坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollPosYV", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollPosYV(IntPtr hEle, int posY); //滚动到指定坐标

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ShowSBarH", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowSBarH(IntPtr hEle, bool bShow); //启用水平滚动条

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ShowSBarV", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowSBarV(IntPtr hEle, bool bShow); //启用垂直滚动条

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_EnableAutoShowScrollBar",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableAutoShowScrollBar(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollLeftLine", CallingConvention = CallingConvention.StdCall
            )]
        public static extern bool ScrollLeftLine(IntPtr hEle); //向左滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollRightLine",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollRightLine(IntPtr hEle); //向右滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollTopLine", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern bool ScrollTopLine(IntPtr hEle); //向上滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollBottomLine",
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollBottomLine(IntPtr hEle); //向下滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollLeft", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollLeft(IntPtr hEle); //水平滚动到左侧

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollRight", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollRight(IntPtr hEle); //水平滚动到右侧

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollTop", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollTop(IntPtr hEle); //滚动到顶部

        [DllImport(XToolkit.DllName, EntryPoint = "XSView_ScrollBottom", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ScrollBottom(IntPtr hEle); //滚动到底部
    }
}