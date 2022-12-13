namespace SVG_Shape_Creator_Memento_Factory
{
    public class Circle: AbstractShape{
        private int CX, CY, R;
        private string Stroke, Fill, StrokeWidth;
        
        public Circle(int cx, int cy, int r, Style style){
            CX = cx;
            CY = cy;
            R = r;
            Stroke = style.Stroke;
            Fill = style.Fill;
            StrokeWidth = style.StrokeWidth;
        }
        // public Circle(int cx, int cy, int r){
        //     CX = cx;
        //     CY = cy;
        //     R = r;
        //     Fill = "red";
        //     Stroke = "black";
        //     StrokeWidth = "1";
        // }

        public override string ToSvg(){
            return $"<circle cx=\"{CX}\" cy=\"{CY}\" r=\"{R}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}