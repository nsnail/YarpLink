using YarpLink.Application.Services;

namespace YarpLink.Host.Controllers;

/// <summary>
///     控制器基类
/// </summary>
public abstract class ControllerBase<TService> : IDynamicApiController
    where TService : IService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ControllerBase{TService}" /> class.
    /// </summary>
    protected ControllerBase(TService service)
    {
        Service = service;
    }

    /// <summary>
    ///     关联的服务
    /// </summary>
    protected TService Service { get; }
}