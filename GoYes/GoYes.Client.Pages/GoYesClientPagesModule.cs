using Blazored.LocalStorage;
using GoYes.Client.Api;
using GoYes.Client.Api.Oss;
using GoYes.Client.Module.Shared;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Token.Inject;

namespace GoYes.Client.Pages;
public static class GoYesClientPagesModule
{
    /// <summary>
    /// 注入Page界面
    /// </summary>
    /// <param name="service"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static async Task<IServiceCollection> AddClientPage(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddMasaBlazor();
        service.AddBlazoredLocalStorage();
        service.AddClientApi(configuration);
        service.AddAutoInject(typeof(GoYesClientPagesModule));

        // 预先设置host防止无法访问oss存储
        var http = service.BuildServiceProvider().GetService<OssApi>();
        SharedConst.Host = await http.GetHostAsync();

        return service;
    }
}
