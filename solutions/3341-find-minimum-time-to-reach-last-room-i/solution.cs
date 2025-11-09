using System;
using System.Collections.Generic;

public class Solution {
    public int MinTimeToReach(int[][] moveTime) {
        int m = moveTime.Length, n = moveTime[0].Length;
        int[,] dist = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                dist[i, j] = int.MaxValue;

        var pq = new PriorityQueue<(int x, int y), int>();
        dist[0, 0] = 0;
        pq.Enqueue((0, 0), 0);

        int[][] dirs = new int[][] {
            new int[] { 0, 1 }, new int[] { 1, 0 },
            new int[] { 0, -1 }, new int[] { -1, 0 }
        };

        while (pq.Count > 0) {
            var (x, y) = pq.Dequeue();
            int currentTime = dist[x, y];
            if (x == m - 1 && y == n - 1)
                return currentTime;

            foreach (var d in dirs) {
                int nx = x + d[0], ny = y + d[1];
                if (nx < 0 || ny < 0 || nx >= m || ny >= n) continue;

                int waitTime = Math.Max(moveTime[nx][ny], currentTime) + 1;
                if (waitTime < dist[nx, ny]) {
                    dist[nx, ny] = waitTime;
                    pq.Enqueue((nx, ny), waitTime);
                }
            }
        }

        return -1;
    }
}
