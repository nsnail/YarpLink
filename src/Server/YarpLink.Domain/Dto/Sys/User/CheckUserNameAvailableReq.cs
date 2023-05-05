using YarpLink.Domain.Attributes.DataValidation;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     请求：检查用户名是否可用
/// </summary>
public sealed record CheckUserNameAvailableReq : Sys_User
{
    /// <inheritdoc cref="Sys_User.UserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [Required]
    [UserName]
    public override string UserName { get; init; }
}