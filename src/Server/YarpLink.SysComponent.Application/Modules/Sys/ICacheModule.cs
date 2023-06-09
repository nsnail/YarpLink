using YarpLink.Domain.Dto.Sys.Cache;

namespace YarpLink.SysComponent.Application.Modules.Sys;

/// <summary>
///     缓存模块
/// </summary>
public interface ICacheModule
{
    /// <summary>
    ///     缓存统计
    /// </summary>
    CacheStatisticsRsp CacheStatistics();

    /// <summary>
    ///     清空缓存
    /// </summary>
    void Clear();
}