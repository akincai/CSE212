using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue of size 3 with the highest priority item in the center and dequeue one item
    // Expected Result: The center item with the highest priority will be dequeued ("Buzz")
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Fizz", 1);
        priorityQueue.Enqueue("Buzz", 5);
        priorityQueue.Enqueue("Fuzz", 3);
        Assert.AreEqual(priorityQueue.Dequeue(), "Buzz");
    }

    [TestMethod]
    // Scenario: A queue has three items placed inside: two of the same priority, and one of lower in the back
    // Expected Result: The item with the highest priority which is closest to the front of the queue will be dequeued ("Snap")
    // Defect(s) Found: When comparing priority and moving away from the front of the stack, items with the same priority are updated to highest priority
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Snap", 5);
        priorityQueue.Enqueue("Crackle", 5);
        priorityQueue.Enqueue("Pop", 1);
        Assert.AreEqual(priorityQueue.Dequeue(), "Snap");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: A dequeue operation is performed on an empty queue
    // Expected Result: An error message will be printed
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("An error should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
            Assert.Fail(string.Format("Unexpected exception of type {0} caught: {1}", e.GetType(), e.Message));
        }
    }

    [TestMethod]
    // Scenario: A queue of three items has the highest priority item at the back when dequeue-ing
    // Expected Result: The back item will be dequeued ("Pop")
    // Defect(s) Found: Off by one error with loop bound preventing the last item in the list from being compared for priority
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Snap", 3);
        priorityQueue.Enqueue("Crackle", 3);
        priorityQueue.Enqueue("Pop", 5);
        Assert.AreEqual(priorityQueue.Dequeue(), "Pop");
    }
}