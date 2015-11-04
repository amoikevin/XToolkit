using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XPane
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XPane_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create([MarshalAs(UnmanagedType.LPWStr)] string pName, int nWidth, int nHeight,
            IntPtr hFrameWnd);

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_SetView", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetView(IntPtr hEle, IntPtr hView);

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_GetTitle", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern void GetTitle(IntPtr hEle, out byte[] pOut, int nOutLen);

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_IsShowPane", CallingConvention = CallingConvention.StdCall)]
        public static extern bool IsShowPane(IntPtr hEle); //�жϴ����Ƿ�����

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_HidePane", CallingConvention = CallingConvention.StdCall)]
        public static extern void HidePane(IntPtr hEle); //���ش���

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_ShowPane", CallingConvention = CallingConvention.StdCall)]
        public static extern void ShowPane(IntPtr hEle); //����-��ʾ����

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_DockPane", CallingConvention = CallingConvention.StdCall)]
        public static extern void DockPane(IntPtr hEle); //ͣ������,�Զ�����

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_LockPane", CallingConvention = CallingConvention.StdCall)]
        public static extern void LockPane(IntPtr hEle); //��������

        [DllImport(XToolkit.DllName, EntryPoint = "XPane_FloatPane", CallingConvention = CallingConvention.StdCall)]
        public static extern void FloatPane(IntPtr hEle); //��������,������ͷ��
    }
}