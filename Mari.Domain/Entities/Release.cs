using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mari.Domain.Common.Entities;
using Mari.Domain.Enums;
using Mari.Domain.ValueObjects;

namespace Mari.Domain.Entities
{
    public class Release : EntityBase<Guid>
    {
        public Release(Guid id) : base(id) 
        {
            
        }

        public override Guid Id { get; init; } 
        public string version {get;set;}
        public ReleasePlatform Platform {get; set;}
        public DateTime CompletionDate {get; set;}
        public DateTime DateOfChange {get; set;}
        public ReleaseStatus Status {get; set;}
    }
}