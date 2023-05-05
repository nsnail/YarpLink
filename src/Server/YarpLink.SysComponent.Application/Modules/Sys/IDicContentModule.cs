using YarpLink.Application.Modules;
using YarpLink.Domain.Dto.Dependency;
using YarpLink.Domain.Dto.Sys.Dic.Content;

namespace YarpLink.SysComponent.Application.Modules.Sys;

/// <summary>
///     字典内容模块
/// </summary>
public interface IDicContentModule : ICrudModule<CreateDicContentReq, QueryDicContentRsp // 创建类型
  , QueryDicContentReq, QueryDicContentRsp                                               // 查询类型
  , UpdateDicContentReq, QueryDicContentRsp                                              // 修改类型
  , DelReq                                                                               // 删除类型
> { }