using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate.Strings
{
    internal static class StringClasses
    {
        internal static string GenerateStringFromBuilder(int maxCapacity)
        {
            string piece = "Another one";
            StringBuilder builder = new StringBuilder(maxCapacity);

            for(int i = 0; i < maxCapacity / piece.Length; i++)
            {
                builder.AppendLine(piece);
            }

            return builder.ToString();
        }

        internal static async Task<string> GenerateStringFromReaderAndWriter(string original)
        {
            StringReader reader = new StringReader(original);
            StringWriter writer = new StringWriter();

            while (true)
            {
                string line = await reader.ReadLineAsync();

                if(!string.IsNullOrEmpty(line))
                {
                    await writer.WriteAsync($"{line} ");
                }
                else
                {
                    await writer.WriteAsync(" ---End of string found---\n");
                    break;
                }
            }

            return writer.ToString();
        }

    }
}