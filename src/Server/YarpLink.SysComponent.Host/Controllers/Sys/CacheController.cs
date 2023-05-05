using YarpLink.Domain.Dto.Sys.Cache;
using YarpLink.Host.Controllers;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Host.Controllers.Sys;

/// <summary>
///     缓存服务
/// </summary>
[ApiDescriptionSettings(nameof(Sys), Module = nameof(Sys))]
public sealed class CacheController : ControllerBase<ICacheService>, ICacheModule
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CacheController" /> class.
    /// </summary>
    public CacheController(ICacheService service) //
        : base(service) { }

    /// <summary>
    ///     缓存统计
    /// </summary>
    public CacheStatisticsRsp CacheStatistics()
    {
        return Service.CacheStatistics();
    }

    /// <summary>
    ///     清空缓存
    /// </summary>
    public void Clear()
    {
        Service.Clear();
    }
}