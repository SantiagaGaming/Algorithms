using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
   public class Algorithm
    {
        private int[] _array;

        public Algorithm(int[] array)
        {
            _array = array;
        }

        public int InterpolationSearch(int serchingValue)
        {
            int high = _array.Length - 1;
            int low = 0;

            while(serchingValue>=_array[low] && serchingValue<=_array[high] && low<=high)
            {
                int probe = low + (high - low) * (serchingValue - _array[low]) / (_array[high] - _array[low]);
                Console.WriteLine(probe);
                if (_array[probe] == serchingValue)
                    return probe;
                else if (_array[probe] < serchingValue)
                    low = probe + 1;
                else high = probe - 1;
            }
            return -1;
        }
        public int BinarySearch(int serchingValue)
        {
            int low = 0;
            int high = _array.Length - 1;

            while (low<=high)
            {
                int middle = low + (high - low) / 2;
                int value = _array[middle];
                Console.WriteLine(middle);
                if (serchingValue > value)
                    low = middle + 1;
                else if (serchingValue < value)
                    high = middle - 1;
                else if (serchingValue == value)
                    return middle;
   
            }
            return -1;
        }
        public void SelectionSort()
        {
            for (int i = 0; i < _array.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < _array.Length; j++)
                {
                    if (_array[min] > _array[j])
                        min = j;
                }
                int temp = _array[i];
                _array[i] = _array[min];
                _array[min] = temp;
            }
        }
        public void BubbleSort()
        {
            for (int i = 0; i < _array.Length-1; i++)
            {
                for (int j = 0; j < _array.Length-i-1; j++)
                {
                    if(_array[j]>_array[j+1])
                    {
                        int temp = _array[j];
                        _array[j] = _array[j+1];
                        _array[j+1] = temp;
                    }
                }
            }
        }
        public void InsertionSort()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                int temp = _array[i];
                int j = i - 1;

                while(j>=0 && _array[j]>temp)
                {
                    _array[j + 1] = _array[j];
                    j--;
                }
                _array[j + 1] = temp;
            }
        }
   public int Factorial(int value)
        {
            if (value < 1) return 1;
            return value * Factorial(value - 1);
        }
        
    }
}
