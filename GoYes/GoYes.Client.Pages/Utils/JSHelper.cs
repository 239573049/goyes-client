using Microsoft.JSInterop;
using Token.Inject.tag;

namespace GoYes.Client.Pages.Utils;

public class JSHelper : ISingletonTag
{
    private readonly IJSRuntime _jSRuntime;
    public JSHelper(IJSRuntime jSRuntime)
    {
        _jSRuntime = jSRuntime;
    }

    /// <summary>
    /// 返回上一页
    /// </summary>
    public async Task BackAsync()
    {
        await _jSRuntime.InvokeVoidAsync("history.back");
    }
}
