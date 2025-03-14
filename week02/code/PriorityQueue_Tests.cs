using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        // If the queue is empty, then an error exception shall be thrown.
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: It was skipping the last element and the condition was not comparing elements with same value.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
        priorityQueue.Enqueue("John", 2);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Moroni", 3);
        priorityQueue.Enqueue("Fred", 5);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Fred", priorityQueue.Dequeue());
        Assert.AreEqual("Moroni", priorityQueue.Dequeue());
        Assert.AreEqual("John", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.


    // The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    [TestMethod]
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        // Assert.Fail("Implement the test case and then remove this.");
        // If the queue is empty, then the item shall be added to the back of the queue.
        priorityQueue.Enqueue("John", 2);
        Assert.AreEqual("[John (Pri:2)]", priorityQueue.ToString());
    }

    // If the queue is not empty, then the item shall be added to the back of the queue.
    [TestMethod]
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John", 2);
        priorityQueue.Enqueue("Bob", 5);
        Assert.AreEqual("[John (Pri:2), Bob (Pri:5)]", priorityQueue.ToString());
    }

}


