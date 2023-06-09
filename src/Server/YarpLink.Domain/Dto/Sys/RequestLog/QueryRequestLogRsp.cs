using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.DbMaps.Sys;

namespace YarpLink.Domain.Dto.Sys.RequestLog;

/// <summary>
///     响应：查询请求日志
/// </summary>
public sealed record QueryRequestLogRsp : Sys_RequestLog, IRegister
{
    /// <summary>
    ///     操作系统
    /// </summary>
    public string Os => UserAgentParser.Create(UserAgent).Platform;

    /// <inheritdoc cref="Sys_RequestLog.ApiId" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ApiId { get; init; }

    /// <summary>
    ///     接口描述
    /// </summary>
    public string ApiSummary { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ClientIp" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ClientIp { get; init; }

    /// <inheritdoc cref="IFieldCreatedTime.CreatedTime" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override DateTime CreatedTime { get; init; }

    /// <inheritdoc cref="IFieldCreatedUser.CreatedUserName" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string CreatedUserName { get; set; }

    /// <inheritdoc cref="Sys_RequestLog.Duration" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override long Duration { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ErrorCode" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override ErrorCodes ErrorCode { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.Exception" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Exception { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ExtraData" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ExtraData { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.HttpStatusCode" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public override int HttpStatusCode { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.Method" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string Method { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ReferUrl" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ReferUrl { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.RequestBody" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string RequestBody { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.RequestContentType" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string RequestContentType { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.RequestHeaders" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string RequestHeaders { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.RequestUrl" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string RequestUrl { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ResponseBody" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ResponseBody { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ResponseContentType" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ResponseContentType { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ResponseHeaders" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ResponseHeaders { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.ServerIp" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string ServerIp { get; init; }

    /// <inheritdoc cref="Sys_RequestLog.UserAgent" />
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public override string UserAgent { get; init; }

    /// <inheritdoc cref="IRegister.Register" />
    public void Register(TypeAdapterConfig config)
    {
        _ = config.ForType<Sys_RequestLog, QueryRequestLogRsp>().Map(dest => dest.ApiSummary, src => src.Api.Summary);
    }
}