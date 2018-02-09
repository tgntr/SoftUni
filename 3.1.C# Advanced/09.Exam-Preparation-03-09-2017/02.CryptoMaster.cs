using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CryptoMaster
{
    class CryptoMaster
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var bestLength = 0;
            for (int currentStartIndex = 0; currentStartIndex < numbers.Length; currentStartIndex++)
            {
                for (int currentStep = 0; currentStep < numbers.Length; currentStep++)
                {
                    var sequenceLength = 1;
                    var currentIndex = currentStartIndex;
                    
                    while (true)
                    {
                        var lastNumber = numbers[currentIndex];
                        currentIndex = (currentIndex + currentStep) % numbers.Length;
                        if (lastNumber >= numbers[currentIndex])
                            break;
                        sequenceLength++;
                    }
                    if (sequenceLength > bestLength)
                        bestLength = sequenceLength;
                }
            }
            Console.WriteLine(bestLength);
        }
    }
}
