using BlazorComponent;
using Masa.Blazor;
using Token.Inject.tag;

namespace GoYes.Client.Pages.Utils;

/// <summary>
/// 提示服务
/// </summary>
public class Messages : IScopedTag
{
    private readonly IPopupService _popup;
    public Messages(
    IPopupService popup
    )
    {
        _popup = popup;
    }


    /// <summary>
    /// 成功提示
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task MessageSuceess(string value)
    {
        await _popup.ConfirmAsync((config) =>
        {

        });
    }

    /// <summary>
    /// 警告提示
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task MessageWarning(string value)
    {
        await _popup.ConfirmAsync("警告", value, AlertTypes.Warning);
    }

    /// <summary>
    /// 异常提示
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task MessageError(string value)
    {
        await _popup.ConfirmAsync("错误", value, AlertTypes.Error);
    }

    /// <summary>
    /// 信息提示
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public async Task MessageInfo(string value)
    {
        await _popup.ConfirmAsync("信息", value, AlertTypes.Info);
    }
}
