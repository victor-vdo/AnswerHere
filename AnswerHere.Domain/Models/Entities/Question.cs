using System;
namespace AnswerHere.Domain.Models.Entities
{
    public class Question : Entity
    {
        public string Message { get; set; }
        public Guid UserQuestionerId { get; set; }
        public int Rating { get; set; }
        public Guid BetterAnswer { get; set; }
    }
}
