using YarpLink.Application.Repositories;
using YarpLink.Application.Services;
using YarpLink.Domain.DbMaps.Sys;
using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.UserPosition;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Application.Services.Sys;

/// <inheritdoc cref="IUserPositionService" />
public sealed class UserPositionService : RepositoryService<Sys_UserPosition, IUserPositionService>
                                        , IUserPositionService
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="UserPositionService" /> class.
    /// </summary>
    public UserPositionService(Repository<Sys_UserPosition> rpo) //
        : base(rpo) { }

    /// <summary>
    ///     批量删除用户-岗位映射
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
    ///     创建用户-岗位映射
    /// </summary>
    public async Task<QueryUserPositionRsp> CreateAsync(CreateUserPositionReq req)
    {
        var ret = await Rpo.InsertAsync(req);
        return ret.Adapt<QueryUserPositionRsp>();
    }

    /// <summary>
    ///     删除用户-岗位映射
    /// </summary>
    public Task<int> DeleteAsync(DelReq req)
    {
        return Rpo.DeleteAsync(a => a.Id == req.Id);
    }

    /// <inheritdoc />
    public Task<bool> ExistAsync(QueryReq<QueryUserPositionReq> req)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public Task<QueryUserPositionRsp> GetAsync(QueryUserPositionReq req)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     分页查询用户-岗位映射
    /// </summary>
    public async Task<PagedQueryRsp<QueryUserPositionRsp>> PagedQueryAsync(PagedQueryReq<QueryUserPositionReq> req)
    {
        var list = await QueryInternal(req).Page(req.Page, req.PageSize).Count(out var total).ToListAsync();

        return new PagedQueryRsp<QueryUserPositionRsp>(req.Page, req.PageSize, total
                                                     , list.Adapt<IEnumerable<QueryUserPositionRsp>>());
    }

    /// <summary>
    ///     查询用户-岗位映射
    /// </summary>
    public async Task<IEnumerable<QueryUserPositionRsp>> QueryAsync(QueryReq<QueryUserPositionReq> req)
    {
        var ret = await QueryInternal(req).Take(req.Count).ToListAsync();
        return ret.Adapt<IEnumerable<QueryUserPositionRsp>>();
    }

    /// <summary>
    ///     更新用户-岗位映射
    /// </summary>
    public async Task<QueryUserPositionRsp> UpdateAsync(UpdateUserPositionReq req)
    {
        var ret = await Rpo.UpdateDiy.SetSource(req).ExecuteUpdatedAsync();
        return ret.FirstOrDefault()?.Adapt<QueryUserPositionRsp>();
    }

    private ISelect<Sys_UserPosition> QueryInternal(QueryReq<QueryUserPositionReq> req)
    {
        return Rpo.Select.WhereDynamicFilter(req.DynamicFilter)
                  .WhereDynamic(req.Filter)
                  .OrderByPropertyNameIf(req.Prop?.Length > 0, req.Prop, req.Order == Orders.Ascending)
                  .OrderByDescending(a => a.Id);
    }
}