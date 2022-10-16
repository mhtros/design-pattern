using System.Security.Cryptography;
using System.Text;
using Decorator.DataSource;

namespace Decorator.Decorators;

public class EncryptionDataSourceDecorator : DataSourceDecorator
{
    private readonly string _encryptionKey;

    public EncryptionDataSourceDecorator(IDataSource wrapped, string encryptionKey) : base(wrapped)
    {
        _encryptionKey = encryptionKey;
    }

    public override async Task SaveDataAsync(string data)
    {
        var encryptedData = EncryptString(_encryptionKey, data);
        await base.SaveDataAsync(encryptedData);
    }

    private static string EncryptString(string key, string plainInput)
    {
        var iv = new byte[16];
        byte[] array;

        using (var aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;

            var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (var streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plainInput);
                    }

                    array = memoryStream.ToArray();
                }
            }
        }

        return Convert.ToBase64String(array);
    }

    public override async Task<string> ReadDataAsync()
    {
        var encryptedData = await base.ReadDataAsync();
        var decryptedData = DecryptString(_encryptionKey, encryptedData);
        return decryptedData;
    }

    private static string DecryptString(string key, string cipherText)
    {
        var iv = new byte[16];
        var buffer = Convert.FromBase64String(cipherText);

        using var aes = Aes.Create();

        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.IV = iv;

        var decrypted = aes.CreateDecryptor(aes.Key, aes.IV);

        using var memoryStream = new MemoryStream(buffer);
        using var cryptoStream = new CryptoStream(memoryStream, decrypted, CryptoStreamMode.Read);
        using var streamReader = new StreamReader(cryptoStream);
        return streamReader.ReadToEnd();
    }
}