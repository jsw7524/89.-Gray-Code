using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89.Gray_Code
{
    public class Solution
    {
        private List<string> GrayCodeList { get; set; } = new List < string >{"0", "1"};
        public IList<int> GrayCode(int n)
        {
            if (n == 0)
            {
                return new List<int>(){0};
            }
            for (int i = 1; i < n; i++)
            {
                var tmp=GrayCodeList.Select(g => '0'+g).ToList();
                GrayCodeList.Reverse();
                GrayCodeList=tmp.Concat(GrayCodeList.Select(g => '1' + g)).ToList();
            }
            return GrayCodeList.Select(g => Convert.ToInt32(g, 2)).ToList();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var checker=(new Solution()).GrayCode(3);
        }
    }
}
