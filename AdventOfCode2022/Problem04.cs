namespace AdventOfCode2022
{
    public class Problem04
    {
        public int OverlappingPairs(IList<IList<int>> list)
        {
            int pairs = 0;

            foreach (IList<int> pair in list)
            {
                if ((pair[2] >= pair[0] && pair[3] <= pair[1])||(pair[0] >= pair[2] && pair[1] <= pair[3]))

                {
                    pairs++;
                }
            }

            return pairs;
        }
        public int OverlappingPairs2(IList<IList<int>> list)
        {
            int pairs = 0;

            foreach (IList<int> pair in list)
            {
                if ((pair[2] >= pair[0] && pair[3] <= pair[1])||(pair[0] >= pair[2] && pair[1] <= pair[3])||
                    (pair[2] <= pair[0] && pair[0] <= pair[3])||(pair[0] <= pair[2] && pair[2] <= pair[1]))
                {
                    pairs++;
                }
            }

            return pairs;
        }
    }
}
