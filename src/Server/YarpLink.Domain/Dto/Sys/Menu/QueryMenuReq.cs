using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.Menu;

/// <summary>
///     请求：查询菜单
/// </summary>
public sealed record QueryMenuReq : Sys_Menu
{
    /// <inheritdoc cref="IFieldPrimary{T}.Id" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; init; }
}