using YarpLink.Domain.Dto.Sys.Sms;
using YarpLink.Domain.Enums.Sys;
using YarpLink.Domain.Events;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.BizServer.Host.Subscribers;

/// <summary>
///     短信验证码发送器
/// </summary>
public sealed class SmsCodeSender : IEventSubscriber
{
    private readonly ILogger<SmsCodeSender> _logger;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SmsCodeSender" /> class.
    /// </summary>
    public SmsCodeSender(ILogger<SmsCodeSender> logger)
    {
        _logger = logger;
    }

    /// <summary>
    ///     发送短信
    /// </summary>
    [EventSubscribe(nameof(SmsCodeCreatedEvent))]
    public async Task SyncApiAsync(EventHandlerExecutingContext context)
    {
        if (context.Source is not SmsCodeCreatedEvent smsCodeCreatedEvent) {
            return;
        }

        // 发送...
        var smsService = App.GetService<ISmsService>();
        _ = await smsService.UpdateAsync(
            smsCodeCreatedEvent.Data.Adapt<UpdateSmsReq>() with { Status = SmsStatues.Sent });
        _logger.Info($"{nameof(ISmsService)}.{nameof(ISmsService.UpdateAsync)} {Ln.Completed}");
    }
}