namespace SenacStore.Models
{
    public class Department
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public List<Seller> Sellers { get; set; } = new List<Seller>();
    }
}
