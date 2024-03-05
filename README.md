# Custom Data Structures Implementation in C#

This repository contains custom implementations of the Stack, Queue, and Linked List data structures in C#. These implementations are designed to provide a better understanding of how these fundamental data structures work and how they can be implemented from scratch in C#.

## Table of Contents

- [Introduction](#introduction)
- [Implemented Data Structures](#implemented-data-structures)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

Data structures are essential components of any software system. They help organize and manage data efficiently, enabling faster access, insertion, and deletion operations. Understanding how these data structures are implemented can greatly enhance your understanding of algorithms and improve your programming skills.

## Implemented Data Structures

### 1. Stack

The `CustomStack` class implements the stack data structure. It provides methods for pushing elements onto the stack, popping elements off the stack, peeking at the top element without removing it, and checking if the stack is empty.

### 2. Queue

The `CustomQueue` class implements the queue data structure. It offers methods for enqueueing elements into the queue, dequeuing elements from the queue, peeking at the front element without removing it, and checking if the queue is empty.

### 3. Linked List

The `CustomLinkedList` class implements the linked list data structure. It consists of nodes where each node contains a data element and a reference to the next node in the sequence. This implementation supports operations like adding elements at the beginning or end of the list, removing elements, searching for elements, and retrieving elements by index.

## Usage

To use these custom data structures in your C# project, follow these steps:

1. Clone this repository to your local machine:
   `git clone https://github.com/WilliamsEnabulele/CSharp-DataStructure-Implementation.git`

2. Include the necessary files (`CustomStack.cs`, `CustomQueue.cs`, and `CustomLinkedList.cs`) in your C# project.

3. Instantiate the desired data structure in your code:

```csharp
// Example usage of CustomStack
CustomStack<int> stack = new CustomStack<int>();

// Example usage of CustomQueue
CustomQueue<string> queue = new CustomQueue<string>();

// Example usage of CustomLinkedList
CustomLinkedList<int> linkedList = new CustomLinkedList<int>();
```

## Contributing
Contributions to this repository are welcome. If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request. Please follow the existing code style and ensure that any changes are adequately tested.

## License


