using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoAviator
{
    class Helpers
    {
        public static int[] StringToArray(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return new int[0];
            }

            string[] strArray = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            int[] array = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                array[i] = int.Parse(strArray[i]);
            }
            return array;
        }

        public static string ArrayToString(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('{');            
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                if (i != array.Length - 1)
                    sb.Append(',');
            }
            sb.Append('}');

            return sb.ToString();
        }
    }
}
