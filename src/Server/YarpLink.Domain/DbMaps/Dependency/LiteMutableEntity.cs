using YarpLink.Domain.Attributes;
using YarpLink.Domain.DbMaps.Dependency.Fields;

namespace YarpLink.Domain.DbMaps.Dependency;

/// <summary>
///     轻型可变实体
/// </summary>
public abstract record LiteMutableEntity : LiteMutableEntity<long>
{
    /// <summary>
    ///     唯一编码
    /// </summary>
    [Snowflake]
    [JsonIgnore]
    public override long Id { get; init; }
}

/// <summary>
///     轻型可变实体
/// </summary>
public abstract record LiteMutableEntity<T> : LiteImmutableEntity<T>, IFieldModifiedTime
{
    /// <inheritdoc />
    [JsonIgnore]
    [Column(Position = -11, CanInsert = false)]
    public virtual DateTime? ModifiedTime { get; init; }
}