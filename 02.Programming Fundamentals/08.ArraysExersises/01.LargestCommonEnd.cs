using System;

class LargestCommonEnd
{
    static void Main()
    {
        string[] first = Console.ReadLine().Trim().Split();
        string[] second = Console.ReadLine().Trim().Split();
        int largestCommonEnd = CountOfLargestCommon(first, second);
        Console.WriteLine(largestCommonEnd);
    }
    static int CountOfLargestCommon(string[] first, string[] second)
    {
        int largestCount = 0;
        int leftToRight = 0;
        int rightToLeft = 0;
        //int diagonal = 0;
        //int stopAtIndex = Math.Min(first.Length, second.Length);
        for (int i = 0; i < first.Length; i++)
        {
            int indexLeft = i;
            int indexRight = i;
            leftToRight = 0;
            rightToLeft = 0;
            for (int y = 0; y < second.Length; y++)
            {

                if (indexLeft > first.Length - 1 || indexRight > first.Length - 1)
                {
                    break;
                }
                if (first[indexLeft] == second[y])
                {
                    leftToRight++;

                    indexLeft++;
                }
                else
                {
                    indexLeft = i;
                    if (leftToRight > largestCount)
                    {
                        largestCount = leftToRight;
                    }
                    leftToRight = 0;
                }

                if (first[(first.Length - 1) - indexRight] == second[(second.Length - 1) - y])
                {
                    rightToLeft++;

                    indexRight++;
                }

                else
                {
                    indexRight = i;
                    if (rightToLeft > largestCount)
                    {
                        largestCount = rightToLeft;
                    }
                    rightToLeft = 0;
                }
            }

            if (leftToRight > largestCount)
            {
                largestCount = leftToRight;
            }
            if (rightToLeft > largestCount)
            {
                largestCount = rightToLeft;
            }
            return largestCount;
        }

        return largestCount;

    }
}
