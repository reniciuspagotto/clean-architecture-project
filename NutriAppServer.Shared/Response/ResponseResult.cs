using System.Collections.Generic;

namespace NutriAppServer.Shared.Response
{
    public class ResponseResult
    {
        bool Success { get; set; }
        string[] Message { get; set; }
        List<object> Data { get; set; }
    }
}