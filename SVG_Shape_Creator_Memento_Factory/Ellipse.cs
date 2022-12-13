namespace SVG_Shape_Creator_Memento_Factory
{
    public class Ellipse: AbstractShape{
        private int CX, CY, RX, RY;
        private string Stroke, Fill, StrokeWidth;
        
        public Ellipse(int cx, int cy, int rx, int ry, Style style){
            CX = cx;
            CY = cy;
            RX = rx;
            RY = ry;
            Stroke = style.Stroke;
            Fill = style.Fill;
            StrokeWidth = style.StrokeWidth;
        }
        // public Ellipse(int cx, int cy, int rx, int ry){
        //     CX = cx;
        //     CY = cy;
        //     RX = rx;
        //     RY = ry;
        //     Fill = "cyan";
        //     Stroke = "black";
        //     StrokeWidth = "1";
        // }

        public override string ToSvg(){
            return $"<ellipse cx=\"{CX}\" cy=\"{CY}\" rx=\"{RX}\" ry=\"{RY}\" " +
            $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
    }
}