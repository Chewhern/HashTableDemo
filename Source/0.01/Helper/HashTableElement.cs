using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo.Helper
{
    public class HashTableElement
    {
        public int Value;
        public List<int> ChainedValues = new List<int>();
        public int State;
    }
}
