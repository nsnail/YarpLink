using YarpLink.BizServer.Host.Filters;
using YarpLink.Domain.Contexts;
using YarpLink.Domain.DbMaps.Dependency.Fields;
using YarpLink.Domain.Enums.Sys;
using YarpLink.Host.Extensions;

namespace YarpLink.BizServer.Host.Extensions;

/// <summary>
///     ServiceCollection 扩展方法
/// </summary>
[SuppressSniffer]
public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     注册FreeSql
    /// </summary>
    public static IServiceCollection AddFreeSql(this IServiceCollection me)
    {
        _ = me.AddFreeSql( //
            FreeSqlInitOptions.SyncStructure | FreeSqlInitOptions.InsertSeedData, freeSql => {
                // 数据权限过滤器
                _ = freeSql.GlobalFilter.ApplyOnlyIf<IFieldOwner>( //
                    Chars.FLG_GLOBAL_FILTER_DATA
                  , () => ContextUserInfo.Create()?.Roles.All(x => x.DataScope == DataScopes.Self) ?? false
                  , a => a.OwnerId == ContextUserInfo.Create().Id);
            });
        return me;
    }

    /// <summary>
    ///     jwt授权处理器
    /// </summary>
    public static IServiceCollection AddJwt(this IServiceCollection me)
    {
        _ = me.AddJwt<JwtHandler>(enableGlobalAuthorize: true);
        return me;
    }
}