using YarpLink.Cache;
using YarpLink.Domain.Dto.Sys.Captcha;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Cache.Sys;

/// <summary>
///     人机验证缓存接口
/// </summary>
public interface ICaptchaCache : ICache<IDistributedCache, ICaptchaService>, ICaptchaModule
{
    /// <summary>
    ///     完成人机校验 ，并删除缓存项
    /// </summary>
    Task VerifyCaptchaAndRemoveAsync(VerifyCaptchaReq req);
}