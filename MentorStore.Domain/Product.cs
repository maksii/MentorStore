﻿namespace MentorStore.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; } 
        public int Category_Id { get; set; }  
    }
}
