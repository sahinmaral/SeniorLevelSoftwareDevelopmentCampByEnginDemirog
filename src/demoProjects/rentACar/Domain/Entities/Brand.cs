﻿using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }

        
        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        public Brand()
        {
        }
    }
}
