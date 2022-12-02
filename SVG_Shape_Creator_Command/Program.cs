// //A <shape> | U (Undo) | R (Redo) | Q (Quit) | H (Help) | C (Clear) |
// //A <shape> - Creates a new shape.
// //U(Undo) - Undos the last change made to the canvas.
// //R(Redo) - Redos the last undo made to the canvas.
// //S(Show) - Displays the current Canvas.
// //H(Help) - Displays the options table.
// //C(Clear) - Clears the canvas of any shapes.
// //Q(Quit) - Quits the while loop, prints the SVG to console and creates a new file with the SVG.

namespace assignment4
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Canvas canvas = new Canvas(1000, 1000);
            command.Invoker invoker = new command.Invoker();
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
                    Console.WriteLine("Please enter your x value: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your y value: ");
                    int y = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your height value: ");
                    int height = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your width value: ");
                    int width = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Rectangle r = new Rectangle(x,y,height,width);
                        var cmd = new command.AddShapeCommand(canvas, r);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Rectangle r2 = new Rectangle(x,y,height,width,stroke,fill,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, r2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a circle", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("Please enter your cx value: ");
                    int cx = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your cy value: ");
                    int cy = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your r value: ");
                    int r = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Circle circle = new Circle(cx,cy,r);
                        var cmd = new command.AddShapeCommand(canvas, circle);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Circle circle2 = new Circle(cx,cy,r,stroke,fill,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, circle2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Ellipse", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("Please enter your cx value: ");
                    int cx = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your cy value: ");
                    int cy = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your rx value: ");
                    int rx = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your ry value: ");
                    int ry = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Ellipse ellipse = new Ellipse(cx,cy,rx,ry);
                        var cmd = new command.AddShapeCommand(canvas, ellipse);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Ellipse ellipse2 = new Ellipse(cx,cy,rx,ry,stroke,fill,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, ellipse2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Line", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter your x1 value: ");
                    int x1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your y1 value: ");
                    int y1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your x2 value: ");
                    int x2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your y2 value: ");
                    int y2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Line line = new Line(x1,y1,x2,y2);
                        var cmd = new command.AddShapeCommand(canvas, line);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Line line2 = new Line(x1,y1,x2,y2,fill,stroke,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, line2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Polyline", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter your Polyline values now: ");
                    string p1 = Console.ReadLine();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Polyline polyline = new Polyline(p1);
                        var cmd = new command.AddShapeCommand(canvas, polyline);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Polyline polyline2 = new Polyline(p1,stroke,fill,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, polyline2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Polygon", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter your Polygon values now: ");
                    string p1 = Console.ReadLine();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Polygon polygon = new Polygon(p1);
                        var cmd = new command.AddShapeCommand(canvas, polygon);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Polygon polygon2 = new Polygon(p1,stroke,fill,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, polygon2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("a Path", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("CORRECT SHAPE ENTERED");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter your Path values now: ");
                    string p1 = Console.ReadLine();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Leave ALL empty if you want to use default values. ENTER");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Please enter your stroke value: ");
                    string stroke = Console.ReadLine();
                    Console.WriteLine("Please enter your fill value: ");
                    string fill = Console.ReadLine();
                    Console.WriteLine("Please enter your stroke-width value: ");
                    string strokeWidth = Console.ReadLine();
                    if(fill.Equals("") && stroke.Equals("") && strokeWidth.Equals("")){
                        Path path = new Path(p1);
                        var cmd = new command.AddShapeCommand(canvas, path);
                        invoker.AddCommand(cmd);
                    }
                    else{
                        Path path2 = new Path(p1,stroke,fill,strokeWidth);
                        var cmd = new command.AddShapeCommand(canvas, path2);
                        invoker.AddCommand(cmd);
                    }
                    Console.Clear();
                    Console.WriteLine("Shape has been inserted...");
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
