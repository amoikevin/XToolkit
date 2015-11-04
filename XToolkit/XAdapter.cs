using System.Runtime.InteropServices;

namespace System.Win32
{
    public static class XAdapter
    {
        [DllImport(XToolkit.DllName, EntryPoint = "XAdapter_Destroy", CallingConvention = CallingConvention.StdCall)]
        public static extern void Destroy(IntPtr hAdapter);


    }
}