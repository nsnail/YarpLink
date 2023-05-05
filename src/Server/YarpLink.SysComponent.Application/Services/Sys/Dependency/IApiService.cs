using YarpLink.Application.Services;
using YarpLink.Domain.Dto.Sys.Api;
using YarpLink.SysComponent.Application.Modules.Sys;

namespace YarpLink.SysComponent.Application.Services.Sys.Dependency;

/// <summary>
///     接口服务
/// </summary>
public interface IApiService : IService, IApiModule
{
    /// <summary>
    ///     反射接口列表
    /// </summary>
    IEnumerable<QueryApiRsp> ReflectionList(bool excludeAnonymous = true);
}