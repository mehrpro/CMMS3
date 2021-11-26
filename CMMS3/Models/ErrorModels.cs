using Newtonsoft.Json;

namespace CMMS3.Models
{
    public class ErrorModels
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}