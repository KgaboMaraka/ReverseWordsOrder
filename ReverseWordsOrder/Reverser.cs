using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsOrder
{   
    public class Reverser
    {
        public readonly IReverseOrder _reverseOrder ;

        public Reverser(IReverseOrder reverseOrder)
        {
            _reverseOrder = reverseOrder;
        }

        public void Reverse()
        {
            _reverseOrder.ReverseWordOrder();
        }
    }
}
