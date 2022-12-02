namespace app
{
    public class Path: AbstractShape{
        private string Points, Stroke, Fill, StrokeWidth;
        
        public Path(string p1, string stroke, string fill, string strokeWidth){
            Points = p1;
            Stroke = stroke;
            Fill = fill;
            StrokeWidth = strokeWidth;
        }
        public Path(string p1){
            Points = p1;
            Fill = "none";
            Stroke = "blue";
            StrokeWidth = "1";
        }

        public override string ToSvg(){
            return $"<path d=\"{Points}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}