namespace YarpLink.Infrastructure.Extensions;

/// <summary>
///     Object 扩展类
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    ///     object -> json
    /// </summary>
    public static string ToJson(this object me)
    {
        return me.Json(Global.JsonSerializerOptions);
    }
}