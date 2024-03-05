using CustomLinkedList;

namespace Datastructure.Test;

public class CustomLinkedListTest
{
    [Fact]
    public void Add_AddItem_ReturnsCorrectSize()
    {
        // Arrange
        var linkedList = new CustomLinkedList<int>();

        // Act
        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);

        // Assert
        Assert.Equal(3, linkedList.Count());
    }

    [Fact]
    public void Remove_RemoveItem_ReturnsTrueIfExists()
    {
        // Arrange
        var linkedList = new CustomLinkedList<int>();
        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);

        // Act
        bool removed = linkedList.Remove(20);

        // Assert
        Assert.True(removed);
        Assert.Equal(2, linkedList.Count());
    }

    [Fact]
    public void Check_CheckItem_ReturnsTrueIfExists()
    {
        // Arrange
        var linkedList = new CustomLinkedList<int>();
        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);

        // Act
        bool exists = linkedList.Check(20);

        // Assert
        Assert.True(exists);
    }

    [Fact]
    public void Index_FindItem_ReturnsCorrectIndex()
    {
        // Arrange
        var linkedList = new CustomLinkedList<int>();
        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);

        // Act
        int index = linkedList.Index(20);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void AddAtHead_AddItemAtHead_SizeIncrements()
    {
        // Arrange
        var linkedList = new CustomLinkedList<int>();

        // Act
        linkedList.AddAtHead(10);
        linkedList.AddAtHead(20);
        linkedList.AddAtHead(30);

        // Assert
        Assert.Equal(3, linkedList.Count());
    }

    [Fact]
    public void GetEnumerator_AddItems_EnumeratesInCorrectOrder()
    {
        // Arrange
        var linkedList = new CustomLinkedList<int>();
        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);

        // Act
        int[] expectedItems = { 10, 20, 30 };
        int index = 0;
        foreach (var item in linkedList)
        {
            // Assert
            Assert.Equal(expectedItems[index++], item);
        }
    }
}