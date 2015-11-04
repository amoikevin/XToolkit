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

        //设置打开文件类型

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFile_SetDefaultFile",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetDefaultFile(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pFile);

        //设置默认目录文件

        [DllImport(XToolkit.DllName, EntryPoint = "XRichEditFile_SetRelativeDir",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void SetRelativeDir(IntPtr hEle, [MarshalAs(UnmanagedType.LPWStr)] string pDir);

        //TODO:设置相对路径
    }
}