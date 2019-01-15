using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UnOrderedArray
    {
        private int[] itemArray;
        private int numItem;
        private int maxItems;
        public UnOrderedArray(int max)
        {
            numItem = 0;
            maxItems = max;
            itemArray = new int[max];
        }
        public bool addLast(int item)
        {
            if (numItem >= maxItems)
                return false;
            itemArray[numItem] = item;
            numItem++;
            return true;
        }
        public int search(int item)
        {
            for(int i=0; i < itemArray.Length; i++)
            {
                if (itemArray[i] == item)
                    return i;
            }
            return -1;
        }
        public bool efficientDelete(int item)
        {
            int pos = search(item);
            if(pos!=-1)
            {
                itemArray[pos] = itemArray[numItem - 1];
                numItem--;
                return true;
            }
            return false;
        }
        public void printList()
        {
            for(int i=0; i < itemArray.Length; i++)
            {
                Console.Write(itemArray[i] + " ");
            }
        }
        public void SelectionSortASC()
        {
            for(int i = 0; i < numItem; i++)
            {
                int min = i;
                for(int j = i + 1; j < numItem; j++)
                {
                    if (itemArray[j] < itemArray[min])
                        min = j;
                }
                int temp = itemArray[i];
                itemArray[i] = itemArray[min];
                itemArray[min] = temp;
            }
        }
        public void InsertionSortAsc()
        {
            for (int i = 1; i < numItem; i++)
            {
                int temp = itemArray[i];
                int j = i;
                while (j > 0 && itemArray[j - 1] > temp)
                {
                    itemArray[j] = itemArray[j - 1];
                    j = j - 1;
                    itemArray[j] = temp;
                }
            }
        }
        public void andrew()
        {
            for(int start=1;start<numItem; start++)
            {
                int temp = itemArray[start];
                int y = start - 1;
                while (y >= 0 && itemArray[y] > temp)
                {
                    itemArray[y + 1] = itemArray[y];
                    y--;
                }
                itemArray[y + 1] = temp;
            }
        }
        public int BinarySearch(int item)
        {
            InsertionSortAsc();
            int lo = 0;
            int hi = numItem - 1;
            int mid = 0;
            while (lo <= hi)
            {
                mid = (lo + hi) / 2;
                if (itemArray[mid] == item)
                {
                    return mid;
                }
                if (itemArray[mid] > item)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            return -1;
        }
    }
}
