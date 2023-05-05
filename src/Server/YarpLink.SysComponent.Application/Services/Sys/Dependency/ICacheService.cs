using YarpLink.Application.Services;
using YarpLink.Domain.Dto.Sys.Cache;
using YarpLink.SysComponent.Application.Modules.Sys;

namespace YarpLink.SysComponent.Application.Services.Sys.Dependency;

/// <summary>
///     缓存服务
/// </summary>
public interface ICacheService : IService, ICacheModule
{
    /// <summary>
    ///     获取所有缓存项
    /// </summary>
    IEnumerable<GetAllEntriesRsp> GetAllEntries();
}