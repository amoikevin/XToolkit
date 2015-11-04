using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XTabBar
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_Create", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_AddLabel", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern int AddLabel(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pName); //���һ����ǩ

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_InsertLabel", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Unicode)]
        public static extern int InsertLabel(IntPtr hEle, int index, [MarshalAs(UnmanagedType.LPWStr)] string pName);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_DeleteLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern bool DeleteLabel(IntPtr hEle, int index); //ɾ��

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_DeleteLabelAll",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteLabelAll(IntPtr hEle); //ɾ������TAB

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetLabel(IntPtr hEle, int index); //��ȡ��ǩ��ťButton

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetSelect(IntPtr hEle); //��ȡѡ��ı�ǩ

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetLabelSpacing",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int GetLabelSpacing(IntPtr hEle); //��ȡ��ǩ���, 0û�м��

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_GetLabelCount", CallingConvention = CallingConvention.StdCall
            )]
        public static extern int GetLabelCount(IntPtr hEle); //��ȡ��ǩ������

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetLabelSpacing",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetLabelSpacing(IntPtr hEle, int spacing); //���ñ�ǩ���, 0û�м��

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetSelect", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetSelect(IntPtr hEle, int index); //����ѡ���ǩ

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetUp", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetUp(IntPtr hEle); //�����

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetDown", CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDown(IntPtr hEle); //�ҹ���

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_EnableTile", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableTile(IntPtr hEle, bool bTile); //ƽ�̱�ǩ,ÿ����ǩ��ʾ��ͬ��С

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_EnableClose", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableClose(IntPtr hEle, bool bEnable);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetCloseSize", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void SetCloseSize(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_SetTurnButtonSize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetTurnButtonSize(IntPtr hEle, [MarshalAs(UnmanagedType.LPStruct)] XSize pSize);

        [DllImport(XToolkit.DllName, EntryPoint = "XTabBar_ShowLabel", CallingConvention = CallingConvention.StdCall)]
        public static extern bool ShowLabel(IntPtr hEle, int index, bool bShow); //��ʾ������ָ����
    }
}