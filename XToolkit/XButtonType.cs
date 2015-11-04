namespace System.Win32
{
    public enum XButtonType
    {
        Default = 0,

        ///<默认类型
        Check,

        ///<复选按钮
        Radio,

        ///<单选按钮
        Close,

        ///<窗口关闭按钮
        Min,

        ///<窗口最小化按钮
        Max, ///<窗口最大化还原按钮
    };
}