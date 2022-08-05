namespace VisitorPattern.App
{
    public class Visitor : IVisitor
    {
        public Visitor()
        {
            Components = new List<IComponent>();
        }
        public List<IComponent> Components { get; set; }

        public void AddComponent(IComponent component)
        {
            Components.Add(component);
        }
    }
}
