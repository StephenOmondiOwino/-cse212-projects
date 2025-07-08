using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create a new array of type double with size equal to 'length'.
        // 2. Loop from 0 to length - 1.
        // 3. In each iteration, calculate the multiple using: number * (i + 1).
        // 4. Store that value in the array at index i.
        // 5. After the loop ends, return the array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 to data.Count, inclusive.
    /// Because a list is dynamic, this function will modify the existing data list 
    /// rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Determine the portion of the list that will move to the front.
        //    This will be the last 'amount' elements.
        // 2. Use GetRange to extract the last 'amount' elements (from index data.Count - amount).
        // 3. Use GetRange to get the first part of the list (from index 0 to data.Count - amount).
        // 4. Clear the original list to prepare it for updated values.
        // 5. Add the rotated parts back into the original list in the new order: rightPart + leftPart.

        // Step 1: Get last 'amount' elements (right segment to move to front)
        List<int> rightPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the remaining elements (left segment)
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list
        data.Clear();

        // Step 4: Add rightPart first, then leftPart
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
