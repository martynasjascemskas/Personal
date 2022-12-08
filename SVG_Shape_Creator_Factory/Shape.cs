namespace SVG_Shape_Creator_Factory
{
    public abstract class AbstractShape
    {
        public abstract string ToSvg();
    }
    public class Canvas{
        public List<AbstractShape> Shapes;
        private int Width, Height;
        public Canvas(int width, int height){
            Shapes = new List<AbstractShape>();
            Width = width;
            Height = height;
        }

        public Canvas(List<AbstractShape> shapes, int width, int height){
            Shapes = shapes;
            Width = width;
            Height = height;
        }

        private string BoilerSVG = $"<?xml version=\"1.0\" standalone=\"no\"?>\n" +
            $"<svg width=\"{1000}\" height=\"{1000}\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\">\n";
        
        public void AddShape(AbstractShape shape){
            Shapes.Add(shape);
            //Adds shape to object list.
        }
        public void RemoveShape(int id){
            Shapes.RemoveAt(id);
            //Removes shape from object list on object ID.
        }
        public void insertShape(int id, AbstractShape shape){
            Shapes.Insert(id, shape);
        }

        public string ToSvg(){
            var svg = BoilerSVG;
            foreach (var shape in Shapes)
            {
                svg = string.Concat(svg, shape.ToSvg());
            }
            svg = string.Concat(svg, "\n</svg>");
            return svg;
            //Converts Canvas to SVG.
        }
        public static async Task SaveFile(string text){
            await File.WriteAllTextAsync("Shape.svg", text);
            //Writes file to Shape.svg file.
        }
    }
}
