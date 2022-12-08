//Create | Update | Show | Delete | Quit
//Create - Creates a new shape.
//Update - Updates a shapes parameters.
//Show - Displays the current Canvas.
//Delete - Deletes a certain shape from the Canvas depending on ID entered.
//Quit - Quits the while loop, prints the SVG to console and creates a new file with the SVG.
using SVG_Shape_Creator_Factory.abstractFactory;
namespace SVG_Shape_Creator_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool flag = false; //creates a variable in order to end the while loop.
            Canvas canvas = new Canvas(1000, 1000); //Creates a canvas of size 1000 x 1000.

            RectangleFactory rectangleFactory = new RectangleFactory();
            CircleFactory circleFactory = new CircleFactory();
            EllipseFactory ellipseFactory = new EllipseFactory();
            PolygonFactory polygonFactory = new PolygonFactory();
            PolylineFactory polylineFactory = new PolylineFactory();
            LineFactory lineFactory = new LineFactory();
            PathFactory pathFactory = new PathFactory();
            
            while(flag == false){
                //Asks user for input. Depending on input do a certain function.
                Console.WriteLine("What function would you like to do?");
                Console.WriteLine("Create | Update | Show | Save | Delete | Quit");
                Console.WriteLine("Enter one from above");
                String input = Console.ReadLine();
                //Creates a new shape based on user input.
                if(input.Equals("Create", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Please input your desired Shape: ");
                    Console.WriteLine("NONE | Rectangle | Circle | Ellipse | Line | Polyline | Polygon | Path");
                    String shape = Console.ReadLine();
                    //Asks user for shape input, creates a shape depending on name.
                    //If NONE entered, will stop creating and will ask user for a function.
                    Console.WriteLine("You have entered: " +shape);
                    if(shape.Equals("Rectangle", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        Console.WriteLine("");
            
                        var r = rectangleFactory.CreateShape();
                        canvas.AddShape(r);

                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Circle", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        
                        var circle = circleFactory.CreateShape();
                        canvas.AddShape(circle);

                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Ellipse", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        Console.WriteLine("");

                        var ellipse = ellipseFactory.CreateShape();
                        canvas.AddShape(ellipse);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Line", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        Console.WriteLine("");
                        
                        var line = lineFactory.CreateShape();
                        canvas.AddShape(line);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Polyline", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        Console.WriteLine("");
                    
                        var polyline = polylineFactory.CreateShape();
                        canvas.AddShape(polyline);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Polygon", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        Console.WriteLine("");
                        
                        var polygon = polygonFactory.CreateShape();
                        canvas.AddShape(polygon);

                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Path", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("CORRECT SHAPE ENTERED");
                        Console.WriteLine("");
                        
                        var path = pathFactory.CreateShape();
                        canvas.AddShape(path);

                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("None", StringComparison.OrdinalIgnoreCase)){
                        Console.Clear();
                        Console.WriteLine("No more shapes being entered... Exiting");
                        flag = true;
                    }
                    else {
                        Console.Clear();
                        Console.WriteLine("\nINVALID SHAPE ENTERED\n");
                        continue;
                    }
                }
                else if(input.Equals("Delete", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Enter ID to delete");
                    for(int i = 0; i < canvas.Shapes.Count; i++){
                        Console.WriteLine(i+" " + canvas.Shapes[i].ToSvg());
                    }
                    int id = Int32.Parse(Console.ReadLine());
                    canvas.RemoveShape(id);
                    Console.Clear();
                    Console.WriteLine("Shape has been REMOVED...");
                    Console.WriteLine("-------------------------");
                    //Prints the object in SVG along with the object ID in order.
                    //Deletes a Shape object depending on user input.
                }
                //Updates the shape attributes based on user input.
                else if(input.Equals("Update", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Enter ID to Update");
                    for(int i = 0; i < canvas.Shapes.Count; i++){
                        Console.WriteLine(i+" " + canvas.Shapes[i].ToSvg());
                    }
                    int id = Int32.Parse(Console.ReadLine());
                    if(id > canvas.Shapes.Count-1){
                        Console.WriteLine("WRONG ID ENTERED, TRY AGAIN..");
                        continue;
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("rect")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'RECTANGLE' SHAPE");
                        canvas.RemoveShape(id);
                        
                        var r1 = rectangleFactory.CreateShape();
                        canvas.insertShape(id, r1);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");

                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("circle")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'CIRCLE' SHAPE");
                        canvas.RemoveShape(id);
                        
                        var circle1 = circleFactory.CreateShape();
                        canvas.insertShape(id, circle1);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("ellipse")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'ELLIPSE' SHAPE");
                        canvas.RemoveShape(id);
                        
                        var ellipse1 = ellipseFactory.CreateShape();
                        canvas.insertShape(id, ellipse1);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("line")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'LINE' SHAPE");
                        canvas.RemoveShape(id);
                        
                        var line1 = lineFactory.CreateShape();
                        canvas.insertShape(id, line1);
                    
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("polyline")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'POLYLINE' SHAPE");
                        canvas.RemoveShape(id);
                       
                        var polyline1 = polylineFactory.CreateShape();
                        canvas.insertShape(id, polyline1);
                        
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("polygon")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'POLYGON' SHAPE");
                        canvas.RemoveShape(id);
                        
                        var polygon1 = polygonFactory.CreateShape();
                        canvas.insertShape(id, polygon1);
                    
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("path")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'PATH' SHAPE");
                        canvas.RemoveShape(id);
                        
                        var path1 = pathFactory.CreateShape();
                        canvas.insertShape(id, path1);
                       
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                }
                //Displays the current canvas.
                else if(input.Equals("S", StringComparison.OrdinalIgnoreCase) || input.Equals("Show", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Displaying Current Canvas");
                    for(int i = 0; i < canvas.Shapes.Count; i++){
                        Console.WriteLine(i+" " + canvas.Shapes[i].ToSvg());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Returning to Main Menu...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("Save", StringComparison.OrdinalIgnoreCase))
                {
                    Canvas.SaveFile(canvas.ToSvg() + Environment.NewLine);
                    Console.Clear();
                    Console.WriteLine("Canvas has been saved to *Shape.svg*\n");
                    //Saves the current Canvas to Shape.svg
                }
                else if(input.Equals("Q", StringComparison.OrdinalIgnoreCase) || input.Equals("Quit", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("Program is quitting...Goodbye...");
                    break;
                    //Exits the while loop.
                }
            }//Parses input to check for user needs.
            
            Console.WriteLine(canvas.ToSvg());
            //Converts canvas to SVG and prints it to Console.
            Canvas.SaveFile(canvas.ToSvg() + Environment.NewLine);
            //Saves Canvas in SVG to a file.
        }
    }
}
