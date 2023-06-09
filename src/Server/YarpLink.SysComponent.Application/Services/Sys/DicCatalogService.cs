using YarpLink.Application.Repositories;
using YarpLink.Application.Services;
using YarpLink.Domain.DbMaps.Sys;
using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Dic.Catalog;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Application.Services.Sys;

/// <inheritdoc cref="IDicCatalogService" />
public sealed class DicCatalogService : RepositoryService<Sys_DicCatalog, IDicCatalogService>, IDicCatalogService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DicCatalogService" /> class.
    /// </summary>
    public DicCatalogService(Repository<Sys_DicCatalog> rpo) //
        : base(rpo) { }

    /// <summary>
    ///     批量删除字典目录
    /// </summary>
    public async Task<int> BulkDeleteAsync(BulkReq<DelReq> req)
    {
        var sum = 0;
        foreach (var item in req.Items) {
            sum += await DeleteAsync(item);
        }

        return sum;
    }

    /// <summary>
    ///     创建字典目录
    /// </summary>
    /// <exception cref="LineInvalidOperationException">The_parent_node_does_not_exist</exception>
    public async Task<QueryDicCatalogRsp> CreateAsync(CreateDicCatalogReq req)
    {
        if (req.ParentId != 0 && !await Rpo.Select.Where(a => a.Id == req.ParentId).ForUpdate().AnyAsync()) {
            throw new LineInvalidOperationException(Ln.The_parent_node_does_not_exist);
        }

        var ret = await Rpo.InsertAsync(req);
        return ret.Adapt<QueryDicCatalogRsp>();
    }

    /// <summary>
    ///     删除字典目录
    /// </summary>
    public async Task<int> DeleteAsync(DelReq req)
    {
        var ret = await Rpo.DeleteCascadeByDatabaseAsync(a => a.Id == req.Id);
        return ret.Count;
    }

    /// <inheritdoc />
    public Task<bool> ExistAsync(QueryReq<QueryDicCatalogReq> req)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<QueryDicCatalogRsp> GetAsync(QueryDicCatalogReq req)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     分页查询字典目录
    /// </summary>
    public async Task<PagedQueryRsp<QueryDicCatalogRsp>> PagedQueryAsync(PagedQueryReq<QueryDicCatalogReq> req)
    {
        var list = await QueryInternal(req).Page(req.Page, req.PageSize).Count(out var total).ToListAsync();

        return new PagedQueryRsp<QueryDicCatalogRsp>(req.Page, req.PageSize, total
                                                   , list.Adapt<IEnumerable<QueryDicCatalogRsp>>());
    }

    /// <summary>
    ///     查询字典目录
    /// </summary>
    public async Task<IEnumerable<QueryDicCatalogRsp>> QueryAsync(QueryReq<QueryDicCatalogReq> req)
    {
        var ret = await QueryInternal(req).ToTreeListAsync();
        return ret.Adapt<IEnumerable<QueryDicCatalogRsp>>();
    }

    /// <summary>
    ///     更新字典目录
    /// </summary>
    /// <exception cref="LineInvalidOperationException">The_parent_node_does_not_exist</exception>
    /// <exception cref="LineUnexpectedException">LineUnexpectedException</exception>
    public async Task<QueryDicCatalogRsp> UpdateAsync(UpdateDicCatalogReq req)
    {
        if (req.ParentId != 0 && !await Rpo.Select.Where(a => a.Id == req.ParentId).ForUpdate().AnyAsync()) {
            throw new LineInvalidOperationException(Ln.The_parent_node_does_not_exist);
        }

        if (await Rpo.UpdateDiy.SetSource(req).ExecuteAffrowsAsync() <= 0) {
            throw new LineUnexpectedException();
        }

        var ret = await Rpo.Select.Where(a => a.Id == req.Id).ToOneAsync();
        return ret.Adapt<QueryDicCatalogRsp>();
    }

    private ISelect<Sys_DicCatalog> QueryInternal(QueryReq<QueryDicCatalogReq> req)
    {
        return Rpo.Select.WhereDynamicFilter(req.DynamicFilter)
                  .WhereDynamic(req.Filter)
                  .OrderByPropertyNameIf(req.Prop?.Length > 0, req.Prop, req.Order == Orders.Ascending)
                  .OrderByDescending(a => a.Id);
    }
}