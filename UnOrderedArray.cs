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
            for(int i = 0; i < itemArray.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < itemArray.Length; j++)
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
            for (int i = 0; i < itemArray.Length - 1; i++)
            {
                int item = itemArray[i];
                int j = i;
                while (j > 0 && itemArray[j - 1] > item)
                {
                    itemArray[j] = itemArray[j - 1];
                    j = j - 1;
                    itemArray[j] = item;
                }
            }
        }
    }
}
