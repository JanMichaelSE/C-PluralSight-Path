using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrEmpty(source))
            {
                for(var i = 0; i < source.Length; i++)
                {
                    if (char.IsUpper(source[i]) && i != 0 && !char.IsWhiteSpace(source[i - 1]))
                    {
                        result += " ";
                    }
                    result += source[i];
                }
            }
            return result;
            
        }
    }
}
