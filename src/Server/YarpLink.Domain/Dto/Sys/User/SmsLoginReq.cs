using YarpLink.Domain.Dto.Sys.Sms;

namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     请求：短信登录
/// </summary>
public sealed record SmsLoginReq : VerifySmsCodeReq;