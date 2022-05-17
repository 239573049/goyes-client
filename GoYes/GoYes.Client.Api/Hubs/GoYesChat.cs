using Blazored.LocalStorage;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Token.Inject.tag;

namespace GoYes.Client.Api.Hubs;

/// <summary>
/// 通信模块
/// </summary>
public class GoYesChat : IScopedTag
{
    public HubConnection _hubConnection;
    private readonly ILocalStorageService _localStorageService;
    private readonly IConfiguration _configuration;

    ///<inheritdoc/>
    public GoYesChat(ILocalStorageService localStorageService, IConfiguration configuration)
    {
        _localStorageService = localStorageService;
        this._configuration = configuration;
    }

    /// <summary>
    /// 启动服务
    /// </summary>
    /// <returns></returns>
    public async Task StartAsync()
    {
        if (_hubConnection?.State == HubConnectionState.Connected)
            return;
        //获取接口地址
        var baseAddress = _configuration["baseAddress"];

        //获取token
        var token = await _localStorageService.GetItemAsync<string>("token");

        _hubConnection = new HubConnectionBuilder()
            .WithUrl(baseAddress + "/" + HostApi.Chatapi + "go-yes-chat", options =>
            {
                options.AccessTokenProvider = () => Task.FromResult(token)!;
            })
            .AddMessagePackProtocol()
            .AddJsonProtocol()
            .WithAutomaticReconnect()
            .Build();

        await _hubConnection.StartAsync();
    }

    public async Task StopAsync()
    {
        await _hubConnection.StopAsync();
    }
}
