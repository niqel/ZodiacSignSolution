namespace ApiZodiacSigns.Models
{
    public class Sign
    {
        public virtual int Id { get; set; }
        public string Name { get; set; }
        public int InitialMonth { get; set; }
        public int InitialDay { get; set; }
        public int FinalMonth { get; set; }
        public int FinalDay { get; set; }
        public virtual Element Element { get; set; }
        public virtual Planet Planet { get; set; }
    }
}