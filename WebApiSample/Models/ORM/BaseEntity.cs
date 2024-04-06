namespace WebApiSample.Models.ORM
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
