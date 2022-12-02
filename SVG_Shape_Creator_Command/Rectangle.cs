namespace assignment4{

public class Rectangle: AbstractShape{
        private int X, Y, Width, Height;
        private string Stroke, Fill, StrokeWidth;
        
        public Rectangle(int x, int y, int width, int height, string stroke, string fill, string strokeWidth){
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Stroke = stroke;
            Fill = fill;
            StrokeWidth = strokeWidth;
        }
        public Rectangle(int x, int y, int width, int height){
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Fill = "blue";
            Stroke = "black";
            StrokeWidth = "1";
        }

        public override string ToSvg(){
            return $"<rect x=\"{X}\" y=\"{Y}\" width=\"{Width}\" height=\"{Height}\" " +
                    $"fill=\"{Fill}\" stroke=\"{Stroke}\" stroke-width=\"{StrokeWidth}\"/>\n";
        }
        
    }
}