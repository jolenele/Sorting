class UnOrderedArray
    {
        private int[] m_array;
        private int numElements;
        private int maxSize;

        public UnOrderedArray(int size)
        {
            maxSize = size;
            numElements = 0;
            m_array = new int[maxSize];
        }

        public void addLast(int item)
        {
            if (numElements < maxSize)
            {
                m_array[numElements] = item;
                numElements++;
            }
        }

        public void listItems()
        {
            for (int x=0; x < numElements; x++)
            {
                Console.Write(m_array[x] + ", ");
            }
            Console.WriteLine();
        }

        public void efficientRemove(int index)
        {
            if (index < numElements)
            {
                m_array[index] = m_array[numElements - 1];
                numElements--;
            }
        }

        public void seletionSortAsc()
        {
            for (int x = 0; x < numElements - 1; x++)
            {

                int smallestLoc = x;
                for (int y = x + 1; y < numElements; y++)
                {
                    if (m_array[y] < m_array[smallestLoc])
                    {
                        smallestLoc = y;
                    }
                }

                int temp = m_array[x];
                m_array[x] = m_array[smallestLoc];
                m_array[smallestLoc] = temp;
            }

        }

    }
