namespace csharpdrills;

public delegate int Comparison<in T>(T left, T right);
public class DelegatesAndEvents
{
    public Comparison<int> Comparator;

    public DelegatesAndEvents()
    {
        Comparator = ComparisonFunc;
    }

    public DelegatesAndEvents(bool useLambda) {
        if (!useLambda) Comparator = ComparisonFunc;
        else Comparator = (left, right) => (left > right) ? -1 : (left < right) ? 1 : 0;
    }

    public DelegatesAndEvents(object? placeHolder, bool multipleTargets)
    {
        Comparator += ComparisonFunc;
        Comparator += ComparisonFuncTwo;
    }

    private int ComparisonFunc(int left, int right) 
    {
        if (left > right) return -1;
        if (left < right) return 1;
        return 0;
    }

    private int ComparisonFuncTwo(int left, int right)
    {
        return left + right * (left - right);
    }
}
