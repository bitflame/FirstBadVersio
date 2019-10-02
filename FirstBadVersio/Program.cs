using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBadVersio
{
    class Program : IsBadVersion
    {

        static void Main(string[] args)
        {
            FirstBadVersion(10);
        }
        private static int FirstBadVersion(Int32 n)
        {
            int start = 0;
            int end = n;
            Program p = new Program();
            while (start + 1 < end)
            {
                int mid = start + (end - start) / 2;
                if (p.IsBadVersion(mid))
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            if (p.IsBadVersion(start))
            {
                return start;
            }
            return end;
        }

        public bool IsBadVersion(int n)
        {
            if (n <= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
