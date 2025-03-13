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
        // First, create the result var, with the size of the length
        double[] result = new double[length];
        // Iterate over the length of the array
        for (int i = 0; i < length; i++)
        {
            // Set the value of the array at the index to the number * (i + 1)
            result[i] = number * (i + 1);
        }



        return result; // return the result array
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

        // amount param validation
        if (amount < 1 || amount > data.Count)
        {
            throw new ArgumentOutOfRangeException("amount", "Amount must be between 1 and the length of the list");
        }

        // creates a new list to preserve the data
        // count how many items the list has and subtract the amount = where the new list will start
        // amount will also set the range of the new list (in all cases will never be greater than the list count)
        var newList = data.GetRange(data.Count - amount, amount);

        // Now we apply the same logic but use the range to remove the last items from the original list
        data.RemoveRange(data.Count - amount, amount);

        // Now we insert the new list at the beginning of the original list
        data.InsertRange(0, newList);

    }
}
