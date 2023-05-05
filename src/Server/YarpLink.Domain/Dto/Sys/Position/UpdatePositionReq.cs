using YarpLink.Domain.DbMaps.Dependency.Fields;

namespace YarpLink.Domain.Dto.Sys.Position;

/// <summary>
///     请求：更新岗位
/// </summary>
public sealed record UpdatePositionReq : CreatePositionReq
{
    /// <inheritdoc cref="IFieldVersion.Version" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Version { get; init; }
}