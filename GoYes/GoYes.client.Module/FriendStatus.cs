
using System.ComponentModel;

namespace GoYes.Client.Module;
public enum FriendStatus
{

    /// <summary>
    /// 申请中
    /// </summary>
    [Description("申请中")]
    Apply,

    /// <summary>
    /// 同意
    /// </summary>
    [Description("同意")]
    Consent,

    /// <summary>
    /// 拒绝
    /// </summary>
    [Description("拒绝")]
    Refuse
}
