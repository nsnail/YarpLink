using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Config;
using YarpLink.Host.Attributes;
using YarpLink.Host.Controllers;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Host.Controllers.Sys;

/// <summary>
///     配置服务
/// </summary>
[ApiDescriptionSettings(nameof(Sys), Module = nameof(Sys))]
public sealed class ConfigController : ControllerBase<IConfigService>, IConfigModule
{
    private readonly IConfigService _configService;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ConfigController" /> class.
    /// </summary>
    public ConfigController(IConfigService service, IConfigService configService) //
        : base(service)
    {
        _configService = configService;
    }

    /// <summary>
    ///     批量删除配置
    /// </summary>
    [Transaction]
    public Task<int> BulkDeleteAsync(BulkReq<DelReq> req)
    {
        return Service.BulkDeleteAsync(req);
    }

    /// <summary>
    ///     创建配置
    /// </summary>
    [Transaction]
    public Task<QueryConfigRsp> CreateAsync(CreateConfigReq req)
    {
        return Service.CreateAsync(req);
    }

    /// <summary>
    ///     删除配置
    /// </summary>
    [Transaction]
    public Task<int> DeleteAsync(DelReq req)
    {
        return Service.DeleteAsync(req);
    }

    /// <summary>
    ///     配置是否存在
    /// </summary>
    [NonAction]
    public Task<bool> ExistAsync(QueryReq<QueryConfigReq> req)
    {
        return Service.ExistAsync(req);
    }

    /// <inheritdoc />
    [NonAction]
    public Task<QueryConfigRsp> GetAsync(QueryConfigReq req)
    {
        return Service.GetAsync(req);
    }

    /// <summary>
    ///     获取最新有效配置
    /// </summary>
    public Task<QueryConfigRsp> GetLatestConfigAsync()
    {
        return _configService.GetLatestConfigAsync();
    }

    /// <summary>
    ///     分页查询配置
    /// </summary>
    public Task<PagedQueryRsp<QueryConfigRsp>> PagedQueryAsync(PagedQueryReq<QueryConfigReq> req)
    {
        return Service.PagedQueryAsync(req);
    }

    /// <summary>
    ///     查询配置
    /// </summary>
    public Task<IEnumerable<QueryConfigRsp>> QueryAsync(QueryReq<QueryConfigReq> req)
    {
        return Service.QueryAsync(req);
    }

    /// <summary>
    ///     更新配置
    /// </summary>
    [Transaction]
    public Task<QueryConfigRsp> UpdateAsync(UpdateConfigReq req)
    {
        return Service.UpdateAsync(req);
    }
}