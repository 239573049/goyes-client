using Blazored.LocalStorage;
using GoYes.Client.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
    public static IServiceCollection AddClientPage(this IServiceCollection service, IConfiguration configuration)
    {

        service.AddMasaBlazor();
        service.AddBlazoredLocalStorage();
        service.AddClientApi(configuration);
        return service;
    }
}
