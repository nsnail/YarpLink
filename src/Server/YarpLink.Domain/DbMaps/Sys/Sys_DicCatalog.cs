using YarpLink.Domain.DbMaps.Dependency;

namespace YarpLink.Domain.DbMaps.Sys;

/// <summary>
///     字典目录表
/// </summary>
[Table(Name = nameof(Sys_DicCatalog))]
[Index($"idx_{{tablename}}_{nameof(Code)}", nameof(Code), true)]
public record Sys_DicCatalog : VersionEntity
{
    /// <summary>
    ///     子节点
    /// </summary>
    [JsonIgnore]
    [Navigate(nameof(ParentId))]
    public IEnumerable<Sys_DicCatalog> Children { get; init; }

    /// <summary>
    ///     字典编码
    /// </summary>
    [JsonIgnore]
    [Column(DbType = Chars.FLG_DB_FIELD_TYPE_VARCHAR31)]
    public virtual string Code { get; init; }

    /// <summary>
    ///     字典内容集合
    /// </summary>
    [JsonIgnore]
    [Navigate(nameof(Sys_DicContent.CatalogId))]
    public ICollection<Sys_DicContent> Contents { get; init; }

    /// <summary>
    ///     字典名称
    /// </summary>
    [JsonIgnore]
    [Column(DbType = Chars.FLG_DB_FIELD_TYPE_VARCHAR31)]
    public virtual string Name { get; init; }

    /// <summary>
    ///     父id
    /// </summary>
    [JsonIgnore]
    public virtual long ParentId { get; init; }
}