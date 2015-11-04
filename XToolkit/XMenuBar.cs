using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XMenuBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XMenuBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenuBar_AddButton", CallingConvention = CallingConvention.StdCall)]
        public static extern int AddButton(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pText); //增加弹出菜单按钮

        [DllImport(XToolkit.DllName, EntryPoint = "XMenuBar_SetButtonHeight",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetButtonHeight(IntPtr hEle, int height);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenuBar_GetMenu", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetMenu(IntPtr hEle, int nIndex);

        [DllImport(XToolkit.DllName, EntryPoint = "XMenuBar_DeleteButton", CallingConvention = CallingConvention.StdCall
            )]
        public static extern bool DeleteButton(IntPtr hEle, int nIndex); //删除菜单项并且销毁,同时该按钮下的弹出菜单也被销毁
    }
}