using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsOrder
{
    public interface IReverseOrder
    {
        public int _testCases { get; set; }
        public string[] _strings { get; set; }

        void ReverseWordOrder();
    }
}
