using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyWeb_ForLibrary.Util
{
    public static class ValidateUtil
    {
        public static bool IsCitizenID(string citizenID, bool ignoreEmpty = false)
        {
            if (string.IsNullOrEmpty(citizenID))
            {
                return ignoreEmpty;
            }
            else
            {
                string digit = null;

                //ตรวจสอบว่าทุก ๆ ตัวอักษรเป็นตัวเลข
                if (citizenID.ToCharArray().All(c => char.IsNumber(c)) == false)
                {
                    return false;
                }

                //ตรวจสอบว่าข้อมูลมีทั้งหมด 13 ตัวอักษร
                if (citizenID.Trim().Length != 13)
                {
                    return false;
                }

                int sumValue = 0;
                for (int i = 0; i < citizenID.Length - 1; i++)
                {
                    sumValue += int.Parse(citizenID[i].ToString()) * (13 - i);
                }

                int v = 11 - (sumValue % 11);
                if (v.ToString().Length == 2)
                {
                    digit = v.ToString().Substring(1, 1);
                }
                else
                {
                    digit = v.ToString();
                }

                return citizenID[12].ToString() == digit;
            }
        }
    }
}