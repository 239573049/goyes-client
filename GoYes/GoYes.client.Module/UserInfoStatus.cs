
using System.ComponentModel;

namespace GoYes.Client.Module;


public enum UserInfoStatus
{
    /// <summary>
    /// 启用
    /// </summary>
    [Description("启用")]
    StartUsing,

    /// <summary>
    /// 禁用
    /// </summary>
    [Description("禁用")]
    Forbidden,

    /// <summary>
    /// 冻结
    /// </summary>
    [Description("冻结")]
    Freeze
}