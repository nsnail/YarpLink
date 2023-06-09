namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     响应：密码登录
/// </summary>
public sealed record LoginRsp : DataAbstraction
{
    /// <summary>
    ///     访问令牌
    /// </summary>
    public string AccessToken { get; init; }

    /// <summary>
    ///     刷新令牌
    /// </summary>
    public string RefreshToken { get; init; }
}