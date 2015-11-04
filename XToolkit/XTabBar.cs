using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XTabBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_AddLabel", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern int AddLabel(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pName); //添加一个标签

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_InsertLabel", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern int InsertLabel(IntPtr hEle, int index, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_DeleteLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteLabel(IntPtr hEle, int index); //删除

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_DeleteLabelAll",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteLabelAll(IntPtr hEle); //删除所有TAB

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetLabel(IntPtr hEle, int index); //获取标签按钮Button

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelect(IntPtr hEle); //获取选择的标签

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetLabelSpacing",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLabelSpacing(IntPtr hEle); //获取标签间距, 0没有间距

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetLabelCount", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetLabelCount(IntPtr hEle); //获取标签项数量

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetLabelSpacing",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLabelSpacing(IntPtr hEle, int spacing); //设置标签间距, 0没有间距

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetSelect(IntPtr hEle, int index); //设置选择标签

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetUp", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetUp(IntPtr hEle); //左滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetDown", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDown(IntPtr hEle); //右滚动

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_EnableTile", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableTile(IntPtr hEle, bool bTile); //平铺标签,每个标签显示相同大小

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_EnableClose", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableClose(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetCloseSize", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetCloseSize(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetTurnButtonSize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTurnButtonSize(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_ShowLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ShowLabel(IntPtr hEle, int index, bool bShow); //显示或隐藏指定项
    }
}