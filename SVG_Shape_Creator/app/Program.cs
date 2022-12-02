using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using CommandLine;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;

//Create | Update | Show | Delete | Quit
//Create - Creates a new shape.
//Update - Updates a shapes parameters.
//Show - Displays the current Canvas.
//Delete - Deletes a certain shape from the Canvas depending on ID entered.
//Quit - Quits the while loop, prints the SVG to console and creates a new file with the SVG.

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool flag = false; //creates a variable in order to end the while loop.
            Canvas canvas = new Canvas(1000, 1000); //Creates a canvas of size 1000 x 1000.
            
            while(flag == false){
                //Asks user for input. Depending on input do a certain function.
                Console.WriteLine("What function would you like to do?");
                Console.WriteLine("Create | Update | Show | Delete | Quit");
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
                            canvas.AddShape(r);
                        }
                        else{
                            Rectangle r2 = new Rectangle(x,y,height,width,stroke,fill,strokeWidth);
                            canvas.AddShape(r2);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Circle", StringComparison.OrdinalIgnoreCase)){
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
                            canvas.AddShape(circle);
                        }
                        else{
                            Circle circle2 = new Circle(cx,cy,r,stroke,fill,strokeWidth);
                            canvas.AddShape(circle2);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Ellipse", StringComparison.OrdinalIgnoreCase)){
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
                            canvas.AddShape(ellipse);
                        }
                        else{
                            Ellipse ellipse2 = new Ellipse(cx,cy,rx,ry,stroke,fill,strokeWidth);
                            canvas.AddShape(ellipse2);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Line", StringComparison.OrdinalIgnoreCase)){
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
                            canvas.AddShape(line);
                        }
                        else{
                            Line line2 = new Line(x1,y1,x2,y2,stroke,fill,strokeWidth);
                            canvas.AddShape(line2);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Polyline", StringComparison.OrdinalIgnoreCase)){
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
                            canvas.AddShape(polyline);
                        }
                        else{
                            Polyline polyline2 = new Polyline(p1,stroke,fill,strokeWidth);
                            canvas.AddShape(polyline2);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Polygon", StringComparison.OrdinalIgnoreCase)){
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
                            canvas.AddShape(polygon);
                        }
                        else{
                            Polygon polygon2 = new Polygon(p1,stroke,fill,strokeWidth);
                            canvas.AddShape(polygon2);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been inserted...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(shape.Equals("Path", StringComparison.OrdinalIgnoreCase)){
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
                            canvas.AddShape(path);
                        }
                        else{
                            Path path2 = new Path(p1,stroke,fill,strokeWidth);
                            canvas.AddShape(path2);
                        }
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
                            Rectangle r1 = new Rectangle(x,y,height,width);
                            canvas.insertShape(id, r1);
                        }
                        else{
                            Rectangle r11 = new Rectangle(x,y,height,width,stroke,fill,strokeWidth);
                            canvas.insertShape(id, r11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");

                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("circle")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'CIRCLE' SHAPE");
                        canvas.RemoveShape(id);
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
                            Circle circle1 = new Circle(cx,cy,r);
                            canvas.insertShape(id, circle1);
                        }
                        else{
                            Circle circle11 = new Circle(cx,cy,r,stroke,fill,strokeWidth);
                            canvas.insertShape(id, circle11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("ellipse")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'ELLIPSE' SHAPE");
                        canvas.RemoveShape(id);
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
                            Ellipse ellipse1 = new Ellipse(cx,cy,rx,ry);
                            canvas.insertShape(id, ellipse1);
                        }
                        else{
                            Ellipse ellipse11 = new Ellipse(cx,cy,rx,ry,stroke,fill,strokeWidth);
                            canvas.insertShape(id, ellipse11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("line")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'LINE' SHAPE");
                        canvas.RemoveShape(id);
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
                            Line line1 = new Line(x1,y1,x2,y2);
                            canvas.insertShape(id, line1);
                        }
                        else{
                            Line line11 = new Line(x1,y1,x2,y2,stroke,fill,strokeWidth);
                            canvas.insertShape(id, line11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("polyline")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'POLYLINE' SHAPE");
                        canvas.RemoveShape(id);
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
                            Polyline polyline1 = new Polyline(p1);
                            canvas.insertShape(id, polyline1);
                        }
                        else{
                            Polyline polyline11 = new Polyline(p1,stroke,fill,strokeWidth);
                            canvas.insertShape(id, polyline11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("polygon")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'POLYGON' SHAPE");
                        canvas.RemoveShape(id);
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
                            Polygon polygon1 = new Polygon(p1);
                            canvas.insertShape(id, polygon1);
                        }
                        else{
                            Polygon polygon11 = new Polygon(p1,stroke,fill,strokeWidth);
                            canvas.insertShape(id, polygon11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                    else if(canvas.Shapes[id].ToSvg().Contains("path")){
                        Console.Clear();
                        Console.WriteLine("UPDATING 'PATH' SHAPE");
                        canvas.RemoveShape(id);
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
                            Path path1 = new Path(p1);
                            canvas.insertShape(id, path1);
                        }
                        else{
                            Path path11 = new Path(p1,stroke,fill,strokeWidth);
                            canvas.insertShape(id, path11);
                        }
                        Console.Clear();
                        Console.WriteLine("Shape has been UPDATED...");
                        Console.WriteLine("-------------------------");
                    }
                }
                //Displays the current canvas.
                else if(input.Equals("Show", StringComparison.OrdinalIgnoreCase)){
                    Console.Clear();
                    Console.WriteLine("Displaying Current Canvas");
                    for(int i = 0; i < canvas.Shapes.Count; i++){
                        Console.WriteLine(i+" " + canvas.Shapes[i].ToSvg());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Returning to Main Menu...");
                    Console.WriteLine("-------------------------");
                }
                else if(input.Equals("Quit", StringComparison.OrdinalIgnoreCase)){
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
