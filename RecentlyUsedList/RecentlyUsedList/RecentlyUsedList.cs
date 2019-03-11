using System;

namespace RecentlyUsedListNS
{
    public class RecentlyUsedList
    {
        private int[] list { get; }
        private int currentIndex;

        public RecentlyUsedList(int capacity = 100)
        {
            this.list = new int[capacity];
            currentIndex = 0;
        }

        public void Add(int number)
        {
            if (currentIndex >= list.Length)
            {
                return;
            }
            CheckAndAdjustIfDuplicate(number);

            list[currentIndex] = number;
            currentIndex++;
        }

        public int First()
        {
            return list[currentIndex - 1];
        }

        public int Last()
        {
            return list[0];
        }

        public int Index(int index)
        {
            var index2 = currentIndex - 1 - index;
            var item = list[index2];
            return list[currentIndex - 1 - index];
        }

        public bool IsEmpty()
        {
            return true;
        }

        private void CheckAndAdjustIfDuplicate(int number)
        {
            bool adjustArray = false;
            for (int i = 0; i < currentIndex; i++)
            {
                if (list[i] == number)
                {
                    adjustArray = true;
                    currentIndex--;
                }
                if (adjustArray)
                {
                    list[i] = list[i + 1];
                }
            }
        }
    }
}