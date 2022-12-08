// //A <shape> | U (Undo) | R (Redo) | Q (Quit) | H (Help) | C (Clear) |
// //A <shape> - Creates a new shape.
// //U(Undo) - Undos the last change made to the canvas.
// //R(Redo) - Redos the last undo made to the canvas.
// //S(Show) - Displays the current Canvas.
// //H(Help) - Displays the options table.
// //C(Clear) - Clears the canvas of any shapes.
// //Q(Quit) - Quits the while loop, prints the SVG to console and creates a new file with the SVG.
using SVG_Shape_Creator_Command_Factory.abstractFactory;
namespace SVG_Shape_Creator_Command_Factory
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Canvas canvas = new Canvas(1000, 1000);
            command.Invoker invoker = new command.Invoker();

            RectangleFactory rectangleFactory = new RectangleFactory();
            CircleFactory circleFactory = new CircleFactory();
            EllipseFactory ellipseFactory = new EllipseFactory();
            PolygonFactory polygonFactory = new PolygonFactory();
            PolylineFactory polylineFactory = new PolylineFactory();
            LineFactory lineFactory = new LineFactory();
            PathFactory pathFactory = new PathFactory();

            bool flag = false;
            while(flag == false){
                //Asks user for input. Depending on input do a certain function.
                Console.WriteLine("What function would you like to do?");
                Console.WriteLine("A <shape> | U (Undo) | R (Redo) | S (Show) | H (Help) | C (Clear) | Q (Quit) |");
                Console.WriteLine("Enter one from above");
                Console.WriteLine();
                Console.WriteLine("***If Entering shape, select one from below. (None will quit program)");
                Console.WriteLine("NONE | Rectangle | Circle | Ellipse | Line | Polyline | Polygon | Path");
                String input = Console.ReadLine();
                
                if(input.Equals("a rectangle", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");

                    var r = rectangleFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, r);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Rectangle has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a circle", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    
                    var circle = circleFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, circle);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Circle has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Ellipse", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");

                    var r = ellipseFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, r);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Ellipse has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Line", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");

                    var line = rectangleFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, line);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Line has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Polyline", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                   
                    var pline = polylineFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, pline);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Polyline has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Polygon", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");

                    var polygon = polygonFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, polygon);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Polygon has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Path", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");
                    
                    var path = pathFactory.CreateShape();
                    var cmd = new command.AddShapeCommand(canvas, path);
                    invoker.AddCommand(cmd);

                    Console.Clear();
                    Console.WriteLine("Random Path has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("None", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("No more shapes being entered... Exiting");
                    flag = true;
                }
                //Undo some function
                else if(input.Equals("U", StringComparison.OrdinalIgnoreCase) || input.Equals("Undo", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    invoker.Undo();
                }
                //Redo some function
                else if(input.Equals("R", StringComparison.OrdinalIgnoreCase) || input.Equals("Redo", StringComparison.OrdinalIgnoreCase)){
                    
                    Console.Clear();
                    invoker.Redo();
                }
                //Displays the current canvas.
                else if(input.Equals("S", StringComparison.OrdinalIgnoreCase) || input.Equals("Show", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Displaying Current Canvas");
                    foreach(var shape in canvas.Shapes)
                    {
                        Console.Write(shape.ToSvg());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Returning to Main Menu...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("Q", StringComparison.OrdinalIgnoreCase) || input.Equals("Quit", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("Program is quitting...Goodbye...");
                    break;
                    //Exits the while loop.
                }
                else if(input.Equals("Save", StringComparison.OrdinalIgnoreCase))
                {
                    Canvas.SaveFile(canvas.ToSvg() + Environment.NewLine);
                    Console.Clear();
                    Console.WriteLine("Canvas has been saved to *Shape.svg*\n");
                    //Saves the current Canvas to Shape.svg
                }
                else if(input.Equals("H", StringComparison.OrdinalIgnoreCase) || input.Equals("Help", StringComparison.OrdinalIgnoreCase)){
                    //Displays the help menu
                    Console.Clear();
                    Console.WriteLine("Commands \nH	 	 Help displays this message \nA <shape>        Add shape to canvas\nU	 	 Undo last operation\nR	 	 Redo last operation\nC	 	 Clear canvas\nQ	 	 Quit application\nS	 	 Displays current canvas\nSave	 	 Saves the current Canvas");
                }
                else {
                    Console.Clear();
                    Console.WriteLine("\nINVALID INPUT ENTERED...TRY AGAIN...\n");
                }
            }//Parses input to check for user needs.
            
            Console.WriteLine(canvas.ToSvg());
            //Converts canvas to SVG and prints it to Console.
            Canvas.SaveFile(canvas.ToSvg() + Environment.NewLine);
            //Saves Canvas in SVG to a file.
        }
    }
}
