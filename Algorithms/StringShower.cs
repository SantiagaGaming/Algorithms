using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class StringShower
    {
        private int[] _array;
        public StringShower(int [] array)
        {
            _array = array;
        }
        public string GetArrayText()
        {
            string arrayText = "";
            for (int i = 0; i < _array.Length-1; i++)
            {
                arrayText += _array[i].ToString() +" ";
            }
            return arrayText;
        }
    }
}
