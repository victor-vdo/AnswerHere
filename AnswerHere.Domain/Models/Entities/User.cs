using System;

namespace AnswerHere.Domain.Models.Entities
{
    public class User: Entity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Experience { get; set; }
        public int TotalPoints { get; set; }
        public long FacebookId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime LastAcess { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
