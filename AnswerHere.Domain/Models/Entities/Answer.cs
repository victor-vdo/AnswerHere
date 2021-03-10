using System;

namespace AnswerHere.Domain.Models.Entities
{
    public class Answer : Entity
    {     
        public string Message { get; set; }
        public Guid QuestionId { get; set; }
        public Guid UserAnswererId { get; set; }
        public bool BetterAnswer { get; set; }
    }
}
