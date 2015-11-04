using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XToolBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_InsertEle", CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertEle(IntPtr hEle, IntPtr hNewEle, int index = -1); //添加元素到工具条, -1插入到末尾

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_InsertSeparator",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int InsertSeparator(IntPtr hEle, int index = -1); //添加分隔符, -1插入到末尾

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_EnableButtonMenu",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr EnableButtonMenu(IntPtr hEle, bool bEnable); //显示隐藏项菜单按钮

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_GetHEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetHEle(IntPtr hEle, int index); //获取工具条上元素句柄

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_GetButtonLeft",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetButtonLeft(IntPtr hEle); //获取工具条左滚动按钮Button

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_GetButtonRight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetButtonRight(IntPtr hEle); //获取工具条右滚动按钮Button

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_GetButtonMenu",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetButtonMenu(IntPtr hEle); //获取弹出菜单按钮

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_SetSpace", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetSpace(IntPtr hEle, int nSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_DeleteEle", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr DeleteEle(IntPtr hEle, int index); //移除工具条上元素并销毁

        [DllImport(XToolkit.DllName, EntryPoint = "XToolBar_DeleteAllEle", CallingConvention = CallingConvention.StdCall
            )]
        public static extern IntPtr DeleteAllEle(IntPtr hEle);
    }
}