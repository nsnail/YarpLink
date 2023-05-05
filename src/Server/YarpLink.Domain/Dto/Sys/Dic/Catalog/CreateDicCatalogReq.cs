using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.Dic.Catalog;

/// <summary>
///     请求：创建字典目录
/// </summary>
public record CreateDicCatalogReq : Sys_DicCatalog
{
    /// <inheritdoc cref="Sys_DicCatalog.Code" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [Required]
    public override string Code { get; init; }

    /// <inheritdoc cref="Sys_DicCatalog.Name" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [Required]
    public override string Name { get; init; }

    /// <inheritdoc cref="Sys_DicCatalog.ParentId" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long ParentId { get; init; }
}