using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: [item1, item2, item3]
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {

        var item1 = new PriorityItem("item1", 5);
        var item2 = new PriorityItem("item2", 3);
        var item3 = new PriorityItem("item3", 2);

        PriorityItem[] expectedResult = [item1, item2, item3];
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);

        int i = 0;
        var expectedResultString = "[";

        for (i = 0; i < expectedResult.Length; i++)
        {
            expectedResultString += $"{expectedResult[i].ToString()}, ";
        }
        expectedResultString = expectedResultString.TrimEnd(',', ' ');
        expectedResultString += "]";
        var item = priorityQueue.ToString();
        Assert.AreEqual(expectedResultString, item);
    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value. 
    // Expected Result: item2, item1, item3
    // Defect(s) Found: loop for was not covering all items
    public void TestPriorityQueue_2()
    {
        var item1 = new PriorityItem("item1", 3);
        var item2 = new PriorityItem("item2", 5);
        var item3 = new PriorityItem("item3", 2);

        PriorityItem[] expectedResult = [item2, item1, item3];
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        
        int i = 0;
        for (; i < expectedResult.Length; i++){
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            Console.WriteLine(item);
        }
        

    }
    
    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value. 
    // Expected Result: item2, item4, item1, item3
    // Defect(s) Found: The dequeued method didn't include the case when we have two items with the same priority.
    public void TestPriorityQueue_3()
    {
        var item1 = new PriorityItem("item1", 3);
        var item2 = new PriorityItem("item2", 5);
        var item3 = new PriorityItem("item3", 2);
        var item4 = new PriorityItem("item4", 5);

        PriorityItem[] expectedResult = [item2, item4, item1, item3];
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item4.Value, item4.Priority);
        
        int i = 0;
        for (; i < expectedResult.Length; i++){
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            Console.WriteLine(item);
        }
        
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: An error is thrown
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        try
            {
                priorityQueue.Dequeue();
                Assert.Fail("Exception should have been thrown.");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("The queue is empty.", e.Message);
            }
            catch (AssertFailedException)
            {
                throw;
            }
            catch (Exception e)
            {
                Assert.Fail(
                    string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }
        
    }
}