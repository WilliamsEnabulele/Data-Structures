using MyQueue;

namespace Datastructure.Test;

public class CustomQueueTest
{
    [Fact]
    public void IsEmpty_NewQueue_ReturnsTrue()
    {
        // Arrange
        var queue = new CustomQueue<int>();

        // Act
        bool isEmpty = queue.IsEmpty();

        // Assert
        Assert.True(isEmpty);
    }

    [Fact]
    public void Enqueue_AddItem_QueueIsNotEmpty()
    {
        // Arrange
        var queue = new CustomQueue<int>();

        // Act
        queue.Enqueue(10);

        // Assert
        Assert.False(queue.IsEmpty());
    }

    [Fact]
    public void Dequeue_RemoveItem_QueueIsEmpty()
    {
        // Arrange
        var queue = new CustomQueue<int>();
        queue.Enqueue(10);

        // Act
        queue.Dequeue();

        // Assert
        Assert.True(queue.IsEmpty());
    }

    [Fact]
    public void Size_AddItems_ReturnsCorrectSize()
    {
        // Arrange
        var queue = new CustomQueue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Act
        int size = queue.Size();

        // Assert
        Assert.Equal(3, size);
    }

    [Fact]
    public void GetEnumerator_AddItems_EnumeratesInCorrectOrder()
    {
        // Arrange
        var queue = new CustomQueue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Act
        int[] expectedItems = { 10, 20, 30 };
        int index = 0;
        foreach (var item in queue)
        {
            // Assert
            Assert.Equal(expectedItems[index++], item);
        }
    }

    [Fact]
    public void Dequeue_EmptyQueue_ThrowsException()
    {
        // Arrange
        var queue = new CustomQueue<int>();

        // Act and Assert
        Assert.Throws<Exception>(() => queue.Dequeue());
    }
}