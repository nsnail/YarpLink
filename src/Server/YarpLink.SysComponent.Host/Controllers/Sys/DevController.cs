using YarpLink.Domain.Dto.Sys.Dev;
using YarpLink.Host.Controllers;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Host.Controllers.Sys;

/// <summary>
///     开发服务
/// </summary>
[ApiDescriptionSettings(nameof(Sys), Module = nameof(Sys))]
public sealed class DevController : ControllerBase<IDevService>, IDevModule
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DevController" /> class.
    /// </summary>
    public DevController(IDevService service) //
        : base(service) { }

    /// <summary>
    ///     生成后端代码
    /// </summary>
    public Task GenerateCsCodeAsync(GenerateCsCodeReq req)
    {
        return Service.GenerateCsCodeAsync(req);
    }

    /// <summary>
    ///     生成图标代码
    /// </summary>
    public Task GenerateIconCodeAsync(GenerateIconCodeReq req)
    {
        return Service.GenerateIconCodeAsync(req);
    }

    /// <summary>
    ///     生成接口代码
    /// </summary>
    public Task GenerateJsCodeAsync()
    {
        return Service.GenerateJsCodeAsync();
    }
}