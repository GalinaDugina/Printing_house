namespace PH.Models
{
    public enum Part
    {
        этикет,
        колье,
        контра
    }
    public class PartOfKit
    {
        public int Id { get; set; }
        public Part Part{ get; set; }
        public  int OrderNameId{ get; set; }
        public virtual OrderName OrderName{ get; set; }
        public decimal Height{ get; set; }
        public decimal Width{ get; set; }
        public  int Quantity { get; set; }
        public bool Together{ get; set; }
        public int PaperId{ get; set; }
        public virtual Paper Paper{ get; set; }
    }
}