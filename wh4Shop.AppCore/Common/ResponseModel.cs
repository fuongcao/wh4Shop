namespace wh4Shop.AppCore.Common
{
    public class Response<T>
    {
        public bool success { get; set; } = true;
        public T payload { get; set; }
        public string message { get; set; } = "OK";
    }
}
