using System.Collections.Generic;

namespace ArquiteturaPadrao.Shared.Response
{
    public class ResponseResult
    {
        bool Success { get; set; }
        string[] Message { get; set; }
        List<object> Data { get; set; }
    }
}