using YarpLink.Domain.DbMaps.Dependency;

namespace YarpLink.Domain.DbMaps.Sys;

/// <summary>
///     角色-部门映射表
/// </summary>
[Table(Name = nameof(Sys_RoleDept))]
[Index($"idx_{{tablename}}_{nameof(RoleId)}_{nameof(DeptId)}", $"{nameof(RoleId)},{nameof(DeptId)}", true)]
public record Sys_RoleDept : ImmutableEntity
{
    /// <summary>
    ///     关联的部门
    /// </summary>
    [JsonIgnore]
    public Sys_Dept Dept { get; init; }

    /// <summary>
    ///     可访问的部门id
    /// </summary>
    [JsonIgnore]
    public long DeptId { get; init; }

    /// <summary>
    ///     关联的角色
    /// </summary>
    [JsonIgnore]
    public Sys_Role Role { get; init; }

    /// <summary>
    ///     角色id
    /// </summary>
    [JsonIgnore]
    public long RoleId { get; init; }
}