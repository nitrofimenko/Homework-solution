using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_17
{
    internal static class Lib
    {
        public static bool QueryIsRight(string query, string reference, int maxLengthToFullCompare = 2)
        {
            if (query.Length <= maxLengthToFullCompare)
            {
                return query.ToLower() == reference.ToLower();
            }
            else
            {
                return reference.ToLower().Contains(query.ToLower());
            }
        }
    }
}
