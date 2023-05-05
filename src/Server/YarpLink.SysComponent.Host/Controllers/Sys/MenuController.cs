using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Menu;
using YarpLink.Host.Attributes;
using YarpLink.Host.Controllers;
using YarpLink.SysComponent.Application.Modules.Sys;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Host.Controllers.Sys;

/// <summary>
///     菜单服务
/// </summary>
[ApiDescriptionSettings(nameof(Sys), Module = nameof(Sys))]
public sealed class MenuController : ControllerBase<IMenuService>, IMenuModule
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="MenuController" /> class.
    /// </summary>
    public MenuController(IMenuService service) //
        : base(service) { }

    /// <summary>
    ///     批量删除菜单
    /// </summary>
    [Transaction]
    public Task<int> BulkDeleteAsync(BulkReq<DelReq> req)
    {
        return Service.BulkDeleteAsync(req);
    }

    /// <summary>
    ///     创建菜单
    /// </summary>
    [Transaction]
    public Task<QueryMenuRsp> CreateAsync(CreateMenuReq req)
    {
        return Service.CreateAsync(req);
    }

    /// <summary>
    ///     删除菜单
    /// </summary>
    [Transaction]
    public Task<int> DeleteAsync(DelReq req)
    {
        return Service.DeleteAsync(req);
    }

    /// <summary>
    ///     菜单是否存在
    /// </summary>
    [NonAction]
    public Task<bool> ExistAsync(QueryReq<QueryMenuReq> req)
    {
        return Service.ExistAsync(req);
    }

    /// <inheritdoc />
    [NonAction]
    public Task<QueryMenuRsp> GetAsync(QueryMenuReq req)
    {
        return Service.GetAsync(req);
    }

    /// <summary>
    ///     分页查询菜单
    /// </summary>
    [NonAction]
    public Task<PagedQueryRsp<QueryMenuRsp>> PagedQueryAsync(PagedQueryReq<QueryMenuReq> req)
    {
        return Service.PagedQueryAsync(req);
    }

    /// <summary>
    ///     查询菜单
    /// </summary>
    public Task<IEnumerable<QueryMenuRsp>> QueryAsync(QueryReq<QueryMenuReq> req)
    {
        return Service.QueryAsync(req);
    }

    /// <summary>
    ///     更新菜单
    /// </summary>
    [Transaction]
    public Task<QueryMenuRsp> UpdateAsync(UpdateMenuReq req)
    {
        return Service.UpdateAsync(req);
    }

    /// <summary>
    ///     当前用户菜单
    /// </summary>
    public Task<IEnumerable<QueryMenuRsp>> UserMenusAsync()
    {
        return Service.UserMenusAsync();
    }
}