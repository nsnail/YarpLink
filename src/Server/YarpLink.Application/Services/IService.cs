using YarpLink.Domain.Contexts;

namespace YarpLink.Application.Services;

/// <summary>
///     服务接口
/// </summary>
public interface IService
{
    /// <summary>
    ///     服务Id
    /// </summary>
    Guid ServiceId { get; set; }

    /// <summary>
    ///     上下文用户
    /// </summary>
    ContextUserToken UserToken { get; set; }
}