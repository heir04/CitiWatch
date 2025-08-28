using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CitiWatch.Infrastructure.Config;
using Microsoft.Extensions.Options;

namespace CitiWatch.Infrastructure.Services
{
    public class CloudinaryService(Cloudinary cloudinary, IOptions<CloudinaryConfig> config)
    {
        private readonly Cloudinary _cloudinary = cloudinary;
        private readonly CloudinaryConfig _config = config.Value;
        private static readonly string[] AllowedExtensions = {".jpg", ".jpeg", ".png", ".gif"};

        public async Task<string> UploadFileAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is empty");

            // Validate file extension and size
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!AllowedExtensions.Contains(extension))
                throw new ArgumentException("Invalid file type");

            var maxFileSizeBytes = _config.MaxFileSizeMB * 1024 * 1024;
            if (file.Length > maxFileSizeBytes)
                throw new ArgumentException($"File too large. Maximum size is {_config.MaxFileSizeMB}MB");

            await using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
                Folder = "complaints" 
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.StatusCode != System.Net.HttpStatusCode.OK)
                throw new Exception("File upload failed");

            if (uploadResult.Error != null)
                throw new InvalidOperationException($"Upload failed: {uploadResult.Error.Message}");

            return uploadResult.SecureUrl.ToString();
        }
    }
}