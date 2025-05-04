namespace StrategyPattern;

public interface IStrategyContext
{
    void SetMethod(ISortStrategy method);
    void ApplayMethod(int[] array); 
}