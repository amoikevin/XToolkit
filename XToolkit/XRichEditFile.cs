using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XRichEditFile
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFile_Create", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern IntPtr Create(int x, int y, int cx, int cy, IntPtr hParent);

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFile_SetOpenFileType",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetOpenFileType(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pType);

        //���ô��ļ�����

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFile_SetDefaultFile",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDefaultFile(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pFile);

        //����Ĭ��Ŀ¼�ļ�

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFile_SetRelativeDir",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRelativeDir(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pDir);

        //TODO:�������·��
    }
}