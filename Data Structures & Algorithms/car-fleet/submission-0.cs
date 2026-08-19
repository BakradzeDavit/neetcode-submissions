public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        List<(int position, int speed)> cars = new();
        decimal[] times = new decimal[position.Length];
        int fleets = 0;
        decimal fleetTime = 0;
        for (int i = 0; i < position.Length; i++)
        {
            cars.Add((position[i], speed[i]));
        }
        cars.Sort((a, b) => b.position.CompareTo(a.position));

        for (int i = 0; i < cars.Count; i++)
        {
            times[i] = (decimal)(target - cars[i].position) / cars[i].speed;
        }

        for (int i = 0; i < times.Length; i++)
        {
            if (times[i] > fleetTime)
            {
                fleetTime = times[i];
                fleets++;
            }
        }
        return fleets;
    }
}
