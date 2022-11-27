using System;
using System.Text;

namespace Homework6
{
	public static class Split
	{
            public static string[] Custsplit(this string cumle, char? ayri = null)
            {

                if (ayri == null)
                {
                    ayri = ' ';
                }

                char[] array = cumle.ToCharArray();

                string[] arrstring = new string[0];

                string emptystring = string.Empty;

                for (int i = 0; i <= array.Length; i++)
                {
                    if (i == array.Length || array[i] == ayri)
                    {

                        Array.Resize(ref arrstring, arrstring.Length + 1);

                        arrstring.SetValue(emptystring, arrstring.Length - 1);

                    emptystring = string.Empty;

                    }
                    else
                    {
                    emptystring += array[i];

                    }
                }

                return arrstring;
            }
        
    }
}

