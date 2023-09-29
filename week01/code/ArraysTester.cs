public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return new double[0]; // replace this return statement with your own
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    }
}
