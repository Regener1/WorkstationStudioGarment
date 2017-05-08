using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkstationStudioGarment_WinForm.tool
{
    public class Parser
    {
        public static int[] ParseStringToArray(string str, char separator)
        {
            try
            {
                string[] tmp = str.Split(separator);
                int[] result = new int[tmp.Length];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = int.Parse(tmp[i]);
                }
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
