namespace GoYes.Client.Module.Http;
public class ResultDto<T>
{
    public int? Code { get; set; }

    public string? Message { get; set; }

    public T? Data { get; set; }
}
public class ResultDto
{
    public int? Code { get; set; }

    public string? Message { get; set; }

    public object? Data { get; set; }
}
