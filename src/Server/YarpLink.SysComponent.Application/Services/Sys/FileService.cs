using YarpLink.Application.Services;
using YarpLink.SysComponent.Application.Services.Sys.Dependency;

namespace YarpLink.SysComponent.Application.Services.Sys;

/// <inheritdoc cref="IFileService" />
public sealed class FileService : ServiceBase<IFileService>, IFileService
{
    private readonly MinioHelper   _minioHelper;
    private readonly UploadOptions _uploadOptions;

    /// <summary>
    ///     Initializes a new instance of the <see cref="FileService" /> class.
    /// </summary>
    public FileService(IOptions<UploadOptions> uploadOptions, MinioHelper minioHelper) //
    {
        _minioHelper   = minioHelper;
        _uploadOptions = uploadOptions.Value;
    }

    /// <inheritdoc />
    public async Task<string> UploadAsync(IFormFile file)
    {
        if (file is null || file.Length < 1) {
            throw new LineInvalidOperationException(Ln.File_cannot_be_empty);
        }

        if (!_uploadOptions.ContentTypes.Contains(file.ContentType)) {
            throw new LineInvalidOperationException(string.Format( //
                                                        CultureInfo.InvariantCulture, Ln.The_allowed_file_formats_are
                                                      , string.Join(",", _uploadOptions.ContentTypes)));
        }

        if (file.Length > _uploadOptions.MaxSize) {
            throw new LineInvalidOperationException(string.Format( //
                                                        CultureInfo.InvariantCulture
                                                      , Ln.Maximum_number_of_file_bytes_allowed
                                                      , _uploadOptions.MaxSize));
        }

        var             fileName   = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
        var             objectName = $"{UserToken.Id}/{fileName}";
        await using var fs         = file.OpenReadStream();
        return await _minioHelper.UploadAsync(objectName, fs, file.ContentType, file.Length);
    }
}