
namespace GoYes.Client.Module;
public class UserInfo
{

    /// <summary>
    ///     名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     账号
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    ///     密码
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    ///     头像
    /// </summary>
    public string? HeadPortrait { get; set; }

    /// <summary>
    ///     账号状态
    /// </summary>
    public UserInfoStatus Status { get; set; } = UserInfoStatus.StartUsing;

    /// <summary>
    ///     微信OpenId
    /// </summary>
    public string? WxOpenId { get; set; }

    /// <summary>
    ///     Gitee的OpenId
    /// </summary>
    public string? GiteeOpenId { get; set; }
}
