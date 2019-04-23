using System;
using System.IO;
using System.Threading.Tasks;

namespace IO.Operations
{
    internal static class FileStreamsDemo
    {
        internal static async Task WriteFileFromSourceToDestination(string sourceFile, string destinationFile)
        {
            try
            {
                using (FileStream source = File.OpenRead(sourceFile))
                using (FileStream dest = File.Create(destinationFile))
                {
                    await source.CopyToAsync(dest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.ToString()}");
            }
        }

        internal static void ReadFileLength(string fileName)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    Console.WriteLine($"{Path.GetFileName(fileName)} is {fileStream.Length} bytes in size");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.ToString()}");
            }
        }
    }
}