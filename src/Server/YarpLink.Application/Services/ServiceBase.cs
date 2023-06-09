using YarpLink.Domain.Contexts;

namespace YarpLink.Application.Services;

/// <inheritdoc />
public abstract class ServiceBase<TLogger> : ServiceBase
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ServiceBase{TLogger}" /> class.
    /// </summary>
    protected ServiceBase() //
    {
        Logger = App.GetService<ILogger<TLogger>>();
    }

    /// <summary>
    ///     日志记录器
    /// </summary>
    protected ILogger<TLogger> Logger { get; }
}

/// <summary>
///     服务基类
/// </summary>
public abstract class ServiceBase : IScoped, IService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ServiceBase" /> class.
    /// </summary>
    protected ServiceBase()
    {
        UserToken = App.GetService<ContextUserToken>();
        ServiceId = Guid.NewGuid();
    }

    /// <inheritdoc />
    public Guid ServiceId { get; set; }

    /// <inheritdoc />
    public ContextUserToken UserToken { get; set; }
}