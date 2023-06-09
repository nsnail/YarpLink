using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Position;
using YarpLink.Host.Attributes;
using YarpLink.Host.Controllers;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Host.Controllers.Sys;

/// <summary>
///     岗位服务
/// </summary>
[ApiDescriptionSettings(nameof(Sys), Module = nameof(Sys))]
public sealed class PositionController : ControllerBase<IPositionService>, IPositionModule
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PositionController" /> class.
    /// </summary>
    public PositionController(IPositionService service) //
        : base(service) { }

    /// <summary>
    ///     批量删除岗位
    /// </summary>
    [Transaction]
    public Task<int> BulkDeleteAsync(BulkReq<DelReq> req)
    {
        return Service.BulkDeleteAsync(req);
    }

    /// <summary>
    ///     创建岗位
    /// </summary>
    [Transaction]
    public Task<QueryPositionRsp> CreateAsync(CreatePositionReq req)
    {
        return Service.CreateAsync(req);
    }

    /// <summary>
    ///     删除岗位
    /// </summary>
    [Transaction]
    public Task<int> DeleteAsync(DelReq req)
    {
        return Service.DeleteAsync(req);
    }

    /// <summary>
    ///     岗位是否存在
    /// </summary>
    [NonAction]
    public Task<bool> ExistAsync(QueryReq<QueryPositionReq> req)
    {
        return Service.ExistAsync(req);
    }

    /// <inheritdoc />
    [NonAction]
    public Task<QueryPositionRsp> GetAsync(QueryPositionReq req)
    {
        return Service.GetAsync(req);
    }

    /// <summary>
    ///     分页查询岗位
    /// </summary>
    public Task<PagedQueryRsp<QueryPositionRsp>> PagedQueryAsync(PagedQueryReq<QueryPositionReq> req)
    {
        return Service.PagedQueryAsync(req);
    }

    /// <summary>
    ///     查询岗位
    /// </summary>
    public Task<IEnumerable<QueryPositionRsp>> QueryAsync(QueryReq<QueryPositionReq> req)
    {
        return Service.QueryAsync(req);
    }

    /// <summary>
    ///     更新岗位
    /// </summary>
    [Transaction]
    public Task<QueryPositionRsp> UpdateAsync(UpdatePositionReq req)
    {
        return Service.UpdateAsync(req);
    }
}