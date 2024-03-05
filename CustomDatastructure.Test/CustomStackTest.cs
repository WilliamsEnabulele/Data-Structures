using MyStack;

namespace Datastructure.Test
{
    public class CustomStackTest
    {
        [Fact]
        public void IsEmpty_NewStack_ReturnsTrue()
        {
            // Arrange
            var stack = new CustomStack<int>();

            // Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.True(isEmpty);
        }

        [Fact]
        public void Push_AddItem_StackIsNotEmpty()
        {
            // Arrange
            var stack = new CustomStack<int>();

            // Act
            stack.Push(10);

            // Assert
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Pop_RemoveItem_StackIsEmpty()
        {
            // Arrange
            var stack = new CustomStack<int>();

            stack.Push(10);

            // Assert
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void Peek_AddItems_ReturnsLastItemAdded()
        {
            // Arrange
            var stack = new CustomStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Act
            int peekedItem = stack.Peek();

            // Assert
            Assert.Equal(30, peekedItem);
        }

        [Fact]
        public void Size_AddItems_ReturnsCorrectSize()
        {
            // Arrange
            var stack = new CustomStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Act
            int size = stack.Size();

            // Assert
            Assert.Equal(3, size);
        }

        [Fact]
        public void GetEnumerator_AddItems_EnumeratesInCorrectOrder()
        {
            // Arrange
            var stack = new CustomStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Act
            int[] expectedItems = { 30, 20, 10 };
            int index = 0;
            foreach (var item in stack)
            {
                // Assert
                Assert.Equal(expectedItems[index++], item);
            }
        }

        [Fact]
        public void Pop_EmptyStack_ThrowsException()
        {
            // Arrange
            var stack = new CustomStack<int>();

            // Act and Assert
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void Peek_EmptyStack_ThrowsException()
        {
            // Arrange
            var stack = new CustomStack<int>();

            // Act and Assert
            Assert.Throws<Exception>(() => stack.Peek());
        }
    }
}