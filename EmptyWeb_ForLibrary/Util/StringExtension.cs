using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyWeb_ForLibrary.Util
{
    public static class StringExtension
    {
        public static string Encrypt(this string originalValue)
        {
            if (string.IsNullOrEmpty(originalValue))
            {
                return string.Empty;
            }
            else
            {
                return originalValue; //Encrypt(originalValue);
            }
        }

        public static string Decrypt(this string originalValue)
        {
            if (string.IsNullOrEmpty(originalValue))
            {
                return string.Empty;
            }
            else
            {
                return originalValue; //Decrypt(originalValue);
            }
        }

        public static string UrlDecode(this string originalValue)
        {
            if (string.IsNullOrEmpty(originalValue))
            {
                return string.Empty;
            }
            else
            {
                return HttpUtility.UrlDecode(originalValue);
            }
        }

        public static string TrimNull(this string originalValue)
        {
            return (originalValue == null) ? string.Empty : originalValue.Trim();
        }

        public static string ReplaceNullOrEmpty(this string originalValue, string replaceValue)
        {
            if (originalValue == null)
            {
                return replaceValue.TrimNull();
            }
            else if (originalValue.Trim().Length == 0)
            {
                return replaceValue.Trim();
            }
            else
            {
                return originalValue.Trim();
            }
        }

        public static bool ToBoolean(this string originalValue)
        {
            if (string.IsNullOrEmpty(originalValue))
            {
                return false;
            }
            else if (originalValue.Equals("1"))
            {
                return true;
            }
            else if (originalValue.ToUpper().Equals("Y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int? ToNullableInt(this string originalValue)
        {
            if (string.IsNullOrEmpty(originalValue))
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(originalValue);
            }
        }

        public static int ToInt(this string originalValue)
        {
            if (string.IsNullOrEmpty(originalValue))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(originalValue);
            }
        }
    }
}