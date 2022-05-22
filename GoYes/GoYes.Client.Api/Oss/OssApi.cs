using GoYes.Client.Module.Http;
using Token.HttpClientHelper;
using Token.Inject.tag;

namespace GoYes.Client.Api.Oss;

/// <summary>
/// Oss
/// </summary>
public class OssApi : IScopedTag
{
    private readonly TokenHttp _http;
    private const string host = HostApi.Adminapi + "api/Oss/";

    ///<inheritdoc/>
    public OssApi(
    TokenHttp http
    )
    {
        _http = http;
    }

    /// <summary>
    /// 上传文件
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task<string?> Uploading(UploadingDto dto)
    {
        dto.Name = "file";
        var result = await _http.UploadingFile<ResultDto<string>>(host + "uploading", dto);
        return result.Data;
    }

    /// <summary>
    /// 删除文件
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public async Task<bool> DeleteAsync(string fileName)
    {
        var result = await _http.DeleteAsync<ResultDto<bool>>(host + "delete?fileName=" + fileName);

        return result.Data;
    }
}
