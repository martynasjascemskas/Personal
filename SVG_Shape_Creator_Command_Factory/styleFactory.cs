namespace SVG_Shape_Creator_Command_Factory
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