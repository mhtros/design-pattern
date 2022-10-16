using System.IO.Compression;
using System.Text;
using Decorator.DataSource;

namespace Decorator.Decorators;

public class CompressionDataSourceDecorator : DataSourceDecorator
{
    public CompressionDataSourceDecorator(IDataSource wrapped) : base(wrapped)
    {
    }

    public override Task SaveDataAsync(string data)
    {
        var compressedData = CompressData(data);
        return base.SaveDataAsync(compressedData);
    }


    private static string CompressData(string uncompressedString)
    {
        byte[] compressedBytes;

        using (var uncompressedStream = new MemoryStream(Encoding.UTF8.GetBytes(uncompressedString)))
        {
            using (var compressedStream = new MemoryStream())
            {
                using (var compressorStream = new DeflateStream(compressedStream, CompressionLevel.Fastest, true))
                {
                    uncompressedStream.CopyTo(compressorStream);
                }

                compressedBytes = compressedStream.ToArray();
            }
        }

        return Convert.ToBase64String(compressedBytes);
    }


    public override async Task<string> ReadDataAsync()
    {
        var compressedData = await base.ReadDataAsync();
        var decompressedData = DecompressData(compressedData);
        return decompressedData;
    }

    private static string DecompressData(string compressedString)
    {
        byte[] decompressedBytes;

        var compressedStream = new MemoryStream(Convert.FromBase64String(compressedString));

        using (var decompressorStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
        {
            using (var decompressedStream = new MemoryStream())
            {
                decompressorStream.CopyTo(decompressedStream);

                decompressedBytes = decompressedStream.ToArray();
            }
        }

        return Encoding.UTF8.GetString(decompressedBytes);
    }
}