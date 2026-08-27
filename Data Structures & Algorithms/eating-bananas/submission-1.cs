
public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max(); // 1
        long time = 0;
        int answer = 0; // 2


        while (left <= right) // Input: piles = [1,4,3,2], h = 9
        {

            int middle = left + (right - left) / 2; // 2

            foreach (int pile in piles)
            {
                time += (int)Math.Ceiling((double)pile / middle);
            }
            if (time > h)
            {
                left = middle + 1;
            }
            else
            {
                answer = middle;
                right = middle - 1;
            }
            time = 0;

        }
        return answer;
    }
}
