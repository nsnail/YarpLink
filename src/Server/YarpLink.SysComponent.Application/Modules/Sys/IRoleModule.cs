using YarpLink.Application.Modules;
using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Role;

namespace YarpLink.SysComponent.Application.Modules.Sys;

/// <summary>
///     角色模块
/// </summary>
public interface IRoleModule : ICrudModule<CreateRoleReq, QueryRoleRsp // 创建类型
  , QueryRoleReq, QueryRoleRsp                                         // 查询类型
  , UpdateRoleReq, QueryRoleRsp                                        // 修改类型
  , DelReq                                                             // 删除类型
> { }