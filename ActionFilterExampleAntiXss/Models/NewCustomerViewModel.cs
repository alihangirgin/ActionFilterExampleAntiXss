namespace ActionFilterExampleAntiXss.Models
{
    public class NewCustomerViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int CustomerId { get; set; }
    }
}
