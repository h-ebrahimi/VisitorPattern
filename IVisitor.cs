namespace VisitorPattern.App
{
    public interface IVisitor
    {
        List<IComponent> Components { get; set; }
        void AddComponent(IComponent component);
    }
}
