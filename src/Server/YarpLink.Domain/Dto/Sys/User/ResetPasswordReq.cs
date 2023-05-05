using YarpLink.Domain.Attributes.DataValidation;
using YarpLink.Domain.Dto.Sys.Sms;

namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     请求：重置密码
/// </summary>
public sealed record ResetPasswordReq : DataAbstraction
{
    /// <summary>
    ///     密码
    /// </summary>
    [Required]
    [Password]
    public string PasswordText { get; init; }

    /// <summary>
    ///     短信验证请求
    /// </summary>
    [Required]
    public VerifySmsCodeReq VerifySmsCodeReq { get; init; }
}