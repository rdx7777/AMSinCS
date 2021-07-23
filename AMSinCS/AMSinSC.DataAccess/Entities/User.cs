namespace AMSinSC.DataAccess.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User : EntityBase
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        public string Password { get; set; }

        public string JobTitle { get; set; }

        public Position Position { get; set; }

        public string Role { get; set; }

        public bool IsActive { get; set; }
        }
}
