using System.Collections.Generic;

namespace ArquiteturaPadrao.Shared.Response
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            Message = new List<string>();
        }

        public bool Success { get; set; }
        public List<string> Message { get; set; }
        public object Data { get; set; }
    }
}