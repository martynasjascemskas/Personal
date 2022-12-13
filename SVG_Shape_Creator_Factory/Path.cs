namespace SVG_Shape_Creator_Factory
{
    public class Path: AbstractShape{
        private string Points, Stroke, Fill, StrokeWidth;
        
        public Path(string p1, Style style){
            Points = p1;
            Stroke = style.Stroke;
            Fill = style.Fill;
            StrokeWidth = style.StrokeWidth;
        }
        // public Path(string p1){
        //     Points = p1;
        //     Fill = "none";
        //     Stroke = "blue";
        //     StrokeWidth = "1";
        // }

        public override string ToSvg(){
            return $"<path d=\"{Points}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}