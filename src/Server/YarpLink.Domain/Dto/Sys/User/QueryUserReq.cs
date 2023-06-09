using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     请求：查询用户
/// </summary>
public sealed record QueryUserReq : Sys_User
{
    /// <summary>
    ///     部门id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long DeptId { get; init; }

    /// <summary>
    ///     id
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; init; }

    /// <summary>
    ///     岗位id
    /// </summary>
    public long PositionId { get; init; }

    /// <summary>
    ///     角色id
    /// </summary>
    public long RoleId { get; init; }
}