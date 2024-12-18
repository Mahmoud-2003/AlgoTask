using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTask
{
    public class HeapSort
    {

        public void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                Heapify(array, i, 0);
            }
        }


        private void Heapify(int[] array, int heapSize, int rootIndex)
        {
            int largest = rootIndex;  
            int left = 2 * rootIndex + 1;  
            int right = 2 * rootIndex + 2;  

            if (left < heapSize && array[left] > array[largest])
            {
                largest = left;
            }


            if (right < heapSize && array[right] > array[largest])
            {
                largest = right;
            }


            if (largest != rootIndex)
            {
                Swap(array, rootIndex, largest);
                Heapify(array, heapSize, largest);
            }

        }


        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
