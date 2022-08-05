namespace VisitorPattern.App
{
    public interface IComponent
    {
        bool Can(int number);
        string Do(int number);
    }
}
