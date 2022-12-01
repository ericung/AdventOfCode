namespace AdventOfCode2022
{
    public class Problem01
    {
        public int CalorieCount(IList<IList<int>> fruits)
        {
            PriorityQueue<int,int> queue = new PriorityQueue<int,int>(Comparer<int>.Create(
                (a,b) => b - a));

            for (int i = 0; i < fruits.Count; i++)
            {
                int calories = 0;
                foreach(int fruit in fruits[i])
                {
                    calories += fruit;
                }
                queue.Enqueue(calories, calories);
            }
            return queue.Dequeue();
        }

        public int CalorieCountTopThree(IList<IList<int>> fruits)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create(
                (a, b) => b - a));

            for (int i = 0; i < fruits.Count; i++)
            {
                int calories = 0;
                foreach (int fruit in fruits[i])
                {
                    calories += fruit;
                }
                queue.Enqueue(calories, calories);
            }
            return queue.Dequeue() + queue.Dequeue() + queue.Dequeue();
        }
    }
}