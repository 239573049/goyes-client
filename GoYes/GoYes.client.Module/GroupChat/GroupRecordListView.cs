using GoYes.Client.Module.Shared;

namespace GoYes.Client.Module.GroupChat;

public class GroupRecordListView
{
    public Guid Id { get; set; }

    /// <summary>
    /// 连接id
    /// </summary>
    public string? ConnectId { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    public string? Name { get; set; }

    private string? headPortrait;

    /// <summary>
    /// 头像 
    /// </summary>
    public string? HeadPortrait
    {
        get
        {
            return SharedConst.Host + headPortrait;
        }
        set
        {
            headPortrait = value;
        }
    }

    /// <summary>
    /// 是否群聊
    /// </summary>
    public bool IsGroup { get; set; }
}
