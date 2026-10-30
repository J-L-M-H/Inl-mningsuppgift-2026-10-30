using static System.Net.Mime.MediaTypeNames;

namespace Rentals

{
    public class Bike
    {
        public int Index { get; set; }

        public virtual string Type { get; set; } = "Bike";

        public string Availability { get; set; } = "Ledig";

        public virtual int Rate { get; set; } = 20;
        public virtual void Display()
        {
            Console.WriteLine($"""
            {Index}   {Type}    {Availability}
            """);
        }
        
    } 
}
