using System.Drawing;

namespace SVG_Shape_Creator_Command_Factory.abstractFactory
{
    public abstract class abstractFactory
    {
        public Random r = new Random();
        public string Fill, Stroke, StrokeWidth;

        public KnownColor[] allcolors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        //microsoft.com/en-us/dotnet/api/system.drawing.knowncolor
        public abstract AbstractShape CreateShape();
    }

    class RectangleFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            int X = r.Next(1,1000);
            int Y = r.Next(1,1000);
            int Width = r.Next(1,100);
            int Height = r.Next(1,100);
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Rectangle(X,Y,Width,Height,Stroke,Fill,StrokeWidth);
        }
    }
    class CircleFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            int CX = r.Next(1,1000);
            int CY = r.Next(1,1000);
            int R = r.Next(1,100);
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Circle(CX,CY,R,Stroke,Fill,StrokeWidth);
        }
    }
    class EllipseFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            int CX = r.Next(1,1000);
            int CY = r.Next(1,1000);
            int RX = r.Next(1,100);
            int RY = r.Next(1,100);
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Ellipse(CX,CY,RX,RY,Stroke,Fill,StrokeWidth);
        }
    }
    class LineFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            int X1 = r.Next(1,1000);
            int Y1 = r.Next(1,1000);
            int X2 = r.Next(1,100);
            int Y2 = r.Next(1,100);
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Line(X1,Y1,X2,Y2,Stroke,Fill,StrokeWidth);
        }
    }
    class PathFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            string Points = "M 130 110 C 120 140, 180 140, 170 110";
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Path(Points,Stroke,Fill,StrokeWidth);
        }
    }
    class PolygonFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            string Points = "100,100 150,25 150, 75 200,0";
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Polygon(Points,Stroke,Fill,StrokeWidth);
        }
    }

    class PolylineFactory: abstractFactory
    {
        public override AbstractShape CreateShape()
        {
            string Points = "160,160 210,85 210,135 260,60";
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
            return new Polyline(Points,Stroke,Fill,StrokeWidth);
        }
    }
    
}