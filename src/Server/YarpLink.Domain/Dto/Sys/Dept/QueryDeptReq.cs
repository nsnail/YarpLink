using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.Dept;

/// <summary>
///     请求：查询部门
/// </summary>
public sealed record QueryDeptReq : Sys_Dept
{
    /// <inheritdoc cref="IFieldPrimary{T}.Id" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; init; }
}