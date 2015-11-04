namespace System.Win32
{
    public enum XWindowTransparent
    {
        False = 0,

        ///<默认窗口,不透明
        Shaped,

        ///<透明窗口,带透明通道,异型
        Shadow,

        ///<阴影窗口,带透明通道,边框阴影,窗口透明或半透明,当前未启用.
        Simple,

        ///<透明窗口,不带透明通道,指定半透明度,指定透明色.
        Win7, ///<WIN7玻璃窗口,需要WIN7开启特效,当前未启用.
    };
}