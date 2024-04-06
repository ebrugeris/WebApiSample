using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSample.Models.ORM
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; } = "İstanbul";
        public DateTime? BirthDate { get; set; }

        public int? UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University University { get; set; }
    }
}
