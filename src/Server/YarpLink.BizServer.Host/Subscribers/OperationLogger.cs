using YarpLink.Domain.Dto.Sys.RequestLog;
using YarpLink.Domain.Dto.Sys.User;
using YarpLink.Domain.Events;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.BizServer.Host.Subscribers;

/// <summary>
///     操作日志记录
/// </summary>
public sealed class OperationLogger : IEventSubscriber
{
    /// <summary>
    ///     保存请求日志到数据库
    /// </summary>
    [EventSubscribe(nameof(RequestLogEvent))]
    public async Task OperationEventDbRecordAsync(EventHandlerExecutingContext context)
    {
        if (context.Source is not RequestLogEvent operationEvent) {
            return;
        }

        // 跳过心跳请求
        if (operationEvent.Data.ApiId.Equals("api/health/check", StringComparison.OrdinalIgnoreCase)) {
            return;
        }

        CreateRequestLogReq logReq = null;

        // 登录日志特殊处理
        if (operationEvent.Data.ApiId.Equals("api/user/login", StringComparison.OrdinalIgnoreCase)) {
            try {
                var loginReq = operationEvent.Data.RequestBody.ToObject<PwdLoginReq>();
                logReq = operationEvent.Data with { ExtraData = loginReq.Account };
            }
            catch {
                // ignored
            }
        }

        logReq ??= operationEvent.Data;
        var logService = App.GetService<IRequestLogService>();
        logReq.TruncateStrings();
        _ = await logService.CreateAsync(logReq);
    }
}