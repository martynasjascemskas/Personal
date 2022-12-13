namespace SVG_Shape_Creator_Memento_Factory{

public class Rectangle: AbstractShape{
        private int X, Y, Width, Height;
        private string Stroke, Fill, StrokeWidth;
        
        public Rectangle(int x, int y, int width, int height, Style style){
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Stroke = style.Stroke;
            Fill = style.Fill;
            StrokeWidth = style.StrokeWidth;
        }
        // public Rectangle(int x, int y, int width, int height){
        //     X = x;
        //     Y = y;
        //     Width = width;
        //     Height = height;
        //     Fill = "blue";
        //     Stroke = "black";
        //     StrokeWidth = "1";
        // }

        public override string ToSvg(){
            return $"<rect x=\"{X}\" y=\"{Y}\" width=\"{Width}\" height=\"{Height}\" " +
                    $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
        
    }
}