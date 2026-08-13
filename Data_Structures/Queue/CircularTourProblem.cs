using System;

namespace QueueApp.Problems;

public static class CircularTourProblem
{
    public static int FindStartingPump(int[] petrol, int[] distance)
    {
        if (petrol == null || distance == null || petrol.Length != distance.Length || petrol.Length == 0)
        {
            return -1;
        }

        var total = 0;
        var remaining = 0;
        var start = 0;

        for (var i = 0; i < petrol.Length; i++)
        {
            total += petrol[i] - distance[i];
            remaining += petrol[i] - distance[i];

            if (remaining < 0)
            {
                start = i + 1;
                remaining = 0;
            }
        }

        return total >= 0 ? start : -1;
    }
}
