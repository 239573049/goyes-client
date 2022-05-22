using Blazored.LocalStorage;
using GoYes.Client.Module.Http;
using GoYes.Client.Module.Login;
using Token.HttpClientHelper;
using Token.Inject.tag;

namespace GoYes.Client.Api.login;

/// <summary>
/// 到了接口
/// </summary>
public class LoginApi : IScopedTag
{
    private const string host = HostApi.Authorityapi + "api/Login/";
    private readonly TokenHttp _http;
    private readonly ILocalStorageService _localStorageService;
    ///<inheritdoc/>
    public LoginApi(TokenHttp http, ILocalStorageService localStorageService)
    {
        this._http = http;
        _localStorageService = localStorageService;
    }

    /// <summary>
    /// 登录账号
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<string> Login(LoginDto dto)
    {
        _http.SetContentType("application/json");
        _http.HttpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
        var result = await _http!.PostAsync<ResultDto<string>>(host + "login", dto);
        if(result?.Code == 200)
        {
            await _localStorageService.SetItemAsStringAsync("token", result.Data);
            result.Data = "Bearer " + result.Data;
            _http.SetToken(result.Data);
            return result.Data;
        }
        return string.Empty;
    }
}
