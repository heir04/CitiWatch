namespace CitiWatch.Infrastructure.Config
{
    public class CloudinaryConfig
    {
        public string CloudName { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string ApiSecret { get; set; } = string.Empty;
        public int MaxFileSizeMB { get; set; } = 10; // Default 10MB
    }
}