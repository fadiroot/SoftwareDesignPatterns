namespace StrategyPattern;

public class Context : IStrategyContext
{
    private ISortStrategy _sortStrategy;


    public void SetMethod(ISortStrategy method)
    {
        _sortStrategy = method; 
    }

    public void ApplayMethod(int[] array)
    {
        _sortStrategy.Sort(array);
    }
}