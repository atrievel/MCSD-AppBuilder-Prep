using System;
using System.IO;
using System.Threading.Tasks;

namespace IO.Operations
{
    class Program
    {
        private static readonly string FILE_TO_READ = $"{Directory.GetCurrentDirectory()}\\testfile.txt";
        private static readonly string FILE_TO_WRITE = $"{Directory.GetCurrentDirectory()}\\testfile_new.txt";
        static void Main(string[] args)
        {
            // demo reading/writing form file streams
            FileStreamsDemo.WriteFileFromSourceToDestination(FILE_TO_READ, FILE_TO_WRITE).Wait();
            FileStreamsDemo.ReadFileLength(FILE_TO_WRITE);
        }
    }
}
