using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsOrder
{
    public class ReverseOrder : IReverseOrder
    {
        public int _testCases { get; set; }
        public string[] _strings { get; set; }

        public ReverseOrder(int testCases, string[] strings)
        {
            _testCases = testCases;
            _strings = strings;
        }

        public int TestCases
        {
            get { return _testCases; }
        }

        public string[] Strings
        {
            get { return _strings; }
        }

        public void ReverseWordOrder()
        {
            if(TestCases != Strings.Length) 
            {
                throw new Exception("testCases must be equal to the length of strings");
            }

            for (int i = 0; i < TestCases; i++)
            {
                string[] arrWords = Strings[i].Split(' ');
                Array.Reverse(arrWords);
                Console.WriteLine("Case " + (i + 1) + ": " + string.Join(" ", arrWords));
                Strings[i] = "Case " + (i + 1) + ": " + string.Join(" ", arrWords);
            }
        }
    }
}
