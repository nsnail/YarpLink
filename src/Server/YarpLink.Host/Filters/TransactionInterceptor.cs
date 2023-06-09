using YarpLink.Host.Attributes;
using YarpLink.Host.Extensions;

namespace YarpLink.Host.Filters;

/// <summary>
///     事务拦截器
/// </summary>
[SuppressSniffer]
public sealed class TransactionInterceptor : IAsyncActionFilter
{
    private readonly UnitOfWorkManager _uowManager;

    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionInterceptor" /> class.
    ///     事务拦截器
    /// </summary>
    public TransactionInterceptor(UnitOfWorkManager uowManager)
    {
        _uowManager = uowManager;
    }

    /// <inheritdoc />
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        // 跳过没有事务特性标记的方法
        if (context.HttpContext.GetControllerActionDescriptor()
                   .MethodInfo.GetCustomAttribute<TransactionAttribute>() is null) {
            _ = await next();
            return;
        }

        // 事务操作
        await _uowManager.AtomicOperateAsync(async () => {
            var result = await next();
            if (result.Exception is not null) {
                throw result.Exception;
            }
        });
    }
}