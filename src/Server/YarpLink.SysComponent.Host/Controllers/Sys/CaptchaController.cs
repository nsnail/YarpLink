using YarpLink.Domain.Dto.Sys.Captcha;
using YarpLink.Host.Controllers;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;
using YarpLink.SysComponent.Cache.Sys;

namespace YarpLink.SysComponent.Host.Controllers.Sys;

/// <summary>
///     人机验证服务
/// </summary>
[ApiDescriptionSettings(nameof(Sys), Module = nameof(Sys))]
public sealed class CaptchaController : ControllerBase<ICaptchaService>, ICaptchaModule
{
    private readonly ICaptchaCache _captchaCache;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CaptchaController" /> class.
    /// </summary>
    public CaptchaController(ICaptchaService service, ICaptchaCache captchaCache) //
        : base(service)
    {
        _captchaCache = captchaCache;
    }

    /// <summary>
    ///     获取人机校验图
    /// </summary>
    [AllowAnonymous]
    public Task<GetCaptchaRsp> GetCaptchaImageAsync()
    {
        return _captchaCache.GetCaptchaImageAsync();
    }

    /// <summary>
    ///     完成人机校验
    /// </summary>
    [AllowAnonymous]
    public Task<bool> VerifyCaptchaAsync(VerifyCaptchaReq req)
    {
        return _captchaCache.VerifyCaptchaAsync(req);
    }
}