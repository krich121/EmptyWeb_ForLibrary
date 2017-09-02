using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyWeb_ForLibrary.Util
{
    public static class IntExtension
    {
        public static string Encrypt(this int originalValue)
        {
            return originalValue.ToString(); //Encrypt(originalValue.ToString());
        }

        public static string Decrypt(this int originalValue)
        {
            return originalValue.ToString(); //Decrypt(originalValue.ToString());
        }

        public static string Encrypt(this int? originalValue, bool zeroIsEmpty = false)
        {
            if (originalValue.HasValue)
            {
                if (zeroIsEmpty)
                {
                    return string.Empty;
                }
                else
                {
                    return originalValue.ToString(); //Encrypt(originalValue.ToString());
                }
            }
            else
            {
                return string.Empty;
            }
        }

        public static string Decrypt(this int? originalValue)
        {
            if (originalValue.HasValue)
            {
                return originalValue.ToString(); //Decrypt(originalValue.ToString());
            }
            else
            {
                return string.Empty;
            }
        }

        public static string ToString(this int? originalValue)
        {
            if (originalValue.HasValue)
            {
                return originalValue.Value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}