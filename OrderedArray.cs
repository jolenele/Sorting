using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class OrderedArray
    {
        private int[] m_array;
        private int maxSize;
        private int numElements;
        public OrderedArray(int size)
        {
            numElements = 0;
            maxSize = size;
            m_array = new int[size];
        }
        public bool addLast(int item)
        {
            if (numElements >= maxSize) return false;
            m_array[numElements] = item;
            numElements++;
            return true;
        }
        public int search(int item)
        {
            for(int i=0; i < numElements; i++)
            {
                if (m_array[i] == item)
                    return i;
            }
            return -1;
        }
        public string listItems()
        {
            string s = "";
            for(int i = 0; i < numElements; i++)
            {
                s += m_array[i] + " ";
            }
            return s;
        }
        public void insertionSortAsc()
        {
            for(int i=1; i<numElements; i++)
            {
                int temp = m_array[i];
                int j = i;
                while(j>0 && m_array[j - 1] > temp)
                {
                    m_array[j] = m_array[j-1];
                    j--;
                }
                m_array[j] = temp;
            }
        }
        public void merge(int lo, int mid, int hi)
        {
            int i = lo;
            int k = 0;
            int j = mid + 1;
            while(i<=mid && j<=hi)
            {
                if(m_array[i] < m_array[j])
                {
                    temp[k] = m_array[i];
                    k++;
                    j++;
                }
                else
                {
                    m_array[lo++]=m_array[mid++]
                }
            }
        }
        public void mergeSort(int lo, int hi)
        {
            int mid;
            if (lo < hi)
            {
                mid = (lo + hi) / 2;
                mergeSort(lo, mid);
                mergeSort(mid+1, hi);
                mergeSort(lo, mid, hi);
            }
        }
    }
}
