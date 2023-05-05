using YarpLink.Domain.Attributes;
using YarpLink.Domain.DbMaps.Dependency.Fields;

namespace YarpLink.Domain.DbMaps.Dependency;

/// <summary>
///     轻型不可变实体
/// </summary>
public abstract record LiteImmutableEntity : LiteImmutableEntity<long>
{
    /// <summary>
    ///     唯一编码
    /// </summary>
    [Snowflake]
    public override long Id { get; init; }
}

/// <summary>
///     轻型不可变实体
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract record LiteImmutableEntity<T> : EntityBase, IFieldPrimary<T>, IFieldCreatedTime
{
    /// <inheritdoc />
    [JsonIgnore]
    [Column(Position = -20, CanUpdate = false)]
    public virtual DateTime CreatedTime { get; init; }

    /// <summary>
    ///     唯一编码
    /// </summary>
    [JsonIgnore]
    [Column(IsIdentity = false, IsPrimary = true, Position = 1)]
    public virtual T Id { get; init; }
}