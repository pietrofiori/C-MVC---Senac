namespace SenacStore.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Salary { get; set; }
        public Department Deparment { get; set; }
        public int DeparmentId { get; set; }

        public  List<SalesRecord>  Sales { get; set; } = new List<SalesRecord>();

    }
}
