using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.Api;

/// <summary>
///     响应：查询接口
/// </summary>
public sealed record QueryApiRsp : Sys_Api
{
    /// <summary>
    ///     子节点
    /// </summary>
    public new IEnumerable<QueryApiRsp> Children { get; init; }

    /// <inheritdoc cref="IFieldPrimary{T}.Id" />
    public override string Id { get; init; }

    /// <inheritdoc cref="Sys_Api.Method" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Method { get; init; }

    /// <inheritdoc cref="Sys_Api.Name" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Name { get; init; }

    /// <inheritdoc cref="Sys_Api.Namespace" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Namespace { get; init; }

    /// <inheritdoc cref="Sys_Api.ParentId" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ParentId { get; init; }

    /// <inheritdoc cref="IFieldSummary.Summary" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Summary { get; init; }
}