using YarpLink.Application.Modules;
using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.UserPosition;

namespace YarpLink.SysComponent.Application.Modules.Sys;

/// <summary>
///     用户-岗位映射模块
/// </summary>
public interface IUserPositionModule : ICrudModule<CreateUserPositionReq, QueryUserPositionRsp // 创建类型
  , QueryUserPositionReq, QueryUserPositionRsp                                                 // 查询类型
  , UpdateUserPositionReq, QueryUserPositionRsp                                                // 修改类型
  , DelReq                                                                                     // 删除类型
> { }