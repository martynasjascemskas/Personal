using System.Drawing;
namespace SVG_Shape_Creator_Command_Factory
{
    public class Style{
        public String Fill{get; set;}
        public String Stroke{get; set;}
        public String StrokeWidth{get; set;}
        private Random r = new Random();
        public KnownColor[] allcolors = (KnownColor[])Enum.GetValues(typeof(KnownColor));

        public Style(){
            Fill = allcolors[r.Next(allcolors.Length)].ToString();
            StrokeWidth = r.Next(1,15).ToString();
            Stroke = allcolors[r.Next(allcolors.Length)].ToString();
        }

    }
}