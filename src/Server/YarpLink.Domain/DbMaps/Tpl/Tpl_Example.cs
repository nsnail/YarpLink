using YarpLink.Domain.DbMaps.Dependency;

namespace YarpLink.Domain.DbMaps.Tpl;

/// <summary>
///     示例表
/// </summary>
[Table(Name = nameof(Tpl_Example))]
public record Tpl_Example : VersionEntity;