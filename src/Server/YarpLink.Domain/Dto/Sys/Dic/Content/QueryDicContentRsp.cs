using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.Dic.Content;

/// <summary>
///     响应：查询字典内容
/// </summary>
public sealed record QueryDicContentRsp : Sys_DicContent
{
    /// <inheritdoc cref="Sys_DicContent.CatalogId" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long CatalogId { get; init; }

    /// <inheritdoc cref="IFieldCreatedTime.CreatedTime" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override DateTime CreatedTime { get; init; }

    /// <inheritdoc cref="Sys_DicContent.Key" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Key { get; init; }

    /// <inheritdoc cref="Sys_DicContent.Value" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Value { get; init; }

    /// <inheritdoc cref="IFieldVersion.Version" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; init; }
}