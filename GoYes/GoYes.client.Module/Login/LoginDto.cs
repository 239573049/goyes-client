using System.ComponentModel.DataAnnotations;

namespace GoYes.Client.Module.Login
{
    public class LoginDto
    {
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
}
