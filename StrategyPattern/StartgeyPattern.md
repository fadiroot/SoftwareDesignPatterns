# Strategy Pattern

## 📌 Definition
A **behavioral** design pattern that enables selecting an algorithm's behavior at **runtime** by encapsulating interchangeable algorithms behind a common interface.

## 🎯 Intent
- Define a family of algorithms
- Make them interchangeable
- Let clients choose the appropriate algorithm dynamically

## 🔑 Key Components
1. **Strategy Interface** - Common interface for all algorithms
2. **Concrete Strategies** - Implementations of different algorithms
3. **Context Class** - Maintains a reference to the current strategy

## ✅ When to Use
- When you need multiple variants of an algorithm
- When you want to switch algorithms at runtime
- To avoid conditional statements for algorithm selection

## 💡 Example Scenario
```csharp
// Strategy Interface
public interface ISortStrategy { void Sort(int[] data); }

// Concrete Strategies
public class QuickSort : ISortStrategy { ... }
public class BubbleSort : ISortStrategy { ... }

// Context
public class Sorter {
    private ISortStrategy _strategy;
    
    public void SetStrategy(ISortStrategy strategy) 
        => _strategy = strategy;
    
    public void SortData(int[] data) 
        => _strategy.Sort(data);
}