using GoYes.Client.Module.GroupChat;
using GoYes.Client.Module.Http;
using Token.HttpClientHelper;
using Token.Inject.tag;

namespace GoYes.Client.Api.Group;

/// <summary>
/// 群聊api
/// </summary>
public class GroupChatApi : IScopedTag
{
    private readonly TokenHttp _http;

    ///<inheritdoc/>
    public GroupChatApi(
    TokenHttp http
        )
    {
        _http = http;
    }
    private const string host = HostApi.Authorityapi + "api/GroupChat/";

    /// <summary>
    /// 创建群聊
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<GroupChatDto?> PostGroupChat(GroupChatDto dto)
    {
        var result = await _http.PostAsync<ResultDto<GroupChatDto>>(host + "group-chat", dto);

        return result?.Data;
    }

}
