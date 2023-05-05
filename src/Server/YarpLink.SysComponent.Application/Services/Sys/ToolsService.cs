using YarpLink.Application.Services;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Application.Services.Sys;

/// <inheritdoc cref="IToolsService" />
public sealed class ToolsService : ServiceBase<IToolsService>, IToolsService
{
    /// <inheritdoc />
    public DateTime GetServerUtcTime()
    {
        return DateTime.UtcNow;
    }

    /// <inheritdoc />
    public string Version()
    {
        return Global.ProductVersion;
    }
}