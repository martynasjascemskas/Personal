namespace assignment4
{
    public class Line: AbstractShape{
        private int X1, Y1, X2, Y2;
        private string Stroke, Fill, StrokeWidth;
        
        public Line(int x1, int y1, int x2, int y2, string stroke, string fill, string strokeWidth){
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Stroke = stroke;
            Fill = fill;
            StrokeWidth = strokeWidth;
        }
        public Line(int x1, int y1, int x2, int y2){
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Fill = "black";
            Stroke = "black";
            StrokeWidth = "1";
        }

        public override string ToSvg(){
            return $"<line x1=\"{X1}\" y1=\"{Y1}\" x2=\"{X2}\" y2=\"{Y2}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}