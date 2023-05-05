using YarpLink.Application.Modules;
using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Config;

namespace YarpLink.SysComponent.Application.Modules.Sys;

/// <summary>
///     配置模块
/// </summary>
public interface IConfigModule : ICrudModule<CreateConfigReq, QueryConfigRsp // 创建类型
  , QueryConfigReq, QueryConfigRsp                                           // 查询类型
  , UpdateConfigReq, QueryConfigRsp                                          // 修改类型
  , DelReq                                                                   // 删除类型
>
{
    /// <summary>
    ///     获取最新有效配置
    /// </summary>
    Task<QueryConfigRsp> GetLatestConfigAsync();
}