using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.Config;

/// <summary>
///     请求：查询配置
/// </summary>
public sealed record QueryConfigReq : Sys_Config
{
    /// <summary>
    ///     是否启用
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public new bool? Enabled { get; init; }

    /// <inheritdoc cref="IFieldPrimary{T}.Id" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Id { get; init; }
}