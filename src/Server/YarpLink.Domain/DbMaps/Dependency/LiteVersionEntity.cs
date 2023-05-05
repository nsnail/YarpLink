using YarpLink.Domain.Attributes;
using YarpLink.Domain.DbMaps.Dependency.Fields;

namespace YarpLink.Domain.DbMaps.Dependency;

/// <summary>
///     乐观锁轻型可变实体
/// </summary>
public abstract record LiteVersionEntity : LiteVersionEntity<long>
{
    /// <summary>
    ///     唯一编码
    /// </summary>
    [Snowflake]
    [JsonIgnore]
    public override long Id { get; init; }
}

/// <summary>
///     乐观锁轻型可变实体
/// </summary>
public abstract record LiteVersionEntity<T> : LiteMutableEntity<T>, IFieldVersion
{
    /// <inheritdoc />
    [JsonIgnore]
    [Column(Position = -10, IsVersion = true)]
    public virtual long Version { get; init; }
}