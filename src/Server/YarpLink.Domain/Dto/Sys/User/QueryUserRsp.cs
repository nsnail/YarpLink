using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;
using YarpLink.Domain.Dto.Sys.Dept;
using YarpLink.Domain.Dto.Sys.Position;
using YarpLink.Domain.Dto.Sys.Role;

namespace YarpLink.Domain.Dto.Sys.User;

/// <summary>
///     响应：查询用户
/// </summary>
public record QueryUserRsp : Sys_User
{
    /// <inheritdoc cref="Sys_User.Avatar" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Avatar { get; init; }

    /// <inheritdoc cref="IFieldCreatedTime.CreatedTime" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override DateTime CreatedTime { get; init; }

    /// <summary>
    ///     部门
    /// </summary>
    public new QueryDeptRsp Dept { get; init; }

    /// <inheritdoc cref="Sys_User.Email" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Email { get; init; }

    /// <inheritdoc cref="IFieldEnabled.Enabled" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override bool Enabled { get; init; }

    /// <inheritdoc cref="IFieldPrimary{T}.Id" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; init; }

    /// <inheritdoc cref="Sys_User.Mobile" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Mobile { get; init; }

    /// <summary>
    ///     岗位列表
    /// </summary>
    public new IEnumerable<QueryPositionRsp> Positions { get; init; }

    /// <summary>
    ///     角色列表
    /// </summary>
    public new IEnumerable<QueryRoleRsp> Roles { get; init; }

    /// <inheritdoc cref="Sys_User.UserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string UserName { get; init; }

    /// <inheritdoc cref="IFieldVersion.Version" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; init; }
}