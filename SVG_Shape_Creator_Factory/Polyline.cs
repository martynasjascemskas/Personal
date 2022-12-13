namespace SVG_Shape_Creator_Factory
{
    public class Polyline: AbstractShape{
        private string Points, Stroke, Fill, StrokeWidth;
        
        public Polyline(string p1, Style style){
            Points = p1;
            Stroke = style.Stroke;
            Fill = style.Fill;
            StrokeWidth = style.StrokeWidth;
        }
        // public Polyline(string p1){
        //     Points = p1;
        //     Fill = "none";
        //     Stroke = "black";
        //     StrokeWidth = "1";
        // }

        public override string ToSvg(){
            return $"<polyline points=\"{Points}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}