using System;
namespace Homework6
{
    public static class Contains
    {
        #region 1
        public static bool Contain(this string s1, string s2 )
        {
            string toLower = s1.ToLower();

            string whiteSpace = " ";

            String.IsNullOrWhiteSpace(whiteSpace);

            string[] array = toLower.Split();

            foreach (var item in array)
            {
                if (item==s2)
                {
                    return true;
                }
                if (s2.Equals(s1))
                {
                    return true;
                }
                else if (s1.Equals(s2))
                {
                    return true;
                }
                else if (s2.Equals(s1.ToUpper()))
                {
                    return true;
                }
                else if (s2.Equals(s1.ToLower()))
                {
                    return true;
                }
                else if (s1.StartsWith(s2))
                {
                    return true;
                }
                else if (s2.EndsWith(s1))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion



    }


}


