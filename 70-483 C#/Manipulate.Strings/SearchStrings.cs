using System;

namespace Manipulate.Strings
{
    internal static class SearchStrings
    {
        internal static int SearchForStringWithIndexOf(string source, string searchFor)
        {
            if(source.Contains(searchFor))
            {
                return source.IndexOf(searchFor);
            }
            else
            {
                return -1;
            }
        }
    }
}