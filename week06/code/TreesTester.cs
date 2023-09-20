public static class TreesTester {
    /// <summary>
    /// Entry point for the Prove 9 tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        // After implementing 'no duplicates' rule,
        // this next insert will have no effect on the tree.
        // TODO Problem 1
        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(10);
        tree.Insert(1);
        tree.Insert(6);
        Console.WriteLine(tree.ToString()); // 1, 3, 4, 5, 6, 7, 10

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        Console.WriteLine(tree.Contains(3)); // True
        Console.WriteLine(tree.Contains(2)); // False
        Console.WriteLine(tree.Contains(7)); // True
        Console.WriteLine(tree.Contains(6)); // True
        Console.WriteLine(tree.Contains(9)); // False

        Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
        foreach (var value in tree.Reverse()) {
            Console.WriteLine(value); // 10, 7, 6, 5, 4, 3, 1
        }

        Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");
        Console.WriteLine(tree.GetHeight()); // 3
        tree.Insert(6);
        Console.WriteLine(tree.GetHeight()); // 3
        tree.Insert(12);
        Console.WriteLine(tree.GetHeight()); // 4

        Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========");
        var tree1 = CreateTreeFromSortedList(new[] { 10, 20, 30, 40, 50, 60 });
        var tree2 = CreateTreeFromSortedList(Enumerable.Range(0, 127).ToArray()); // 2^7 - 1 nodes
        var tree3 = CreateTreeFromSortedList(Enumerable.Range(0, 128).ToArray()); // 2^7 nodes
        var tree4 = CreateTreeFromSortedList(new[] { 42 });
        var tree5 = CreateTreeFromSortedList(Array.Empty<int>());
        Console.WriteLine(tree1.GetHeight()); // 3
        Console.WriteLine(tree2.GetHeight()); // 7 .. any higher and its not balanced
        Console.WriteLine(tree3.GetHeight()); // 8 .. any higher and its not balanced
        Console.WriteLine(tree4.GetHeight()); // 1
        Console.WriteLine(tree5.GetHeight()); // 0
    }

    /// <summary>
    /// Given a sorted list (sorted_list), create a balanced BST.  If the values in the
    /// sortedNumbers were inserted in order from left to right into the BST, then it
    /// would resemble a linked list (unbalanced). To get a balanced BST, the
    /// InsertMiddle function is called to find the middle item in the list to add
    /// first to the BST. The InsertMiddle function takes the whole list but also takes
    /// a range (first to last) to consider.  For the first call, the full range of 0 to
    /// Length-1 used.
    /// </summary>
    private static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers) {
        var bst = new BinarySearchTree(); // Create an empty BST to start with 
        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);
        return bst;
    }

    /// <summary>
    /// This function will attempt to insert the item in the middle of 'sortedNumbers' into
    /// the 'bst' tree. The middle is determined by using indices represented by 'first' and
    /// 'last'.
    /// For example, if the function was called on:
    /// <code>
    /// sortedNumbers = new[]{10, 20, 30, 40, 50, 60};
    /// first = 0;
    /// last = 5;
    /// </code>
    /// then the value 30 (index 2 which is the middle) would be added 
    /// to the 'bst' (the insert function in the <see cref="BinarySearchTree"/> can be used
    /// to do this).   
    ///
    /// Subsequent recursive calls are made to insert the middle from the values 
    /// before 30 and the values after 30.  If done correctly, the order
    /// in which values are added (which results in a balanced bst) will be:
    /// <code>
    /// 30, 10, 20, 50, 40, 60
    /// </code>
    /// This function is intended to be called the first time by CreateTreeFromSortedList.
    ///
    /// The purpose for having the first and last parameters is so that we do 
    /// not need to create new sub-lists when we make recursive calls.  Avoid 
    /// using list slicing to create sub-lists to solve this problem.    
    /// </summary>
    /// <param name="sortedNumbers">input numbers that are already sorted</param>
    /// <param name="first">the first index in the sortedNumbers to insert</param>
    /// <param name="last">the last index in the sortedNumbers to insert</param>
    /// <param name="bst">the BinarySearchTree in which to insert the values</param>
    private static void InsertMiddle(int[] sortedNumbers, int first, int last, BinarySearchTree bst) {
        // TODO Start Problem 5
    }
}