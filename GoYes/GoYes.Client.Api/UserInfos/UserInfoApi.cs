using Blazored.LocalStorage;
using GoYes.Client.Module;
using GoYes.Client.Module.Http;
using GoYes.Client.Module.Login;
using Token.HttpClientHelper;
using Token.Inject.tag;

namespace GoYes.Client.Api.UserInfos;

/// <summary>
/// 
/// </summary>
public class UserInfoApi : IScopedTag
{
    private readonly TokenHttp _http;
    private readonly ILocalStorageService _localStorageService;
    private const string host = HostApi.Tokenapi + "api/UserInfo/";
    public UserInfoApi(
    TokenHttp http, ILocalStorageService localStorageService)
    {
        _http = http;
        _localStorageService = localStorageService;
    }

    /// <summary>
    /// 登录账号
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<bool> Repetition(RegisterDto dto)
    {

        var result = await _http.PostAsync<ResultDto<string>>(host + "repetition", dto);
        if(result?.Code == 200)
        {
            await _localStorageService.SetItemAsStringAsync("token", result.Data);
            result.Data = "Bearer " + result.Data;
            _http.SetToken(result.Data);
            return true;
        }
        return false;
    }

    /// <summary>
    /// 获取用户信息
    /// </summary>
    /// <returns></returns>
    public async Task<UserInfo?> GetUserInfoAsync()
    {
        var result = await _http.GetAsync<ResultDto<UserInfo>>(host + "user-info");
        if(result?.Code == 200)
        {
            return result.Data;
        }
        return null;
    }
}
