namespace app
{

    public class Circle: AbstractShape{
        private int CX, CY, R;
        private string Stroke, Fill, StrokeWidth;
        
        public Circle(int cx, int cy, int r, string stroke, string fill, string strokeWidth){
            CX = cx;
            CY = cy;
            R = r;
            Stroke = stroke;
            Fill = fill;
            StrokeWidth = strokeWidth;
        }
        public Circle(int cx, int cy, int r){
            CX = cx;
            CY = cy;
            R = r;
            Fill = "red";
            Stroke = "black";
            StrokeWidth = "1";
        }

        public override string ToSvg(){
            return $"<circle cx=\"{CX}\" cy=\"{CY}\" r=\"{R}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>";
        }
    }
}