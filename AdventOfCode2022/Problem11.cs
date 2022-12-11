namespace AdventOfCode2022
{
    public class Problem11
    {
        long MOD;

        public int FindMostActive(IList<IList<IList<string>>> monkeys)
        {
            int n = monkeys.Count;
            int[] operations = new int[n];
            Queue<int>[] monkeyItemsQueue = new Queue<int>[n];
            for (int i = 0; i < n; i++)
            {
                monkeyItemsQueue[i] = new Queue<int>();
                foreach(var s in monkeys[i][1])
                {
                    monkeyItemsQueue[i].Enqueue(Convert.ToInt32(s));
                }
            }

            for (int i = 0; i < 20; i++)
            {
                for (int m = 0; m < n; m++)
                {
                    while (monkeyItemsQueue[m].Count > 0)
                    {
                        int currentItem = monkeyItemsQueue[m].Dequeue();
                        currentItem = PerformOperation(currentItem, monkeys[m][2][1], monkeys[m][2][2]);
                        currentItem /= 3;
                        if (PerformDivisibilityTest(currentItem, Convert.ToInt32(monkeys[m][3][2])))
                        {
                            var throwTo = Convert.ToInt32(monkeys[m][4][0]);
                            monkeyItemsQueue[throwTo].Enqueue(currentItem);
                        }
                        else
                        {
                            var throwTo = Convert.ToInt32(monkeys[m][4][1]);
                            monkeyItemsQueue[throwTo].Enqueue(currentItem);
                        }

                        operations[m]++;
                    }
                }
            }

            Array.Sort(operations);
            int mostActive = 0;
            mostActive = operations[n - 1] * operations[n - 2];
            return mostActive;
        }

        public long FindMostActiveLong(IList<IList<IList<string>>> monkeys)
        {
            int n = monkeys.Count;
            int[] operations = new int[n];
            Queue<long>[] monkeyItemsQueue = new Queue<long>[n];
            MOD = 1;

            for (int i = 0; i < n; i++)
            {
                monkeyItemsQueue[i] = new Queue<long>();
                foreach(var s in monkeys[i][1])
                {
                    monkeyItemsQueue[i].Enqueue(long.Parse(s));
                }

                MOD *= long.Parse(monkeys[i][3][2]);
            }

            for (int i = 0; i < 10000; i++)
            {
                for (int m = 0; m < n; m++)
                {
                    while (monkeyItemsQueue[m].Count > 0)
                    {
                        long currentItem = monkeyItemsQueue[m].Dequeue();
                        currentItem = PerformOperationLong(currentItem, monkeys[m][2][1], monkeys[m][2][2]);
                        currentItem = currentItem % MOD;
                        if (PerformDivisibilityTestLong(currentItem, Convert.ToInt32(monkeys[m][3][2])))
                        {
                            var throwTo = Convert.ToInt32(monkeys[m][4][0]);
                            monkeyItemsQueue[throwTo].Enqueue(currentItem);
                        }
                        else
                        {
                            var throwTo = Convert.ToInt32(monkeys[m][4][1]);
                            monkeyItemsQueue[throwTo].Enqueue(currentItem);
                        }

                        operations[m]++;
                    }
                }
            }

            Array.Sort(operations);
            long mostActive = 0;
            mostActive = (long)operations[n - 1] * (long)operations[n - 2];
            return mostActive;
        }

        private long PerformOperationLong(long value, string operation, string num)
        {
            long opNum = 0;
            if (num == "old")
            {
                opNum = value;
            }
            else
            {
                opNum = long.Parse(num);
            }

            switch(operation)
            {
                case "+":
                    return value + opNum;
                case "*":
                    return value * opNum;
            }

            return 0;
        }

        private bool PerformDivisibilityTestLong(long value, long divisor)
        {
            return value % divisor == 0;
        }

        private int PerformOperation(int value, string operation, string num)
        {
            int opNum = 0;
            if (num == "old")
            {
                opNum = value;
            }
            else
            {
                opNum = Convert.ToInt32(num);
            }

            switch(operation)
            {
                case "+":
                    return value + opNum;
                case "*":
                    return value * opNum;
            }

            return 0;
        }

        private bool PerformDivisibilityTest(int value, int divisor)
        {
            return value % divisor == 0;
        }
    }
}
