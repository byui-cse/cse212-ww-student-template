using System.Dynamic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //comment 1: The first thing we need to do is to create a list where the results will be stored (and will be the same length of the number provided)
        // and also create the first multiplier number, which will be increase in our "for" loop
        var resultList = new double[length];
        var multiplier = 1;

        //comment 2: create a for loop where will multiple the multiplicand by the multiplier until the fixed array reach the full length provied
        for (int i = 0; i < length; i++)
        {
            var multiplicationMath = number*multiplier;
            multiplier++;

            resultList[i] = multiplicationMath;
        }

        //comment 3: after all the math, the result will be store in the "resultList" array and will return the array at the end of the function.
        return resultList;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //comment 1: first we need to get a new list with the last numbers of the list that we have.
        //the numbers that we'll to get is from the "amount" number provided
        var split = data.GetRange(data.Count - amount, amount);

        //comment 2: after create the new list with the final numbers, in our "data" list we will delete these last numbers
        //and after that we'll be adding the new list numbers at the beggining of the "data" list
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, split);

    }
}