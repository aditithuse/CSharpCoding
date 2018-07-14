/*Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water. */

using System;

namespace ConsoleApp1.Mathematical
{
    class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            int area = 0;

            while (l < r)
            {
                // Calculating the max area
                area = Math.Max(area, Math.Min(height[l], height[r]) * (r - l));

                if (height[l] < height[r])
                    l += 1;

                else
                    r -= 1;
            }
            return area;
        }
    }
}
