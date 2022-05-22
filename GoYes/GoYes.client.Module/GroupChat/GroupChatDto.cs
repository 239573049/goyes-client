﻿namespace GoYes.Client.Module.GroupChat;
public class GroupChatDto
{
    public Guid Id { get; set; }

    /// <summary>
    /// 群聊名称
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 头像 
    /// </summary>
    public string? HeadPortrait { get; set; }

    /// <summary>
    /// 连接id
    /// </summary>
    public string? ConnectId { get; set; }

    /// <summary>
    /// 文件流
    /// </summary>
    public Stream? FileStream { get; set; }

    /// <summary>
    /// 文件名
    /// </summary>
    public string? FileName { get; set; }

}
