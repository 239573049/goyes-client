using System.ComponentModel.DataAnnotations;

namespace GoYes.Client.Module.Login;
public class RegisterDto
{
    [Required(ErrorMessage = "用户昵称不能为空")]
    [MinLength(3, ErrorMessage = "用户昵称最短3位")]
    [MaxLength(15, ErrorMessage = "用户昵称最长15位")]
    public string? Name { get; set; }

    /// <summary>
    ///     账号
    /// </summary>
    [Required(ErrorMessage = "账号不能为空")]
    [MinLength(5, ErrorMessage = "账号最短5位")]
    public string? AccountNumber { get; set; }

    /// <summary>
    ///     密码
    /// </summary>
    [Required(ErrorMessage = "密码不能为空")]
    [MinLength(5, ErrorMessage = "密码最短5位")]
    public string? Password { get; set; }




}
