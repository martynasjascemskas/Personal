namespace SVG_Shape_Creator_Factory
{
    public class Polygon: AbstractShape{
        private string Points, Stroke, Fill, StrokeWidth;
        
        public Polygon(string p1, string stroke, string fill, string strokeWidth){
            Points = p1;
            Stroke = stroke;
            Fill = fill;
            StrokeWidth = strokeWidth;
        }
        public Polygon(string p1){
            Points = p1;
            Fill = "lime";
            Stroke = "black";
            StrokeWidth = "1";
        }

        public override string ToSvg(){
            return $"<polygon points=\"{Points}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>";
        }
    }
}