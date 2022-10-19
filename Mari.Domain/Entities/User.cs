using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mari.Domain.Common.Entities;
using Mari.Domain.Enums;

namespace Mari.Domain.Entities
{
    public class User : EntityBase<Guid>
    {
        public User(Guid id) : base(id) // говорил что все конструктуры должны быть пусты
        {
            
        }

        public override Guid Id { get; init; }   
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public UserRole Role {get; set;}
        
    }
}