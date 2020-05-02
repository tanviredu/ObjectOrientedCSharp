using System;

namespace ACME.Common
{

    // string processing for the any class that
    // using it most common class 
    public static class Stringhandler
    {
        public static string InsetSpaces(string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrEmpty(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // before adding space
                        // if there are already spaces
                        // trim this space
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            // make sure the first space 
            // in the beginning get trimmed
            result = result.Trim();
            return result;
        }
    }
}
