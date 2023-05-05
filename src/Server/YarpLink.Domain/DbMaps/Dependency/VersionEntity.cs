using YarpLink.Domain.Attributes;
using YarpLink.Domain.DbMaps.Dependency.Fields;

namespace YarpLink.Domain.DbMaps.Dependency;

/// <summary>
///     乐观锁可变实体
/// </summary>
public abstract record VersionEntity : VersionEntity<long>
{
    /// <summary>
    ///     唯一编码
    /// </summary>
    [Snowflake]
    public override long Id { get; init; }
}

/// <summary>
///     乐观锁可变实体
/// </summary>
public abstract record VersionEntity<T> : LiteVersionEntity<T>, IFieldModifiedUser
{
    /// <inheritdoc />
    [JsonIgnore]
    [Column(Position = -13, CanInsert = false)]
    public long? ModifiedUserId { get; init; }

    /// <inheritdoc />
    [JsonIgnore]
    [Column(Position = -12, DbType = Chars.FLG_DB_FIELD_TYPE_VARCHAR31, CanInsert = false)]
    public string ModifiedUserName { get; init; }
}