using System.Runtime.InteropServices;

namespace System.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ListBoxItemInfoI
    {
        public int nUserData; //用户绑定数据
        public int nHeight;
        public int nSelHeight;
    };
}