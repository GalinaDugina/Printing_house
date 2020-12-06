namespace PH.Models
{
    public class Paper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Height{ get; set; }
        public decimal Width{ get; set; }
        public int Density{ get; set; }
        public decimal Price{ get; set; }
    }
}