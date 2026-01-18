using Microsoft.AspNetCore.Components.Forms;

namespace Groovy.Services
{
    public interface IAudioFileService
    {
        Task<string?> UploadAudioFileAsync(IBrowserFile file, string songTitle);
        bool DeleteAudioFile(string filePath);
        bool IsValidAudioFile(string fileName);
    }

    public class AudioFileService : IAudioFileService
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<AudioFileService> _logger;
        private const long MaxFileSize = 50 * 1024 * 1024; // 50MB
        private static readonly string[] AllowedExtensions = { ".mp3", ".wav", ".ogg", ".m4a" };

        public AudioFileService(IWebHostEnvironment environment, ILogger<AudioFileService> logger)
        {
            _environment = environment;
            _logger = logger;
        }

        public async Task<string?> UploadAudioFileAsync(IBrowserFile file, string songTitle)
        {
            try
            {
                // Validate file
                if (file == null || file.Size == 0)
                {
                    _logger.LogWarning("No file provided or file is empty");
                    return null;
                }

                if (file.Size > MaxFileSize)
                {
                    _logger.LogWarning($"File size {file.Size} exceeds maximum {MaxFileSize}");
                    return null;
                }

                var extension = Path.GetExtension(file.Name).ToLowerInvariant();
                if (!IsValidAudioFile(file.Name))
                {
                    _logger.LogWarning($"Invalid file extension: {extension}");
                    return null;
                }

                // Create audio directory if it doesn't exist
                var audioPath = Path.Combine(_environment.WebRootPath, "audio");
                if (!Directory.Exists(audioPath))
                {
                    Directory.CreateDirectory(audioPath);
                }

                // Generate safe filename
                var safeFileName = GenerateSafeFileName(songTitle, extension);
                var fullPath = Path.Combine(audioPath, safeFileName);

                // Save file
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.OpenReadStream(MaxFileSize).CopyToAsync(fileStream);
                }

                // Return relative path for database storage
                return $"/audio/{safeFileName}";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error uploading audio file");
                return null;
            }
        }

        public bool DeleteAudioFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                    return false;

                var fullPath = Path.Combine(_environment.WebRootPath, filePath.TrimStart('/'));

                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error deleting audio file: {filePath}");
                return false;
            }
        }

        public bool IsValidAudioFile(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            return AllowedExtensions.Contains(extension);
        }

        private string GenerateSafeFileName(string songTitle, string extension)
        {
            // Remove invalid characters from song title
            var invalidChars = Path.GetInvalidFileNameChars();
            var safeName = string.Join("_", songTitle.Split(invalidChars));

            // Add timestamp to ensure uniqueness
            var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmss");

            return $"{safeName}_{timestamp}{extension}";
        }
    }
}