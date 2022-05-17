using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Token.HttpClientHelper;
using Token.Inject;

namespace GoYes.Client.Api;

/// <summary>
/// 使用模块必须要注入的工具
/// </summary>
public static class GoYesClientApiModule
{
    /// <summary>
    /// 注入接口
    /// </summary>
    /// <param name="service"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    /// <exception cref="NullReferenceException"></exception>
    public static IServiceCollection AddClientApi(this IServiceCollection service, IConfiguration configuration)
    {

        service.AddTokenHttpHelperInject(configuration["baseAddress"] ?? throw new NullReferenceException("接口地址未配置"));
        //自动注入当前模块所有接口
        service.AddAutoInject(typeof(GoYesClientApiModule));

        return service;
    }
}
