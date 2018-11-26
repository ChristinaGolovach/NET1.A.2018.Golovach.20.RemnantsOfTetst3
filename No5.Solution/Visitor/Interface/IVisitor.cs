namespace No5.Solution.Visitor
{
    public interface IVisitor<in TInput, out TOutput>
    {
        TOutput DynamicVisit(TInput inputType);
    }
}
