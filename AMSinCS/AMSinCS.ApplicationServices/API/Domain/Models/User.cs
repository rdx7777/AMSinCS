namespace AMSinCS.ApplicationServices.API.Domain.Models
{
    using AMSinSC.DataAccess.Entities;

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string JobTitle { get; set; }

        public Position Position { get; set; }

        public string Role { get; set; }

    }
}
