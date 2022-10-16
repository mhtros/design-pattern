// Encryptor Decorator

using Decorator.DataSource;
using Decorator.Decorators;

const string message1 = "very secret message";

var fileSrc1 = new FileDataSource($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\encrypted.txt");
var encryptionDataSrc = new EncryptionDataSourceDecorator(fileSrc1, "b14ca5898a4e4133bbce2ea2315a1916");

await encryptionDataSrc.SaveDataAsync(message1);

var decryptedMessage = await encryptionDataSrc.ReadDataAsync();
Console.WriteLine(decryptedMessage);

// Compressor Decorator

const string message2 = "This is a message what will be under compression when it will saved on the disk.";

var fileSrc2 = new FileDataSource($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\compressed.txt");
var compressionDataSrc = new CompressionDataSourceDecorator(fileSrc2);

await compressionDataSrc.SaveDataAsync(message2);

var decompressedData = await compressionDataSrc.ReadDataAsync();
Console.WriteLine(decompressedData);