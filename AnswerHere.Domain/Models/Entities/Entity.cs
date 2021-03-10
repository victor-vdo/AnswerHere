using AnswerHere.Domain.Interfaces;
using System;

namespace AnswerHere.Domain.Models.Entities
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
