using System.Drawing;

namespace SVG_Shape_Creator_Factory.abstractFactory
{
    public abstract class abstractFactory
    {
        public Random r = new Random();
        //microsoft.com/en-us/dotnet/api/system.drawing.knowncolor
        public abstract AbstractShape CreateShape(Style style);
    }

    class RectangleFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            int X = r.Next(1,500);
            int Y = r.Next(1,500);
            int Width = r.Next(1,100);
            int Height = r.Next(1,100);
            return new Rectangle(X,Y,Width,Height,style);
        }
    }
    class CircleFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            int CX = r.Next(1,500);
            int CY = r.Next(1,500);
            int R = r.Next(1,100);
            return new Circle(CX,CY,R,style);
        }
    }
    class EllipseFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            int CX = r.Next(1,500);
            int CY = r.Next(1,500);
            int RX = r.Next(1,100);
            int RY = r.Next(1,100);
            return new Ellipse(CX,CY,RX,RY,style);
        }
    }
    class LineFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            int X1 = r.Next(1,500);
            int Y1 = r.Next(1,500);
            int X2 = r.Next(1,100);
            int Y2 = r.Next(1,100);
            return new Line(X1,Y1,X2,Y2,style);
        }
    }
    class PathFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            string Points = "M 130 110 C 120 140, 180 140, 170 110";
            return new Path(Points,style);
        }
    }
    class PolygonFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            string Points = "100,100 150,25 150, 75 200,0";
            return new Polygon(Points,style);
        }
    }

    class PolylineFactory: abstractFactory
    {
        public override AbstractShape CreateShape(Style style)
        {
            string Points = "160,160 210,85 210,135 260,60";
            return new Polyline(Points,style);
        }
    }
    
}