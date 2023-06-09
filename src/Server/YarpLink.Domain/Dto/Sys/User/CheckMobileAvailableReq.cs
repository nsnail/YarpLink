using YarpLink.Domain.Attributes.DataValidation;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     请求：检查手机号是否可用
/// </summary>
public sealed record CheckMobileAvailableReq : Sys_User
{
    /// <inheritdoc cref="Sys_User.Mobile" />
    [Mobile]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override string Mobile { get; init; }
}