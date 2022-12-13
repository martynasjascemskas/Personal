namespace SVG_Shape_Creator_Factory
{
    public abstract class styleFactory
    {
        public abstract Style CreateStyle();
    }
    public class StylingFactory: styleFactory
    {
        public override Style CreateStyle()
        {
            return new Style();
        }
    }
    
}