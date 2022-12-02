//A <shape> | U (Undo) | R (Redo) | Q (Quit) | H (Help) | C (Clear) |
//A <shape> - Creates a new shape.
//U(Undo) - Undos the last change made to the canvas.
//R(Redo) - Redos the last undo made to the canvas.
//S(Show) - Displays the current Canvas.
//H(Help) - Displays the options table.
//C(Clear) - Clears the canvas of any shapes.
//Q(Quit) - Quits the while loop, prints the SVG to console and creates a new file with the SVG.

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            memento.Originator originator = new memento.Originator(new Canvas(1000,1000));
            memento.Caretaker caretaker = new memento.Caretaker(originator);
            caretaker.Backup();
            
            bool flag = false; //creates a variable in order to end the while loop.
            var canvas = new Canvas(1000, 1000); //Creates a canvas of size 1000 x 1000.
            
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
                        
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Rectangle r = new Rectangle(x,y,height,width);
                        newCanvas.AddShape(r);
                        canvas.AddShape(r);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                        
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
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Circle circle = new Circle(cx,cy,r);
                        newCanvas.AddShape(circle);
                        canvas.AddShape(circle);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                    }
                    else{
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Circle circle2 = new Circle(cx,cy,r,stroke,fill,strokeWidth);
                        newCanvas.AddShape(circle2);
                        canvas.AddShape(circle2);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
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
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Ellipse ellipse = new Ellipse(cx,cy,rx,ry);
                        newCanvas.AddShape(ellipse);
                        canvas.AddShape(ellipse);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                    }
                    else{
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Ellipse ellipse2 = new Ellipse(cx,cy,rx,ry,stroke,fill,strokeWidth);
                        newCanvas.AddShape(ellipse2);
                        canvas.AddShape(ellipse2);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
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
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Line line = new Line(x1,y1,x2,y2);
                        newCanvas.AddShape(line);
                        canvas.AddShape(line);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                    }
                    else{
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Line line2 = new Line(x1,y1,x2,y2,fill,stroke,strokeWidth);
                        newCanvas.AddShape(line2);
                        canvas.AddShape(line2);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
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
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Polyline polyline = new Polyline(p1);
                        newCanvas.AddShape(polyline);
                        canvas.AddShape(polyline);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                    }
                    else{
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Polyline polyline2 = new Polyline(p1,stroke,fill,strokeWidth);
                        newCanvas.AddShape(polyline2);
                        canvas.AddShape(polyline2);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
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
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Polygon polygon = new Polygon(p1);
                        newCanvas.AddShape(polygon);
                        canvas.AddShape(polygon);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                    }
                    else{
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Polygon polygon2 = new Polygon(p1,stroke,fill,strokeWidth);
                        newCanvas.AddShape(polygon2);
                        canvas.AddShape(polygon2);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
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
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Path path = new Path(p1);
                        newCanvas.AddShape(path);
                        canvas.AddShape(path);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
                    }
                    else{
                        var newCanvas = new Canvas(canvas.getShapes(),1000,1000);
                        Path path2 = new Path(p1,stroke,fill,strokeWidth);
                        newCanvas.AddShape(path2);
                        canvas.AddShape(path2);
                        originator.restoreFromMemento(new memento.Memento(newCanvas));
                        caretaker.Backup();
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
                    caretaker.Undo();
                    var currentstate = originator.getCurrentState();
                    canvas = currentstate;
                }
                //Redo some function
                else if(input.Equals("R", StringComparison.OrdinalIgnoreCase) || input.Equals("Redo", StringComparison.OrdinalIgnoreCase)){
                    
                    Console.Clear();
                    caretaker.Redo();
                    var currentstate = originator.getCurrentState();
                    canvas = currentstate;
                }
                //Displays the current canvas.
                else if(input.Equals("S", StringComparison.OrdinalIgnoreCase) || input.Equals("Show", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Displaying Current Canvas");
                    Console.WriteLine(canvas.ToSvg());
                    Console.WriteLine("");
                    Console.WriteLine("Returning to Main Menu...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("Q", StringComparison.OrdinalIgnoreCase) || input.Equals("Quit", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("Program is quitting...Goodbye...");
                    break;
                    //Exits the while loop.
                }
                else if(input.Equals("H", StringComparison.OrdinalIgnoreCase) || input.Equals("Help", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Commands \nH	 	 Help displays this message \nA <shape>        Add shape to canvas\nU	 	 Undo last operation\nR	 	 Redo last operation\nC	 	 Clear canvas\nQ	 	 Quit application\nS	 	 Displays current canvas");
                }
                else if(input.Equals("C", StringComparison.OrdinalIgnoreCase) || input.Equals("Clear", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("Clearing canvas...");
                    canvas.clearCanvas();
                    originator.restoreFromMemento(new memento.Memento(canvas));
                    caretaker.Backup();
                    Console.Clear();
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
