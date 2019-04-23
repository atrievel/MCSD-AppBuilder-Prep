using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSectionSpearator("String Classes");
            string builderMessage = StringClasses.GenerateStringFromBuilder(100);
            Console.WriteLine("Builder says: {0}", builderMessage);
            Console.WriteLine($"Reader/Writer says: {StringClasses.GenerateStringFromReaderAndWriter(builderMessage).Result}");

            WriteSectionSpearator("Searching Strings");
            string searchFor = "exact";
            string message = "The string methods are usually better choices when you are searching for an exact string. Regular expressions are better when you are searching for some pattern is a source string.";
            Console.WriteLine($"The word {searchFor} occurs at position {SearchStrings.SearchForStringWithIndexOf(message, "exact")} in this message:");
            Console.WriteLine(message);
        }

        private static void WriteSectionSpearator(string sectionName)
        {
            Console.WriteLine("{0} {1} {0}", new string('-', 10), sectionName);
        }
    }
}
