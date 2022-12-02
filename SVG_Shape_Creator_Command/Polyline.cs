namespace assignment4
{
    public class Polyline: AbstractShape{
        private string Points, Stroke, Fill, StrokeWidth;
        
        public Polyline(string p1, string stroke, string fill, string strokeWidth){
            Points = p1;
            Stroke = stroke;
            Fill = fill;
            StrokeWidth = strokeWidth;
        }
        public Polyline(string p1){
            Points = p1;
            Fill = "none";
            Stroke = "black";
            StrokeWidth = "1";
        }

        public override string ToSvg(){
            return $"<polyline points=\"{Points}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}